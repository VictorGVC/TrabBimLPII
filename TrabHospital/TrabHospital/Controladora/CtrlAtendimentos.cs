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
        private Atendimento AtendimentoAtual = new Atendimento();
        private Paciente Paciente = new Paciente();
        private Medico Medico = new Medico();
    }
}
