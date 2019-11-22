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
                int codigo = bco.GetIdentity();
                
                SQL = @"INSERT INTO contas (pro_codigo,atn_codigo,con_qtde,con_data,con_vrconta)
                                            VALUES (@proc,@aten,@qtde,@data,@valor)";
                foreach (Conta conta in at.Conta)
                {
                    bco.ExecuteNonQuery(SQL, "@proc", conta.Procedimento.Codigo,
                                            "@aten", codigo,
                                            "@qtde", conta.Qtde,"@data",conta.Data,
                                            "@valor", conta.Valorconta) ;
                }
                
            }

            return result;
        }

        public object BuscaAtendimento(int atncod)
        {
            Atendimento atn = new Atendimento();
            DataTable dtatn = new DataTable();
            string SQL = @"SELECT * FROM Atendimentos
                            WHERE atn_codigo = @cod";
            bco.ExecuteQuery(SQL, out dtatn, "@cod", atncod);
            if(dtatn.Rows.Count>0)
            {
                atn.Codigo = atncod;
                atn.Anamnase = dtatn.Rows[0]["atn_anamnese"].ToString();
                atn.Valorconta = Convert.ToDouble(dtatn.Rows[0]["atn_vrconta"]);
            }
            return atn;
        }

        public DataTable BuscaAtendNomeData(string nome, DateTime d1, DateTime d2,char ob)
        {
            DataTable dta = new DataTable();
            string SQL;
            if(ob == 'o')
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo AND pac.pac_nome LIKE @nome
                                INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo 
                                    WHERE atn_dtobito >= @d1 AND atn_dtobito <= @d2";
            }
            else
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo AND pac.pac_nome LIKE @nome
                                INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo 
                                    WHERE atn_data >= @d1 AND atn_data <= @d2";
            }
            nome += "%";

            try
            {
                bco.ExecuteQuery(SQL, out dta,"@d1", d1, "@d2", d2, "@nome", nome);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            return dta;
        }

        public bool AlterarAtendimentoCMorte(Atendimento at)
        {
            bool result;

            string SQL = @"UPDATE Atendimentos SET dia_codigo = @diag, med_codigo = @med,pac_codigo = @pac,
                            atn_data = @dtatn, atn_anamnese = @anam, atn_causamortis = @cmorte
                            , atn_vrconta = @valor, atn_dtobito = @dtobito, atn_contafechada = 'N'
                                WHERE atn_codigo = @cod";

            result = bco.ExecuteNonQuery(SQL, "@diag", at.Diagnostico.Codigo,
                                    "@med", at.Medico.Codigo, "@pac", at.Paciente.Codigo,
                                    "@dtatn", at.Data, "@anam", at.Anamnase, "@valor", at.Valorconta,
                                    "@cmorte",at.Causamortis,"@dtobito",at.Dtobito,"@cod",at.Codigo);

            if (result)
            {
                SQL = @"DELETE FROM Contas
                        WHERE atn_codigo = @cod";
                result = bco.ExecuteNonQuery(SQL, "@cod", at.Codigo);
                if (result)
                {
                    SQL = @"INSERT INTO contas (pro_codigo,atn_codigo,con_qtde,con_data,con_vrconta)
                                            VALUES (@proc,@aten,@qtde,@data,@valor)";
                    foreach (Conta conta in at.Conta)
                    {
                        bco.ExecuteNonQuery(SQL, "@proc", conta.Procedimento.Codigo,
                                                "@aten", at.Codigo,
                                                "@qtde", conta.Qtde, "@data", conta.Data,
                                                "@valor", conta.Valorconta);
                    }
                }
                else
                    MessageBox.Show("ERRO NO SQL DELETE");

            }
            else
                MessageBox.Show("ERRO NO SQL UPDATE");

            return result;
        }

        public bool AlterarAtendimentoCAlta(Atendimento at)
        {
            bool result;

            string SQL = @"UPDATE Atendimentos SET dia_codigo = @diag, med_codigo = @med,pac_codigo = @pac,
                            atn_data = @dtatn, atn_anamnese = @anam, atn_dtretorno = @dtretorno
                            , atn_vrconta = @valor, atn_dtalta = @dtalta, atn_contafechada = 'N'
                                WHERE atn_codigo = @cod";

            result = bco.ExecuteNonQuery(SQL, "@diag", at.Diagnostico.Codigo,
                                    "@med", at.Medico.Codigo, "@pac", at.Paciente.Codigo,
                                    "@dtatn", at.Data, "@anam", at.Anamnase, "@valor", at.Valorconta,
                                    "@dtalta", at.Dtalta, "@dtretorno", at.Dtretorno, "@cod", at.Codigo);

            if (result)
            {
                SQL = @"DELETE FROM Contas
                        WHERE atn_codigo = @cod";
                result = bco.ExecuteNonQuery(SQL, "@cod", at.Codigo);
                if (result)
                {
                    SQL = @"INSERT INTO contas (pro_codigo,atn_codigo,con_qtde,con_data,con_vrconta)
                                            VALUES (@proc,@aten,@qtde,@data,@valor)";
                    foreach (Conta conta in at.Conta)
                    {
                        bco.ExecuteNonQuery(SQL, "@proc", conta.Procedimento.Codigo,
                                                "@aten", at.Codigo,
                                                "@qtde", conta.Qtde, "@data", conta.Data,
                                                "@valor", conta.Valorconta);
                    }
                }
                else
                    MessageBox.Show("ERRO NO SQL DELETE");

            }
            else
                MessageBox.Show("ERRO NO SQL UPDATE");

            return result;
        }

        internal bool AlterarAtendimento(Atendimento at)
        {
            bool result;

            string SQL = @"UPDATE Atendimentos SET dia_codigo = @diag, med_codigo = @med,pac_codigo = @pac,
                            atn_data = @dtatn, atn_anamnese = @anam, atn_vrconta = @valor, atn_contafechada = 'N'
                                WHERE atn_codigo = @cod";

            result = bco.ExecuteNonQuery(SQL, "@diag", at.Diagnostico.Codigo,
                                    "@med", at.Medico.Codigo, "@pac", at.Paciente.Codigo,
                                    "@dtatn", at.Data, "@anam", at.Anamnase, "@valor", at.Valorconta,
                                    "@cod", at.Codigo);

            if (result)
            {
                SQL = @"DELETE FROM Contas
                        WHERE atn_codigo = @cod";
                result = bco.ExecuteNonQuery(SQL, "@cod", at.Codigo);
                if (result)
                {
                    SQL = @"INSERT INTO contas (pro_codigo,atn_codigo,con_qtde,con_data,con_vrconta)
                                            VALUES (@proc,@aten,@qtde,@data,@valor)";
                    foreach (Conta conta in at.Conta)
                    {
                        bco.ExecuteNonQuery(SQL, "@proc", conta.Procedimento.Codigo,
                                                "@aten", at.Codigo,
                                                "@qtde", conta.Qtde, "@data", conta.Data,
                                                "@valor", conta.Valorconta);
                    }
                }
                else
                    MessageBox.Show("ERRO NO SQL DELETE");

            }
            else
                MessageBox.Show("ERRO NO SQL UPDATE");

            return result;
        }

        public DataTable BuscaAtendNomeDataMed(string nome, DateTime d1, DateTime d2, int codigomed, char ob)
        {
            DataTable dta = new DataTable();
            string SQL;
            if (ob == 'o')
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo AND pac.pac_nome = @nome 
                                    WHERE atn_dtobito >= @d1 AND atn_dtobito <= @d2 AND atn.med_codigo = @med";
            }
            else
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo
                                INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo AND  pac.pac_nome = @nome
                                    WHERE atn_data >= @d1 AND atn_data <= @d2 AND atn.med_codigo = @med";
            }
            nome += "%";

            try
            {
                bco.ExecuteQuery(SQL, out dta, "@d1", d1, "@d2", d2, "@nome", nome,"@med",codigomed);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return dta;
        }

        public DataTable BuscaAtendData(DateTime d1, DateTime d2, char ob)
        {
            DataTable dta = new DataTable();
            string SQL;
            if (ob == 'o')
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo
                                    WHERE atn_dtobito >= @d1 AND atn_dtobito <= @d2";
            }
            else
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo
                                INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo 
                                    WHERE atn_data >= @d1 AND atn_data <= @d2";
            }

            try
            {
                bco.ExecuteQuery(SQL, out dta, "@d1", d1, "@d2", d2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return dta;
        }

        public bool DeleteAtendimento(int codigo)
        {
            string SQL = @"DELETE FROM contas
                            WHERE atn_codigo = @cod";
                
            if(bco.ExecuteNonQuery(SQL, "@cod", codigo))
            {
                SQL = @"DELETE FROM Atendimentos
                       WHERE atn_codigo = @cod";
                if (bco.ExecuteNonQuery(SQL, "@cod", codigo))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public DataTable BuscaAtendDataMed(DateTime d1, DateTime d2, char ob,int codmed)
        {
            DataTable dta = new DataTable();
            string SQL;
            if (ob == 'o')
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo
                                    WHERE atn_dtobito >= @d1 AND atn_dtobito <= @d2 AND atn.med_codigo = @med";
            }
            else
            {
                SQL = @"SELECT atn.atn_codigo,dia.dia_codigo,med.med_codigo,pac.pac_codigo,atn.atn_data,atn.atn_anamnese,
                                atn.atn_dtretorno,atn.atn_dtalta,atn.atn_contafechada,atn.atn_causamortis,atn.atn_vrconta,
                                atn.atn_dtobito,atn.atn_vrdesconto,pac.pac_nome,med.med_nome,dia.dia_descricao
                                FROM Atendimentos as atn INNER JOIN Diagnosticos as dia
                                ON atn.dia_codigo = dia.dia_codigo INNER JOIN Pacientes as pac
                                ON pac.pac_codigo = atn.pac_codigo
                                INNER JOIN Medicos as med
                                ON med.med_codigo = atn.med_codigo
                                    WHERE atn_data >= @d1 AND atn_data <= @d2 AND atn.med_codigo = @med";
            }

            try
            {
                bco.ExecuteQuery(SQL, out dta, "@d1", d1, "@d2", d2, "@med", codmed);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return dta;
        }

		public DataTable BuscarAtendimentoRel()
		{
			DataTable dtp = new DataTable();

			string SQL = @"SELECT  * FROM Contas 
							INNER JOIN Atendimentos 
								ON Contas.atn_codigo = Atendimentos.atn_codigo";

			bco.ExecuteQuery(SQL, out dtp);

			return (dtp);
		}

		public void FechaAtendimento(int atncod)
        {
            string SQL = @"UPDATE Atendimentos SET atn_contafechada = 'S'
                            WHERE atn_codigo = @cod";

            bco.ExecuteNonQuery(SQL, "@cod", atncod);
        }
    }
}
