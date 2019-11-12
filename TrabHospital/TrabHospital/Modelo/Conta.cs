using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
	class Conta
	{
		private int codigo, qtde;
		private DateTime data;
		private float valorconta;
		private Atendimento atendimento;
		private Procedimento procedimento;

		public Conta() { }

		public Conta(int codigo, int qtde, DateTime data, float valorconta, Atendimento atendimento, Procedimento procedimento)
		{
			this.codigo = codigo;
			this.qtde = qtde;
			this.data = data;
			this.valorconta = valorconta;
			this.atendimento = atendimento;
			this.procedimento = procedimento;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public int Qtde { get => qtde; set => qtde = value; }
		public DateTime Data { get => data; set => data = value; }
		public float Valorconta { get => valorconta; set => valorconta = value; }
		internal Atendimento Atendimento { get => atendimento; set => atendimento = value; }
		internal Procedimento Procedimento { get => procedimento; set => procedimento = value; }
	}
}
