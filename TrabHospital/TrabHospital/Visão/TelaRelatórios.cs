using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabHospital.Controladora;

namespace TrabHospital.Visão
{
	public partial class TelaRelatórios : Form
	{
		private CtrlPacientes ControlPac = new CtrlPacientes();

		public TelaRelatórios(int index)
		{
			InitializeComponent();
			tabs.SelectedIndex = index;
		}

		private void TelaRelatórios_Load(object sender, EventArgs e)
		{
			this.reportViewer1.RefreshReport();
			DataTable dtDados = ControlPac.BuscarPacienteRelatorio();
			ControlPac.ProcessaRelatorio(@"..\..\Relatorios\RPaciente.rdlc",
						 dtDados, reportViewer1, "DSPaciente", null);
			this.reportViewer2.RefreshReport();
		}
	}
}
