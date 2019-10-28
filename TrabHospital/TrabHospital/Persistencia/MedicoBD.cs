using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Persistencia
{
    class MedicoBD
    {
        private Banco bco = null;

        private MedicoBD(Banco bco)
        {
            this.bco = bco;
        }
    }
}
