using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;
using TrabHospital.Persistencia;

namespace TrabHospital.Controladora
{
	class CtrlPacientes
	{
		private Banco bco = new Banco();
		private Paciente PacienteAtual = new Paciente();

		public bool GravarPaciente(string nome, char sexo, DateTime dtnasc, string endereco,
								  string cidade, string uf, string cep, string fone)
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

			PacienteBD Pac = new PacienteBD(bco);

			result = Pac.GravarPaciente(PacienteAtual);
			bco.Desconecta();

			return (result);
		}

        public bool ExcluirPaciente(int codigo)
        {
            bco.Conecta();

            PacienteBD Pac = new PacienteBD(bco);

            if (Pac.ApagarPaciente(codigo))
                return true;
            else
                return false;

            bco.Desconecta();
        }

        public bool AlterarPaciente(int cod, string nome, char sexo, DateTime dtnasc, string endereco,
                                  string cidade, string uf, string cep, string fone)
        {


        }
	}
}
