using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class DepositoDB
    {
        Banco banco = null;

        public DepositoDB(Banco banco)
        {
            this.banco = banco;
        }

        public List<object> BuscaDepositos(int atncod)
        {
            DataTable dtdeps = new DataTable();
            List<object> deps = new List<object>();
            string SQL = @"SELECT * FROM Depositos
                            WHERE atn_codigo = @cod";

            banco.ExecuteQuery(SQL, out dtdeps, "@cod", atncod);
            if(dtdeps.Rows.Count>0)
            {
                AtendimentoBD adb = new AtendimentoBD(banco);
                for (int i = 0; i < dtdeps.Rows.Count; i++)
                {
                    Deposito dep = new Deposito();
                    dep.Atendimento = (Atendimento)adb.BuscaAtendimento(atncod);
                    dep.Cheque = dtdeps.Rows[i]["dep_nrcheque"].ToString();
                    dep.Data = Convert.ToDateTime(dtdeps.Rows[i]["dep_data"]);
                    dep.Dtcompensa = Convert.ToDateTime(dtdeps.Rows[i]["dep_dtcompensa"]);
                    dep.Parcela = Convert.ToInt32(dtdeps.Rows[i]["dep_parcela"]);
                    dep.Valor = Convert.ToDouble(dtdeps.Rows[i]["dep_valor"]);
                    deps.Add(dep);
                }
            }
            return deps;
        }

        internal bool SalvarDepositos(DataTable dtdeps)
        {
            bool result;
            string SQL = @"DELETE FROM Depositos
                            WHERE atn_codigo = @cod";

            result = banco.ExecuteNonQuery(SQL, "@cod", Convert.ToInt32(dtdeps.Rows[0]["atn_codigo"]));

            if (result)
            {
                SQL = @"INSERT INTO Depositos (dep_parcela,atn_codigo,dep_data,dep_valor,dep_nrcheque,dep_dtcompensa)
                        VALUES (@parcela,@atend,@data,@valor,@cheque,@dtcomp)";
                try
                {
                    for (int i = 0; i < dtdeps.Rows.Count; i++)
                    {
                        banco.ExecuteNonQuery(SQL, "@parcela", Convert.ToInt32(dtdeps.Rows[i]["dep_parcela"]),
                                                    "@atend", Convert.ToInt32(dtdeps.Rows[i]["atn_codigo"]),
                                                    "@data", Convert.ToDateTime(dtdeps.Rows[i]["dep_data"]),
                                                    "@valor", Convert.ToDouble(dtdeps.Rows[i]["dep_valor"]),
                                                    "cheque", dtdeps.Rows[i]["dep_nrcheque"].ToString(),
                                                    "@dtcomp",Convert.ToDateTime(dtdeps.Rows[i]["dep_dtcompensa"])); 
                    }
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
