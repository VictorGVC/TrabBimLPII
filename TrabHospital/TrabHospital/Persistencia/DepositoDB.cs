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
    }
}
