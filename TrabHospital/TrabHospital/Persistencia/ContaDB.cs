using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class ContaDB
    {
        Banco banco = null;

        public ContaDB(Banco banco)
        {
            this.banco = banco;
        }

        public List<object> BuscaContas(int codigoatn)
        {
            List<object> contas = new List<object>();
            DataTable dtconta = new DataTable();
            string SQL = @"SELECT * FROM Contas
                            WHERE atn_codigo = @cod";
            banco.ExecuteQuery(SQL,out dtconta,"@cod",codigoatn);

            if(dtconta.Rows.Count>0)
            {
                ProcedimentoDB pdb = new ProcedimentoDB(banco);
                AtendimentoBD adb = new AtendimentoBD(banco);
                for (int i = 0; i < dtconta.Rows.Count; i++)
                {
                    Conta c = new Conta();
                    c.Procedimento = pdb.BuscaProcedimentos((int)dtconta.Rows[i]["pro_codigo"]);
                    c.Atendimento = new Atendimento();
                    c.Atendimento.Codigo = codigoatn;
                    c.Data = Convert.ToDateTime(dtconta.Rows[i]["con_data"]);
                    c.Qtde = Convert.ToInt32(dtconta.Rows[i]["con_qtde"]);
                    c.Valorconta = Convert.ToDouble(dtconta.Rows[i]["con_vrconta"]);
                    contas.Add(c);
                }
            }

            return contas;
        }
    }
}
