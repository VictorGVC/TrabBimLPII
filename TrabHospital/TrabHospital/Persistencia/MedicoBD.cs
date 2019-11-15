using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class MedicoBD
    {
        private Banco bco = null;

        public MedicoBD(Banco bco)
        {
            this.bco = bco;
        }

        public List<object> BuscarMedicos(string desc,int plano)
        {
            List<object> meds = new List<object>();
            DataTable dtmed = new DataTable();
            
            string SQL = @"SELECT * FROM Medicos
                            WHERE med_nome LIKE @desc
                            AND pla_codigo = @plano";
            desc += "%";
            bco.ExecuteQuery(SQL, out dtmed, "@desc",desc,"@plano",plano);
            if(dtmed.Rows.Count>0)
            {
                PlanoDB pdb = new PlanoDB(bco);
                for (int i = 0; i < dtmed.Rows.Count; i++)
                {
                    Medico med = new Medico();
                    med.Codigo = Convert.ToInt32(dtmed.Rows[i]["med_codigo"]);
                    med.Celular = dtmed.Rows[i]["med_celular"].ToString();
                    med.Crm = dtmed.Rows[i]["med_crm"].ToString();
                    med.Nome = dtmed.Rows[i]["med_nome"].ToString();
                    med.Plano = (Planos_de_saude)pdb.BuscarPlanos(Convert.ToInt32(dtmed.Rows[i]["pla_codigo"]));
                    med.Fone = dtmed.Rows[i]["med_fone"].ToString();
                    meds.Add(med);
                }
            }

            return meds;
        }

        public object BuscarMedico(int codigo)
        {
            DataTable dtmed = new DataTable();
            Medico med = new Medico();

            string SQL = @"SELECT * FROM Medicos
                            AND med_codigo = @cod";
            bco.ExecuteQuery(SQL, out dtmed, "@cod", codigo);
            if (dtmed.Rows.Count > 0)
            {
                PlanoDB pdb = new PlanoDB(bco);
                    
                med.Codigo = Convert.ToInt32(dtmed.Rows[0]["med_codigo"]);
                med.Celular = dtmed.Rows[0]["med_celular"].ToString();
                med.Crm = dtmed.Rows[0]["med_crm"].ToString();
                med.Nome = dtmed.Rows[0]["med_nome"].ToString();
                med.Plano = (Planos_de_saude)pdb.BuscarPlanos(Convert.ToInt32(dtmed.Rows[0]["pla_codigo"]));
                med.Fone = dtmed.Rows[0]["med_fone"].ToString();
            }

            return med;
        }
    }
}
