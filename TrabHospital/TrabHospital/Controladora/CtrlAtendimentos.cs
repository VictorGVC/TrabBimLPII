using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabHospital.Modelo;
using TrabHospital.Persistencia;

namespace TrabHospital.Controladora
{
    class CtrlAtendimentos
    {
        Banco bco = new Banco();
        private Atendimento atendimentoAtual = new Atendimento();
        private Diagnostico diagnostico = new Diagnostico();
        private Medico medico = new Medico();
        private Paciente paciente = new Paciente();
    }
}
