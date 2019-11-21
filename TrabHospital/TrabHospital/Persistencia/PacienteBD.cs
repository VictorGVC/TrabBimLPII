using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            string SQL = @"INSERT INTO pacientes (pac_nome,pac_sexo,pac_dtnasc,
                                                    pac_endereco,pac_cidade,pac_uf,
                                                    pac_cep,pac_fone,pla_codigo) 
                            VALUES(@nome,@sexo,@nasc,@endereco,@cidade,@uf,@cep,@fone,@plano)";
            if (bco.ExecuteNonQuery(SQL, "@nome", pac.Nome,
                                        "@sexo", pac.Sexo,
                                        "@nasc", pac.Dtnasc,
                                        "@endereco", pac.Endereco,
                                        "@cidade", pac.Cidade,
                                        "@uf", pac.Uf,
                                        "@cep", pac.Cep,
                                        "@fone", pac.Fone,
                                        "@plano",pac.Plano.Codigo))
                return true;
            else
            {
                MessageBox.Show("erro pacientebd");
                return false;
            }
                
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

        public List<object> PesquisarPaciente(string nome)
        {
            List<object> pacientes = new List<object>();
            DataTable dtaux = new DataTable();
            string SQL = @"SELECT * FROM pacientes
                            WHERE pac_nome like @nome";
            nome += "%";
            bco.ExecuteQuery(SQL, out dtaux, "@nome", nome);
            if (dtaux.Rows.Count > 0)
            {
                PlanoDB pdb = new PlanoDB(bco);
                for (int i = 0; i < dtaux.Rows.Count; i++)
                {
                    Paciente p = new Paciente();

                    p.Codigo = Convert.ToInt32(dtaux.Rows[i]["pac_codigo"]);
                    p.Nome = dtaux.Rows[i]["pac_nome"].ToString();
                    p.Sexo = Convert.ToChar(dtaux.Rows[i]["pac_sexo"]);
                    p.Dtnasc = Convert.ToDateTime(dtaux.Rows[i]["pac_dtnasc"]);
                    p.Endereco = dtaux.Rows[i]["pac_endereco"].ToString();
                    p.Cidade = dtaux.Rows[i]["pac_cidade"].ToString();
                    p.Uf = dtaux.Rows[i]["pac_uf"].ToString();
                    p.Cep = dtaux.Rows[i]["pac_cep"].ToString();
                    p.Fone = dtaux.Rows[i]["pac_fone"].ToString();
                    p.Plano = (Planos_de_saude)pdb.BuscarPlanos(Convert.ToInt32(dtaux.Rows[i]["pla_codigo"]));
                    pacientes.Add(p);
                }
            }

            return pacientes;
        }

        public object PesquisarPaciente2(int codigo)
        {
            Paciente p = new Paciente();
            DataTable dtaux = new DataTable();
            string SQL = @"SELECT * FROM pacientes
                            WHERE pac_codigo = @nome";
            bco.ExecuteQuery(SQL, out dtaux, "@nome", codigo);
            if (dtaux.Rows.Count > 0)
            {
                PlanoDB pdb = new PlanoDB(bco);
                p.Codigo = Convert.ToInt32(dtaux.Rows[0]["pac_codigo"]);
                p.Nome = dtaux.Rows[0]["pac_nome"].ToString();
                p.Sexo = Convert.ToChar(dtaux.Rows[0]["pac_sexo"]);
                p.Dtnasc = Convert.ToDateTime(dtaux.Rows[0]["pac_dtnasc"]);
                p.Endereco = dtaux.Rows[0]["pac_endereco"].ToString();
                p.Cidade = dtaux.Rows[0]["pac_cidade"].ToString();
                p.Uf = dtaux.Rows[0]["pac_uf"].ToString();
                p.Cep = dtaux.Rows[0]["pac_cep"].ToString();
                p.Fone = dtaux.Rows[0]["pac_fone"].ToString();
                p.Plano = (Planos_de_saude)pdb.BuscarPlanos(Convert.ToInt32(dtaux.Rows[0]["pla_codigo"]));
            }

            return p;
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
            { 
                return false;
            }
                
        }

		public DataTable BuscarPacienteRel()
		{
			DataTable dtp = new DataTable();

			string SQL = @"SELECT p.pac_nome, p.pac_sexo, p.pac_endereco, p.pac_cidade, p.pac_fone 
							FROM Pacientes AS p 
								INNER JOIN Atendimentos AS a 
									ON p.pac_codigo = a.pac_codigo 
										WHERE (a.atn_dtobito IS NULL) AND (a.atn_dtalta IS NULL) 
											ORDER BY p.pac_nome";

			bco.ExecuteQuery(SQL, out dtp);

			return (dtp);
		}
	}
}
