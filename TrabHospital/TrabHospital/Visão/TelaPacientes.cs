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
        DataTable dtpac = new DataTable();

		public TelaPacientes()
		{
			InitializeComponent();
		}

        private void limpa()
        {
            tbCep.Clear();
            tbCidade.Clear();
            tbCodigo.Clear();
            tbEndereco.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            tbPesqNome.Clear();
            pnDados.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void TelaPacientes_Load(object sender, EventArgs e)
        {
            cbPlano.DisplayMember = "pla_descricao";
            cbPlano.ValueMember = "pla_codigo";
            cbPlano.DataSource = ControlPac.BuscarPlanos();
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            tbNome.Focus();
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
            else if (cbPlano.Text == "")
            {
                MessageBox.Show("O Plano deve ser informado");
                tbCodigo.Focus();
            }
            else if (tbTelefone.Text == "")
            {
                MessageBox.Show("O telefone deve ser informado");
                tbCodigo.Focus();
            }
            else if (btnSalvar.Text == "Salvar")
            {
                if (cbSexo.SelectedIndex == 0)
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
                if (cbSexo.SelectedIndex == 0)
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
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = dtpac = ControlPac.BuscarPaciente(tbPesqNome.Text);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_codigo"].ToString();
            tbNome.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_nome"].ToString();
            tbEndereco.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_endereco"].ToString();
            tbCidade.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_cidade"].ToString();
            tbCep.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_cep"].ToString();
            tbTelefone.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_fone"].ToString();
            cbPlano.SelectedValue = Convert.ToInt32(dtpac.Rows[dgvPacientes.CurrentRow.Index]["pla_codigo"]);
            if (dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_sexo"].ToString() == "M")
                cbSexo.SelectedIndex = 0;
            else
                cbSexo.SelectedIndex = 1;
            cbUF.Text = dtpac.Rows[dgvPacientes.CurrentRow.Index]["pac_uf"].ToString();
            tabs.SelectedTab = painel;
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ControlPac.ExcluirPaciente((int)dgvPacientes.SelectedRows[0].Cells["cod"].Value);
            dgvPacientes.DataSource = dtpac = ControlPac.BuscarPaciente("");
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = dtpac = ControlPac.BuscarPaciente("");
        }
	}
}