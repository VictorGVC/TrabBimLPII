using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class ProcedimentoDB
    {
        private Banco banco = null;

        public ProcedimentoDB(Banco banco)
        {
            this.banco = banco;
        }

        public List<object> BuscaProcedimentos(string desc)
        {
            List<object> procs = new List<object>();
            DataTable dtpro = new DataTable();
            string SQL = @"SELECT * FROM procedimentos
                            WHERE pro_descricao LIKE @desc";
            desc += "%";
            banco.ExecuteQuery(SQL, out dtpro, "@desc", desc);
            if(dtpro.Rows.Count > 0)
            {
                for (int i = 0; i < dtpro.Rows.Count; i++)
                {
                    Procedimento proc = new Procedimento();
                    proc.Codigo = Convert.ToInt32(dtpro.Rows[i]["pro_codigo"]);
                    proc.Descricao = dtpro.Rows[i]["pro_descricao"].ToString();
                    proc.Valor = Convert.ToDouble(dtpro.Rows[i]["pro_valor"]);
                    procs.Add(proc);
                }
            }

            return procs;
        }
    }
}
