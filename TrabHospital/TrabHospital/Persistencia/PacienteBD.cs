using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabHospital.Persistencia
{
	class PacienteBD
	{
		private Banco bco = null;

		public PacienteBD(Banco bco)
		{
			this.bco = bco;
		}

		public bool Gravar(object Objeto)
		{
			bool res = false;

			//Fazer Gravar

			return (res);
		}
	}
}
