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
	public partial class TelaAtendimentos : Form
	{
        private CtrlAtendimentos ControlAte = new CtrlAtendimentos();
        private DataTable dtConta = new DataTable();

        public TelaAtendimentos()
		{
			InitializeComponent();
            dtConta.Columns.Add("pro_descricao");
            dtConta.Columns.Add("pro_data");
            dtConta.Columns.Add("pro_qtde");
            dtConta.Columns.Add("pro_valor");
            dtConta.Columns.Add("pro_total");
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dtConta.NewRow();

            row["pro_descricao"] = cbProcede.SelectedItem.ToString();
            row["pro_data"] = dtpDataConta.Value;
            row["pro_qtde"] = tbQtde.Text;
            row["pro_valor"] = tbValor.Text;
            row["pro_total"] = Convert.ToDouble(tbValor.Text) * Convert.ToDouble(tbQtde.Text);

            dtConta.Rows.Add(row);
        }

        private void TelaAtendimentos_Load(object sender, EventArgs e)
        {
            cbDiagnostico.DataSource = ControlAte.BuscaDiagnosticos();
            cbDiagnostico.ValueMember = "dia_codigo";
            cbDiagnostico.DisplayMember = "dia_descricao";
            cbPaciente.DataSource = ControlAte.BuscaPacientes();
            cbPaciente.ValueMember = "pac_codigo";
            cbPaciente.DisplayMember = "pac_nome";
            cbMedico.DataSource = ControlAte.BuscaMedicos();
            cbMedico2 = cbMedico;
            cbMedico.ValueMember = "med_codigo";
            cbMedico.DisplayMember = "med_nome";
            cbMedico2.ValueMember = "med_codigo";
            cbMedico2.DisplayMember = "med_nome";
            cbProcede.DataSource = ControlAte.BuscarProcedimentos();
            cbProcede.ValueMember = "pro_codigo";
            cbProcede.DisplayMember = "pro_descricao";
        }

        public void limpa()
        {
            tbAnamnese.Clear();
            tbCodigo.Clear();
            tbPesqNomePac.Clear();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            cbDiagnostico.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpa();
            pnDados.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if(dgvProcedimentos.SelectedRows.Count>0)
            {
                dgvProcedimentos.Rows.Remove(dgvProcedimentos.CurrentRow);
            }
        }
    }
}
