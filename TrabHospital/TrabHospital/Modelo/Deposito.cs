using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
	class Deposito
	{
		private int parcela;
		private DateTime data, dtcompensa;
		private double valor;
		private String cheque;
		private char tipo;
		private Atendimento atendimento;

		public Deposito() { }

		public Deposito(int parcela, DateTime data, DateTime dtcompensa, double valor, string cheque, char tipo, Atendimento atendimento)
		{
			this.parcela = parcela;
			this.data = data;
			this.dtcompensa = dtcompensa;
			this.valor = valor;
			this.cheque = cheque;
			this.tipo = tipo;
			this.atendimento = atendimento;
		}

		public int Parcela { get => parcela; set => parcela = value; }
		public DateTime Data { get => data; set => data = value; }
		public DateTime Dtcompensa { get => dtcompensa; set => dtcompensa = value; }
		public double Valor { get => valor; set => valor = value; }
		public string Cheque { get => cheque; set => cheque = value; }
		public char Tipo { get => tipo; set => tipo = value; }
		internal Atendimento Atendimento { get => atendimento; set => atendimento = value; }
	}
}
