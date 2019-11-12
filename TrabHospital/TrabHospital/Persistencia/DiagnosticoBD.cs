using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class DiagnosticoBD
    {
        private Banco banco = null;

        public DiagnosticoBD(Banco bco)
        {
            this.banco = bco;
        }

        public List<object> BuscarDiagnosticos(string desc)
        {
            List<object> diags = new List<object>();
            DataTable dtdiags = new DataTable();

            string SQL = @"SELECT * FROM diagnosticos 
                            WHERE dia_descricao LIKE @desc";
            desc += "%";
            banco.ExecuteQuery(SQL, out dtdiags, "@desc", desc);

            if(dtdiags.Rows.Count>0)
            {
                for (int i = 0; i < dtdiags.Rows.Count; i++)
                {
                    Diagnostico diag = new Diagnostico();
                    diag.Codigo = Convert.ToInt32(dtdiags.Rows[i]["dia_codigo"]);
                    diag.Descricao = dtdiags.Rows[i]["dia_descricao"].ToString();
                    diags.Add(diag);
                }
            }

            return diags;
        }
    }
}
