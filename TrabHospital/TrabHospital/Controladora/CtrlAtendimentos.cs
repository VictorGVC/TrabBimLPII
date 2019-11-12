using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DataTable BuscaMedicos()
        {
            DataTable dtmed = new DataTable();

            dtmed.Columns.Add("med_codigo",typeof (int));
            dtmed.Columns.Add("pla_codigo");
            dtmed.Columns.Add("med_nome");
            dtmed.Columns.Add("med_crm");
            dtmed.Columns.Add("med_fone");
            dtmed.Columns.Add("med_celular");
            bco.Conecta();
            MedicoBD mdb = new MedicoBD(bco);
            foreach (Medico med in mdb.BuscarMedicos(""))
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

    }
}
