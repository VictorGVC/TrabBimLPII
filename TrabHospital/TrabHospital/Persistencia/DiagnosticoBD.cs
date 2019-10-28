using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Persistencia
{
    class DiagnosticoBD
    {
        private Banco bco = null;

        private DiagnosticoBD(Banco bco)
        {
            this.bco = bco;
        }
    }
}
