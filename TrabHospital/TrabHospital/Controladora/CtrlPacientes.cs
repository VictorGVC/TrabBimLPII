using Microsoft.Reporting.WinForms;
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
	class CtrlPacientes
	{
		Banco bco = new Banco();
		private Paciente PacienteAtual = new Paciente();
        private Planos_de_saude plano = new Planos_de_saude();

        public bool GravarPaciente(string nome, char sexo, DateTime dtnasc, string endereco,
								  string cidade, string uf, string cep, string fone,int codplano)
		{
			bool result = true;

			bco.Conecta();
			PacienteAtual.Nome = nome;
			PacienteAtual.Sexo = sexo;
			PacienteAtual.Dtnasc = dtnasc;
			PacienteAtual.Endereco = endereco;
			PacienteAtual.Cidade = cidade;
			PacienteAtual.Uf = uf;
			PacienteAtual.Cep = cep;
			PacienteAtual.Fone = fone;
            PlanoDB pbd = new PlanoDB(bco);
            PacienteAtual.Plano = (Planos_de_saude)pbd.BuscarPlanos(codplano);

            PacienteBD Pac = new PacienteBD(bco);

			result = Pac.GravarPaciente(PacienteAtual);
            if (!result)
                MessageBox.Show("erro control");
			bco.Desconecta();

			return (result);
		}

        public bool ExcluirPaciente(int codigo)
        {
            bool tr = false;
            bco.Conecta();
            PacienteBD Pac = new PacienteBD(bco);
            if (Pac.ApagarPaciente(codigo))
                tr = true;
            bco.Desconecta();

            return tr;
        }

        public bool AlterarPaciente(int cod, string nome, char sexo, DateTime dtnasc, string endereco,
                                  string cidade, string uf, string cep, string fone,int codplano)
        {
            bool result = true;

            bco.Conecta();
            PacienteAtual.Nome = nome;
            PacienteAtual.Sexo = sexo;
            PacienteAtual.Codigo = cod;
            PacienteAtual.Dtnasc = dtnasc;
            PacienteAtual.Endereco = endereco;
            PacienteAtual.Cidade = cidade;
            PacienteAtual.Uf = uf;
            PacienteAtual.Cep = cep;
            PacienteAtual.Fone = fone;
            PlanoDB pbd = new PlanoDB(bco);
            PacienteAtual.Plano = (Planos_de_saude)pbd.BuscarPlanos(codplano);

            PacienteBD Pac = new PacienteBD(bco);

            result = Pac.AlterarPaciente(PacienteAtual);
            if (!result)
                MessageBox.Show("erro control");
            bco.Desconecta();

            return (result);

        }

        public DataTable BuscarPlanos()
        {
            DataTable dtplano = new DataTable();
            dtplano.Columns.Add("pla_codigo", typeof(int));
            dtplano.Columns.Add("pla_descricao");
            bco.Conecta();
            PlanoDB plabd = new PlanoDB(bco);
            foreach(Planos_de_saude pla in plabd.BuscarPlanos(""))
            {
                DataRow row = dtplano.NewRow();
                row["pla_codigo"] = pla.Codigo;
                row["pla_descricao"] = pla.Desc;
                dtplano.Rows.Add(row);
            }
            bco.Desconecta();

            return (dtplano);
        }

        public DataTable BuscarPaciente(string desc)
        {
            DataTable dtpac = new DataTable();
            dtpac.Columns.Add("pac_codigo",typeof(int));
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
            foreach(Paciente pac in pbd.PesquisarPaciente(desc))
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

		public bool ProcessaRelatorio(string caminhoRelatorio, DataTable dtDados, ReportViewer visualizador,
									  string nomeDataSet, ReportParameter[] parametros)
		{
			bool resultado = false;
			try
			{
				visualizador.Reset();
				visualizador.LocalReport.DataSources.Clear();
				ReportDataSource RDS = new ReportDataSource(nomeDataSet, dtDados);
				visualizador.LocalReport.DataSources.Add(RDS);
				visualizador.LocalReport.ReportPath = caminhoRelatorio;
				if (parametros != null)
				{
					visualizador.LocalReport.SetParameters(parametros);
				}
				visualizador.RefreshReport();
				resultado = true;
			}
			catch (Exception e)
			{
				Console.Out.WriteLine("Erro na conexão" + e.Message);
				return (false);
			}
			return (resultado);
		}
	}
}
