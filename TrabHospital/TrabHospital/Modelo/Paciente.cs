﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;

namespace TrabHospital.Modelo
{
	class Paciente
	{
		private int codigo;
		private String nome, endereco, cidade, uf, cep, fone;
		private char sexo;
		private DateTime dtnasc;
        private Planos_de_saude plano;

		public Paciente() { }

		public Paciente(int codigo, string nome, string endereco, string cidade, string uf, string cep, string fone, char sexo, DateTime dtnasc,Planos_de_saude plano)
		{
			this.Codigo = codigo;
			this.Nome = nome;
			this.Endereco = endereco;
			this.Cidade = cidade;
			this.Uf = uf;
			this.Cep = cep;
			this.Fone = fone;
			this.Sexo = sexo;
			this.Dtnasc = dtnasc;
            this.plano = plano;
		}

		public int Codigo { get => codigo; set => codigo = value; }
		public string Nome { get => nome; set => nome = value; }
		public string Endereco { get => endereco; set => endereco = value; }
		public string Cidade { get => cidade; set => cidade = value; }
		public string Uf { get => uf; set => uf = value; }
		public string Cep { get => cep; set => cep = value; }
		public string Fone { get => fone; set => fone = value; }
		public char Sexo { get => sexo; set => sexo = value; }
		public DateTime Dtnasc { get => dtnasc; set => dtnasc = value; }
        internal Planos_de_saude Plano { get => plano; set => plano = value; }
    }
}
