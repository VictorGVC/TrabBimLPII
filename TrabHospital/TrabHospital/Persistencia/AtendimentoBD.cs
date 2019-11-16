using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Persistencia
{
    class AtendimentoBD
    {
        private Banco bco = null;

        public AtendimentoBD(Banco bco)
        {
            this.bco = bco;
        }

        public bool SalvarAtendimento(Atendimento at)
        {
            bool result;

            string SQL = @"INSERT INTO Atendimentos(dia_codigo,med_codigo,pac_codigo,atn_data,atn_anamnese
                            ,atn_contafechada,atn_vrconta) VALUES (@diag,@med,@pac,@data,@anam,'N',@valor)";

            result = bco.ExecuteNonQuery(SQL, "@diag", at.Diagnostico.Codigo,
                                    "@med", at.Medico.Codigo, "@pac", at.Paciente.Codigo,
                                    "@data", at.Data,"@anam",at.Anamnase,"@valor",at.Valorconta);

            if(result)
            {
                int codgigo = bco.GetIdentity();
                
                SQL = @"INSERT INTO contas (pro_codigo,atn_codigo,con_qtde,con_data,con_vrconta)
                                            VALUES (@proc,@aten,@qtde,@data,@valor)";
                foreach (Conta conta in at.Conta)
                {
                    bco.ExecuteNonQuery(SQL, "@proc", conta.Procedimento.Codigo,
                                            "@aten", conta.Atendimento.Codigo,
                                            "@qtde", conta.Qtde,"@data",conta.Data,
                                            "@valor", conta.Valorconta) ;
                }
                
            }

            return result;
        }
    }
}
