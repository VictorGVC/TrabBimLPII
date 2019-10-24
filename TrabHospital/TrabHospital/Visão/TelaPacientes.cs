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
        private CtrlPlano ctrlplano = new CtrlPlano();

		public TelaPacientes()
		{
			InitializeComponent();
            cbPlano.DataSource = ctrlplano.BuscarPlanos(-1);
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			char sexo;
            
            if (tbNome.Text == "")
            {
                MessageBox.Show("O Nome deve ser informado");
                tbCodigo.Focus();
            }
            else if (cbSexo.Text == "")
            {
                MessageBox.Show("O sexo deve ser informado");
                tbCodigo.Focus();
            }
            else if (tbEndereco.Text == "")
            {
                MessageBox.Show("O endereço deve ser informado");
                tbCodigo.Focus();
            }
            else if (tbCidade.Text == "")
            {
                MessageBox.Show("O cidade deve ser informado");
                tbCodigo.Focus();
            }
            else if (cbUF.Text == "")
            {
                MessageBox.Show("O UF deve ser informado");
                tbCodigo.Focus();
            }
            else if (tbCep.Text == "")
            {
                MessageBox.Show("O CEP deve ser informado");
                tbCodigo.Focus();
            }
            else if (tbTelefone.Text == "")
            {
                MessageBox.Show("O telefone deve ser informado");
                tbCodigo.Focus();
            }
            else if (btnSalvar.Text != "Alterar")   
            {
                if (cbSexo.SelectedItem.ToString() == "Masculino")
                    sexo = 'M';
                else
                    sexo = 'F';
                if (!ControlPac.GravarPaciente(tbNome.Text, sexo, dtpNascimento.Value.Date, tbEndereco.Text,
                                        tbCidade.Text, cbUF.Text, tbCep.Text, tbTelefone.Text))
                {
                    MessageBox.Show("Não foi possível gravar o paciente. Verifique os dados");
                }
            }
            else
            {
                btnSalvar.Text = "Salvar";
                if (cbSexo.SelectedItem.ToString() == "Masculino")
                    sexo = 'M';
                else
                    sexo = 'F';
                if (!ControlPac.AlterarPaciente(Convert.ToInt32(tbCodigo.Text),tbNome.Text, sexo, dtpNascimento.Value.Date, tbEndereco.Text,
                                        tbCidade.Text, cbUF.Text, tbCep.Text, tbTelefone.Text))
                {
                    MessageBox.Show("Não foi possível alterar o paciente. Verifique os dados");
                }
            }
		}

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            pnDados.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnDados.Enabled = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Text = "Alterar";
            tabs.SelectedTab = tabPesquisa;
        }
    }
}
