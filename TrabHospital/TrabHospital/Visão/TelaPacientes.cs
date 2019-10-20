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
	public partial class TelaPacientes : Form
	{
		private CtrlPacientes ControlPac = new CtrlPacientes();

		public TelaPacientes()
		{
			InitializeComponent();
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			char sexo;

			if (comboBox1.SelectedItem.ToString() == "Masculino")
				sexo = 'M';
			else
				sexo = 'F';
			if (!ControlPac.GravarPaciente(tbNome.Text, sexo, dtpNascimento.Value.Date, tbEndereco.Text,
								  tbCidade.Text, tbUf.Text, tbCep.Text, tbTelefone.Text))
			{
				MessageBox.Show("Não foi possível gravar o paciente. Verifique os dados");
			}
		}

		private void BAdicionarDep_Click(object sender, EventArgs e)
		{

		}

		private void bNovo_Click(object sender, EventArgs e)
		{

		}

		private void bSalvar_Click(object sender, EventArgs e)
		{

		}

		private void bPesquisar_Click(object sender, EventArgs e)
		{

		}

		private void bExcluir_Click(object sender, EventArgs e)
		{

		}

		private void bAlterar_Click(object sender, EventArgs e)
		{

		}
	}
}
