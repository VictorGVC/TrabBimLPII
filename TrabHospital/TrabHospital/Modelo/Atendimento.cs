using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
    class Atendimento
    {
		private int codigo;
		private DateTime data, dtretorno, dtalta, dtobito;
		private String anamnase, causamortis;
		private char contafechada;
		private double valorconta, valordesc;
		private Diagnostico diagnostico;
		private Medico medico;
		private Paciente paciente;
        private List<Conta> conta;

		public Atendimento() 
        {
            conta = new List<Conta>();
        }

		public Atendimento(int codigo, DateTime data, DateTime dtretorno, DateTime dtalta, DateTime dtobito, 
            string anamnase, string causamortis, char contafechada, double valorconta, double valordesc, 
            Diagnostico diagnostico, Medico medico, Paciente paciente, List<Conta>conta)
		{
			this.codigo = codigo;
			this.data = data;
			this.dtretorno = dtretorno;
			this.dtalta = dtalta;
			this.dtobito = dtobito;
			this.anamnase = anamnase;
			this.causamortis = causamortis;
			this.contafechada = contafechada;
			this.valorconta = valorconta;
			this.valordesc = valordesc;
			this.diagnostico = diagnostico;
			this.medico = medico;
			this.paciente = paciente;
            this.conta = conta;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public DateTime Data { get => data; set => data = value; }
		public DateTime Dtretorno { get => dtretorno; set => dtretorno = value; }
		public DateTime Dtalta { get => dtalta; set => dtalta = value; }
		public DateTime Dtobito { get => dtobito; set => dtobito = value; }
		public string Anamnase { get => anamnase; set => anamnase = value; }
		public string Causamortis { get => causamortis; set => causamortis = value; }
		public char Contafechada { get => contafechada; set => contafechada = value; }
		public double Valorconta { get => valorconta; set => valorconta = value; }
		public double Valordesc { get => valordesc; set => valordesc = value; }
		internal Diagnostico Diagnostico { get => diagnostico; set => diagnostico = value; }
		internal Medico Medico { get => medico; set => medico = value; }
		internal Paciente Paciente { get => paciente; set => paciente = value; }
        internal List<Conta> Conta { get => conta; set => conta = value; }
    }
}
