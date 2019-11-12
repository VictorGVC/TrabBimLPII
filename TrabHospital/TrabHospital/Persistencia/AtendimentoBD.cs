using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Persistencia
{
    class AtendimentoBD
    {
        private Banco bco = null;

        public AtendimentoBD(Banco bco)
        {
            this.bco = bco;
        }
    }
}
