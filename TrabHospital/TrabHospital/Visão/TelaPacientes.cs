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

        public void limpa()
        {
            tbCep.Clear();
            tbCidade.Clear();
            tbCodigo.Clear();
            tbEndereco.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            tbPesqNome.Clear();
        }

        private void TelaPacientes_Load(object sender, EventArgs e)
        {
            cbPlano.DisplayMember = "pla_descricao";
            cbPlano.ValueMember = "pla_codigo";
            cbPlano.DataSource = ControlPac.BuscarPlanos();
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

		private void BtnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void DgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = ControlPac.BuscarPaciente(tbPesqNome.Text);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Text = "Alterar";
            tabs.SelectedTab = painel;
            tbCodigo.Text = dgvPacientes.SelectedRows[0].Cells["cod"].Value.ToString();
            tbNome.Text = dgvPacientes.SelectedRows[0].Cells["nome_pac"].Value.ToString();
            tbEndereco.Text = dgvPacientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            tbCidade.Text = dgvPacientes.SelectedRows[0].Cells["cidade"].Value.ToString();
            tbCep.Text = dgvPacientes.SelectedRows[0].Cells["cep_pac"].Value.ToString();
            tbTelefone.Text = dgvPacientes.SelectedRows[0].Cells["fone"].Value.ToString();
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ControlPac.ExcluirPaciente((int)dgvPacientes.SelectedRows[0].Cells["cod"].Value);
            dgvPacientes.DataSource = ControlPac.BuscarPaciente("");
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
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
            else if (btnSalvar.Text == "Salvar")
            {
                if (cbSexo.SelectedItem.ToString() == "Masculino")
                    sexo = 'M';
                else
                    sexo = 'F';
                if (!ControlPac.GravarPaciente(tbNome.Text, sexo, dtpNascimento.Value.Date, tbEndereco.Text,
                                        tbCidade.Text, cbUF.Text, tbCep.Text, tbTelefone.Text, (int)cbPlano.SelectedValue))
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
                if (!ControlPac.AlterarPaciente(Convert.ToInt32(tbCodigo.Text), tbNome.Text, sexo, dtpNascimento.Value.Date, tbEndereco.Text,
                                        tbCidade.Text, cbUF.Text, tbCep.Text, tbTelefone.Text, (int)cbPlano.SelectedValue))
                {
                    MessageBox.Show("Não foi possível alterar o paciente. Verifique os dados");
                }
            }
            limpa();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpa();
            pnDados.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = ControlPac.BuscarPaciente("");
        }

        private void tbCep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}