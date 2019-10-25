using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class PlanoDB
    {
        private Banco banco = null;

        public PlanoDB(Banco bco)
        {
            this.banco = bco;
        }

        public List<object> BuscarPlanos(string desc)
        {
            List<object> planos = new List<object>();
            DataTable dtaux = new DataTable();
            string SQL = @"SELECT * FROM planosaude
                            WHERE pla_descricao like @desc";
            desc += "%";
            banco.ExecuteQuery(SQL, out dtaux, "@desc", desc);

            if (dtaux.Rows.Count > 0)
            {
                for (int i = 0; i < dtaux.Rows.Count; i++)
                {
                    Planos_de_saude plano = new Planos_de_saude();
                    plano.Codigo = Convert.ToInt32(dtaux.Rows[i]["pla_codigo"]);
                    plano.Desc = dtaux.Rows[i]["pla_descricao"].ToString();
                    planos.Add(plano);
                }
            }

            return planos;
        }

        public object BuscarPlanos(int codigo)
        {
            Planos_de_saude plano = new Planos_de_saude();
            DataTable dtaux = new DataTable();
            string SQL = @"SELECT * FROM planosaude WHERE pla_codigo = @codigo";
            banco.ExecuteQuery(SQL,out dtaux ,"@codigo", codigo);
            if(dtaux.Rows.Count > 0)
            {
                plano.Codigo = Convert.ToInt32(dtaux.Rows[0]["pla_codigo"]);
                plano.Desc = dtaux.Rows[0]["pla_descricao"].ToString();
            }
            return plano;
        }

    }
}
