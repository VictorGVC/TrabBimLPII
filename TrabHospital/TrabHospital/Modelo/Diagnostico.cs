using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Modelo
{
    class Diagnostico
    {
        private int codigo;
        private string descricao;

        public Diagnostico() { }

        public Diagnostico(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
