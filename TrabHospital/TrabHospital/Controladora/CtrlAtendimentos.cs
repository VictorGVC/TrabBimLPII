using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabHospital.Modelo;
using TrabHospital.Persistencia;

namespace TrabHospital.Controladora
{
    class CtrlAtendimentos
    {
        Banco bco = new Banco();
        private Atendimento atendimentoAtual = new Atendimento();
        private Diagnostico diagnostico = new Diagnostico();
        private Medico medico = new Medico();
        private Paciente paciente = new Paciente();

        public bool SalvarAtendimento(int coddiagn, int codpac, int codmed, DateTime data, string anamnese)
        {
            MedicoBD mbd = new MedicoBD(bco);
            PacienteBD pbd = new PacienteBD(bco);
            DiagnosticoBD dbd = new DiagnosticoBD(bco);
            bool result;
            bco.Conecta();
            atendimentoAtual.Data = data;
            atendimentoAtual.Diagnostico = (Diagnostico)dbd.BuscarDiagnostico(coddiagn);
            atendimentoAtual.Paciente = (Paciente)pbd.PesquisarPaciente2(codpac);
            atendimentoAtual.Medico = (Medico)mbd.BuscarMedico(codmed);
            atendimentoAtual.Anamnase = anamnese;
            AtendimentoBD abd = new AtendimentoBD(bco);
            atendimentoAtual.Valorconta = 0;
            foreach (Conta conta in atendimentoAtual.Conta)
                atendimentoAtual.Valorconta += conta.Valorconta * conta.Qtde;
            result = abd.SalvarAtendimento(atendimentoAtual);
            bco.Desconecta();
            return result;
        }

        public DataTable BuscaDiagnosticos()
        {
            DataTable dtdiags = new DataTable();

            dtdiags.Columns.Add("dia_codigo", typeof (int));
            dtdiags.Columns.Add("dia_descricao");

            bco.Conecta();
            DiagnosticoBD diagdb = new DiagnosticoBD(bco);
            foreach(Diagnostico diag in diagdb.BuscarDiagnosticos(""))
            {
                DataRow row = dtdiags.NewRow();
                row["dia_codigo"] = diag.Codigo;
                row["dia_descricao"] = diag.Descricao;
                dtdiags.Rows.Add(row);
            }
            bco.Desconecta();
            return dtdiags;
        }

        internal object BuscaMedicos2(int v)
        {
            DataTable dtmed = new DataTable();
            bco.Conecta();

            dtmed.Columns.Add("med_codigo", typeof(int));
            dtmed.Columns.Add("pla_codigo");
            dtmed.Columns.Add("med_nome");
            dtmed.Columns.Add("med_crm");
            dtmed.Columns.Add("med_fone");
            dtmed.Columns.Add("med_celular");

            MedicoBD mdb = new MedicoBD(bco);
            foreach (Medico med in mdb.BuscarMedicos2(""))
            {
                DataRow row = dtmed.NewRow();
                row["med_codigo"] = med.Codigo;
                row["pla_codigo"] = med.Plano.Codigo;
                row["med_nome"] = med.Nome;
                row["med_crm"] = med.Crm;
                row["med_fone"] = med.Fone;
                row["med_celular"] = med.Celular;
                dtmed.Rows.Add(row);
            }

            return dtmed;
        }

        public DataTable BuscaMedicos(int paciente)
        {
            DataTable dtmed = new DataTable();
            Paciente pac = new Paciente();
            PacienteBD pdb = new PacienteBD(bco);
            bco.Conecta();
            pac = (Paciente)pdb.PesquisarPaciente2(paciente);

            dtmed.Columns.Add("med_codigo",typeof (int));
            dtmed.Columns.Add("pla_codigo");
            dtmed.Columns.Add("med_nome");
            dtmed.Columns.Add("med_crm");
            dtmed.Columns.Add("med_fone");
            dtmed.Columns.Add("med_celular");
            
            MedicoBD mdb = new MedicoBD(bco);
            foreach (Medico med in mdb.BuscarMedicos("",pac.Plano.Codigo))
            {
                DataRow row = dtmed.NewRow();
                row["med_codigo"] = med.Codigo;
                row["pla_codigo"] = med.Plano.Codigo;
                row["med_nome"] = med.Nome;
                row["med_crm"] = med.Crm;
                row["med_fone"] = med.Fone;
                row["med_celular"] = med.Celular;
                dtmed.Rows.Add(row);
            }

            return dtmed;
        }

        public DataTable BuscaPacientes()
        {
            DataTable dtpac = new DataTable();
            dtpac.Columns.Add("pac_codigo", typeof(int));
            dtpac.Columns.Add("pac_nome");
            dtpac.Columns.Add("pac_sexo");
            dtpac.Columns.Add("pac_dtnasc");
            dtpac.Columns.Add("pac_endereco");
            dtpac.Columns.Add("pac_cidade");
            dtpac.Columns.Add("pac_uf");
            dtpac.Columns.Add("pac_cep");
            dtpac.Columns.Add("pac_fone");
            dtpac.Columns.Add("pla_nome");
            bco.Conecta();
            PacienteBD pbd = new PacienteBD(bco);
            foreach (Paciente pac in pbd.PesquisarPaciente(""))
            {
                DataRow row = dtpac.NewRow();
                row["pac_codigo"] = pac.Codigo;
                row["pac_nome"] = pac.Nome;
                row["pac_sexo"] = pac.Sexo;
                row["pac_dtnasc"] = pac.Dtnasc;
                row["pac_endereco"] = pac.Endereco;
                row["pac_cidade"] = pac.Cidade;
                row["pac_uf"] = pac.Uf;
                row["pac_cep"] = pac.Cep;
                row["pac_fone"] = pac.Fone;
                row["pla_nome"] = pac.Plano.Desc;
                dtpac.Rows.Add(row);
            }
            bco.Desconecta();

            return dtpac;
        }

