using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
	class Procedimento
	{
		private int codigo;
		private float valor;
		private String descricao;

		public Procedimento() { }

		public Procedimento(int codigo, float valor, string descricao)
		{
			this.codigo = codigo;
			this.valor = valor;
			this.descricao = descricao;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public float Valor { get => valor; set => valor = value; }
		public string Descricao { get => descricao; set => descricao = value; }
	}
}
