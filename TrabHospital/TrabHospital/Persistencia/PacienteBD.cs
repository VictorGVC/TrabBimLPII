using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
	class PacienteBD
	{
		private Banco bco = null;

		public PacienteBD(Banco bco)
		{
			this.bco = bco;
		}

		public bool GravarPaciente(object Objeto)
		{
            Paciente pac = (Paciente)Objeto;

            string SQL = @"INSERT INTO pacientes (pac_nome,pac_sexo,pac_dtnasc,pac_endereco,pac_cidade,pac_uf,pac_cep,pac_fone,pla_codigo) 
                            VALUES(@nome,@sexo,@nasc,@endereco,@cidade,@uf,@cep,@fone,@plano)";
            if (bco.ExecuteNonQuery(SQL, "@nome", pac.Nome,
                                        "@sexo", pac.Sexo,
                                        "@nasc", pac.Dtnasc,
                                        "@endereco", pac.Endereco,
                                        "@cidade", pac.Cidade,
                                        "@uf", pac.Uf,
                                        "@cep", pac.Cep,
                                        "@cop", pac.Fone,
                                        "@plano",pac.Plano.Codigo))
                return true;
            else
                return false;
		}

        public bool ApagarPaciente(int codigo)
        {
            string SQL = @"DELETE FROM pacientes
                            WHERE pac_codigo = @codigo";

            if (bco.ExecuteNonQuery(SQL, "@codigo", codigo))
                return true;
            else
                return false;
        }

        public bool Alterar(Paciente pac)
        {
            return true;
        }

        public List<object> PesquisarPaciente(string nome)
        {
            List<object> paciente = new List<object>();

            

            return paciente;
        }

        public bool AlterarPaciente(object Objeto)
        {
            Paciente pac = (Paciente)Objeto;

            string SQL = @"UPDATE pacientes SET pla_codigo = @plano, pac_nome = @nome,
                                                pac_sexo = @sexo, pac_dtnasc = @dt,
                                                pac_endereco = @end, pac_cidade = @cidade,
                                                pac_uf = @uf, pac_cep = @cep, pac_fone = @fone
                                            WHERE pac_codigo = @cod
                                                ";
            if (bco.ExecuteNonQuery(SQL, "@plano", pac.Plano.Codigo,
                                        "@nome", pac.Nome,
                                        "@sexo", pac.Sexo,
                                        "@dt", pac.Dtnasc,
                                        "@end", pac.Endereco,
                                        "@cidade", pac.Cidade,
                                        "@uf", pac.Uf,
                                        "@cep", pac.Cep,
                                        "@fone", pac.Fone,
                                        "@cod", pac.Codigo))
                return true;
            else
                return false;
        }

    }
}
