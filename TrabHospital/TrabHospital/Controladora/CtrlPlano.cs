using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;
using TrabHospital.Persistencia;

namespace TrabHospital.Controladora
{
    class CtrlPlano
    {
        private Banco bco = new Banco();
        private Planos_de_saude plano = new Planos_de_saude();

        public DataTable BuscarPlanos(int codigo)
        {
            DataTable dtplano = new DataTable();
            bco.Conecta();
            //escrever o codigo aqui
            return dtplano;

        }
    }
}
