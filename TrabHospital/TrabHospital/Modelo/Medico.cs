using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
    class Medico
    {
        private int codigo;
        private Planos_de_saude plano;
        private string nome, crm, fone, celular;

        public Medico() { }

        public Medico(int codigo, Planos_de_saude plano, string nome, string crm, string fone, string celular)
        {
            this.codigo = codigo;
            this.plano = plano;
            this.nome = nome;
            this.crm = crm;
            this.fone = fone;
            this.celular = celular;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Crm { get => crm; set => crm = value; }
        public string Fone { get => fone; set => fone = value; }
        public string Celular { get => celular; set => celular = value; }
        internal Planos_de_saude Plano { get => plano; set => plano = value; }
    }
}
