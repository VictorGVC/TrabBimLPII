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
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
        }

        private void AtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAtendimentos tela = new TelaAtendimentos();
            Hide();
            tela.ShowDialog();
            tela.Dispose();
            Show();
        }

		private void PacientesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			TelaRelatórios tela = new TelaRelatórios(0);
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
		}

		private void AtendimentosToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			TelaRelatórios tela = new TelaRelatórios(1);
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
		}

		private void BtnPacientes_Click(object sender, EventArgs e)
		{
			TelaPacientes tela = new TelaPacientes();
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
		}

		private void BtnAtendimentos_Click(object sender, EventArgs e)
		{
			TelaAtendimentos tela = new TelaAtendimentos();
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
			TelaRelatórios tela = new TelaRelatórios(0);
			Hide();
			tela.ShowDialog();
			tela.Dispose();
			Show();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