        public void AddConta(DataRow row)
        {
            ProcedimentoDB pdb = new ProcedimentoDB(bco);
            Conta c = new Conta();
            bco.Conecta();
            c.Data = Convert.ToDateTime(row["con_data"]);
            c.Procedimento = pdb.BuscaProcedimentos(Convert.ToInt32(row["pro_codigo"]));
            bco.Desconecta();
            c.Qtde = Convert.ToInt32(row["con_qtde"]);
            c.Valorconta = Convert.ToDouble(row["pro_valor"]);
            atendimentoAtual.Conta.Add(c);
        }

        public DataTable BuscarProcedimentos()
        {
            DataTable dtprocs = new DataTable();
            dtprocs.Columns.Add("pro_codigo",typeof(int));
            dtprocs.Columns.Add("pro_descricao");
            dtprocs.Columns.Add("pro_valor");
            bco.Conecta();
            ProcedimentoDB pdb = new ProcedimentoDB(bco);
            foreach  (Procedimento proc in pdb.BuscaProcedimentos(""))
            {
                DataRow row = dtprocs.NewRow();
                row["pro_codigo"] = proc.Codigo;
                row["pro_descricao"] = proc.Descricao;
                row["pro_valor"] = proc.Valor;
                dtprocs.Rows.Add(row);
            }
            bco.Desconecta();
            return dtprocs;
        }

        public DataTable BuscaAtendimentosPNomeData(string nome, DateTime d1, DateTime d2,char ob)
        {
            DataTable dtatendimentos = new DataTable();

            bco.Conecta();
            AtendimentoBD adb = new AtendimentoBD(bco);
            dtatendimentos = adb.BuscaAtendNomeData(nome, d1, d2,ob);

            bco.Desconecta();
            return dtatendimentos;
        }

        public bool ExcluiAtendimento(int codigo)
        {
            bool result;
            bco.Conecta();
            AtendimentoBD abd = new AtendimentoBD(bco);
            result = abd.DeleteAtendimento(codigo);    
            bco.Desconecta();

            return result;
        }

        public DataTable BuscaAtendimentosPNomeDataMed(string nome, DateTime d1,DateTime d2,int codigomed,char ob)
        {
            DataTable dtatendimentos = new DataTable();

            bco.Conecta();
            AtendimentoBD adb = new AtendimentoBD(bco);
            dtatendimentos = adb.BuscaAtendNomeDataMed(nome, d1, d2, codigomed, ob);

            bco.Desconecta();
            return dtatendimentos;
        }

        public DataTable BuscarContas(int atncodigo)
        {
            DataTable dtc = new DataTable();
            dtc.Columns.Add("pro_codigo");
            dtc.Columns.Add("con_qtde");
            dtc.Columns.Add("con_data");
            dtc.Columns.Add("pro_descricao");
            dtc.Columns.Add("pro_valor");
            dtc.Columns.Add("pro_total");
            bco.Conecta();
            ContaDB cdb = new ContaDB(bco);
            foreach (Conta conta in cdb.BuscaContas(atncodigo))
            {
                DataRow row = dtc.NewRow();
                row["pro_codigo"] = conta.Procedimento.Codigo;
                row["con_qtde"] = conta.Qtde;
                row["con_data"] = conta.Data;
                row["pro_descricao"] = conta.Procedimento.Descricao;
                row["pro_valor"] = conta.Valorconta;
                row["pro_total"] = conta.Qtde * conta.Valorconta;
                dtc.Rows.Add(row);
            }
            bco.Desconecta();
            return dtc;
        }

        public void RemoveConta(DataRow row)
        {
            Conta c = new Conta();
            bool b = true;
            for (int i = 0; i < atendimentoAtual.Conta.Count && b; i++)
            {
                c = atendimentoAtual.Conta[i];
                if(c.Data == Convert.ToDateTime(row["con_data"]) && 
                    c.Qtde == (int)row["con_qtde"] && c.Valorconta == (int)row["pro_valor"])
                {
                    atendimentoAtual.Conta.RemoveAt(i);
                    b = false;
                }
            }
        }

        public DataTable BuscaAtendimentosPData(DateTime d1, DateTime d2,char ob)
        {
            DataTable dtatendimentos = new DataTable();

            bco.Conecta();
            AtendimentoBD adb = new AtendimentoBD(bco);
            dtatendimentos = adb.BuscaAtendData(d1, d2, ob);

            bco.Desconecta();
            return dtatendimentos;
        }

        public DataTable BuscaAtendimentosPDataMed(DateTime d1, DateTime d2,int codmed,char ob)
        {
            DataTable dtatendimentos = new DataTable();

            bco.Conecta();
            AtendimentoBD adb = new AtendimentoBD(bco);
            dtatendimentos = adb.BuscaAtendDataMed(d1, d2,ob, codmed);

            bco.Desconecta();
            return dtatendimentos;
        }

        public double BuscaValorConta(int codproc)
        {
            DataTable dtval = new DataTable();
            bco.Conecta();
            ProcedimentoDB pdb = new ProcedimentoDB(bco);
            dtval = pdb.ProcuraValor(codproc);
            bco.Desconecta();
            return Convert.ToDouble(dtval.Rows[0]["pro_valor"]);
        }
    }
}
