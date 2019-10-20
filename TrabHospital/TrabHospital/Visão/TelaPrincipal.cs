using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabHospital.Visão;

namespace TrabHospital
{
	public partial class TelaPrincipal : Form
	{
		public TelaPrincipal()
		{
			InitializeComponent();
		}

		private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TelaPacientes tela = new TelaPacientes();
			tela.ShowDialog();
			tela.Dispose();
		}
	}
}
