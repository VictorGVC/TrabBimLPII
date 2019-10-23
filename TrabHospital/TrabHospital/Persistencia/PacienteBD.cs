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

		public bool Gravar(object Objeto)
		{
            Paciente pac = (Paciente)Objeto;

            string SQL = @"INSERT INTO pacientes (pac_nome,pac_sexo,pac_dtnasc,pac_endereco,pac_cidade,pac_uf,pac_cep,pac_fone) 
                            VALUES(@nome,@sexo,@nasc,@endereco,@cidade,@uf,@cep,@fone)";
            if (bco.ExecuteNonQuery(SQL, "@nome", pac.Nome,
                                        "@sexo", pac.Sexo,
                                        "@nasc", pac.Dtnasc,
                                        "@endereco", pac.Endereco,
                                        "@cidade", pac.Cidade,
                                        "@uf", pac.Uf,
                                        "@cep", pac.Cep,
                                        "@cop", pac.Fone))
                return true;
            else
                return false;
		}

        public bool Apagar(int codigo)
        {
            string SQL = @"DELETE FROM pacientes
                            WHERE pac_codigo = @codigo";

            if (bco.ExecuteNonQuery(SQL, "@codigo", codigo))
                return true;
            else
                return false;
        }
	}
}
