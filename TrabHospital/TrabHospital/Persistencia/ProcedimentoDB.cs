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

        internal Procedimento BuscaProcedimentos(int codigo)
        {
            Procedimento proc = new Procedimento();
            DataTable dtpro = new DataTable();
            string SQL = @"SELECT * FROM procedimentos
                            WHERE pro_codigo = @cod";
            banco.ExecuteQuery(SQL, out dtpro, "@cod", codigo);
            if (dtpro.Rows.Count > 0)
            {
                proc.Codigo = Convert.ToInt32(dtpro.Rows[0]["pro_codigo"]);
                proc.Descricao = dtpro.Rows[0]["pro_descricao"].ToString();
                proc.Valor = Convert.ToDouble(dtpro.Rows[0]["pro_valor"]);
            }

            return proc;
        }

        public DataTable ProcuraValor(int codproc)
        {
            DataTable dtval = new DataTable();
            string SQL = @"SELECT pro_valor FROM Procedimentos
                            WHERE pro_codigo = @cod";
            banco.ExecuteQuery(SQL, out dtval, "@cod", codproc);
            return dtval;
        }
    }
}
