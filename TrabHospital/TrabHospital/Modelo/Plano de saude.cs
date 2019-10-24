using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{

    class Planos_de_saude
    {
        private int codigo;
        private string desc;

        public Planos_de_saude() { }

        public Planos_de_saude(int codigo, string desc)
        {
            this.codigo = codigo;
            this.desc = desc;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
