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
        DataTable dtatends = new DataTable();
        DataTable dtdeps = new DataTable();
        private int cont = 0;

        public TelaAtendimentos()
		{
			InitializeComponent();
            dtConta.Columns.Add("pro_descricao");
            dtConta.Columns.Add("con_data");
            dtConta.Columns.Add("con_qtde");
            dtConta.Columns.Add("pro_valor");
            dtConta.Columns.Add("pro_total");
            dtConta.Columns.Add("pro_codigo");

        }

        private void JogaNaOutraTela()
        {
            tbCodigo.Text = dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_codigo"].ToString();
            tbAnamnese.Text = dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_anamnese"].ToString();
            dtpAtendimento.Value = Convert.ToDateTime(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_data"]);
            cbDiagnostico.SelectedValue = (int)dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["dia_codigo"];
            cbPaciente.SelectedValue = (int)dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["pac_codigo"];
            cbMedico.SelectedValue = (int)dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["med_codigo"];
            dgvProcedimentos.DataSource = dtConta = ControlAte.BuscarContas(Convert.ToInt32(tbCodigo.Text));
            for (int i = 0; i < dtConta.Rows.Count; i++)
            {
                DataRow row = dtConta.NewRow();
                row["pro_descricao"] = dtConta.Rows[i]["pro_descricao"];
                row["con_data"] = dtConta.Rows[i]["con_data"];
                row["con_qtde"] = dtConta.Rows[i]["con_qtde"];
                row["pro_valor"] = dtConta.Rows[i]["pro_valor"];
                row["pro_codigo"] = dtConta.Rows[i]["pro_codigo"];
                row["pro_total"] = dtConta.Rows[i]["pro_total"];
                ControlAte.AddContaU(row);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvAtendimentos.SelectedRows.Count > 0)
            {
                if (dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_contafechada"].ToString() == "N")
                {
                    limpa();
                    JogaNaOutraTela();
                    pnDados.Enabled = true;
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    cbDiagnostico.Focus();
                    if (dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtobito"] != DBNull.Value)
                    {
                        dtpaltaobito.Value = Convert.ToDateTime(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtobito"]);
                        tbcausamorte.Text = dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_causamortis"].ToString();
                        dtpaltaobito.Visible = true;
                        lblaltaobito.Visible = true;
                        tbcausamorte.Visible = true;
                        lblcausamorte.Visible = true;
                    }
                    else if(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtalta"] != DBNull.Value)
                    {
                        dtpaltaobito.Value = Convert.ToDateTime(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtalta"]);
                        dtpretorno.Value = Convert.ToDateTime(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtretorno"]);
                        dtpaltaobito.Visible = true;
                        lblaltaobito.Visible = true;
                        lblretorno.Visible = true;
                        dtpretorno.Visible = true;
                    }

                    tabsatendimento.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Conta já fechada, Impossível alteração");
                }
            }

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if(tbQtde.TextLength > 0)
            {
                DataRow row = dtConta.NewRow();
                row["pro_descricao"] = cbProcede.Text;
                row["con_data"] = dtpDataConta.Value;
                row["con_qtde"] = tbQtde.Text;
                row["pro_valor"] = tbValor.Text;
                row["pro_codigo"] = cbProcede.SelectedValue;
                row["pro_total"] = Convert.ToDouble(tbValor.Text) * Convert.ToInt32(tbQtde.Text);

                if (tbCodigo.TextLength == 0)
                    ControlAte.AddContaA(row);
                else
                    ControlAte.AddContaU(row);
                dtConta.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("A quantidade deve ser preenchida");
                tbQtde.Focus();
            }
        }

        private void TelaAtendimentos_Load(object sender, EventArgs e)
        {
            cbDiagnostico.DataSource = ControlAte.BuscaDiagnosticos();
            cbDiagnostico.ValueMember = "dia_codigo";
            cbDiagnostico.DisplayMember = "dia_descricao";
            cbPaciente.ValueMember = "pac_codigo";
            cbPaciente.DisplayMember = "pac_nome";
            cbPaciente.DataSource = ControlAte.BuscaPacientes();
            cbMedico.ValueMember = "med_codigo";
            cbMedico.DisplayMember = "med_nome";
            if(cbPaciente.Text.Length != 0)
            {
                cbMedico.DataSource = ControlAte.BuscaMedicos(Convert.ToInt32(cbPaciente.SelectedValue));
                cbMedico2.ValueMember = "med_codigo";
                cbMedico2.DisplayMember = "med_nome";
                cbMedico2.DataSource = ControlAte.BuscaMedicos2(Convert.ToInt32(cbPaciente.SelectedValue));
                cbProcede.ValueMember = "pro_codigo";
                cbProcede.DisplayMember = "pro_descricao";
            }
            cbProcede.DataSource = ControlAte.BuscarProcedimentos();
            dgvProcedimentos.DataSource = dtConta;
            rbatendimento.Checked = true;
            dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPData(dtpPeriodo.Value, dtpPeriodoObito.Value, 'a');
            gbPagamento.Enabled = false;
        }

        public void limpa()
        {
            tbAnamnese.Clear();
            tbCodigo.Clear();
            tbPesqNomePac.Clear();
            dtConta.Rows.Clear();
            tbQtde.Clear();
            tbValor.Clear();
            dtpaltaobito.Visible = false;
            lblaltaobito.Visible = false;
            tbcausamorte.Visible = false;
            lblcausamorte.Visible = false;
            lblretorno.Visible = false;
            dtpretorno.Visible = false;
        }

        private void LiberaCampos()
        {
            pnDados.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LiberaCampos();
            cbDiagnostico.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(tbAnamnese.Text.Length == 0)
            {
                MessageBox.Show("Campo anamnese deve ser preenchido!","Obrigatório!",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbAnamnese.Focus();
            }
            else if(tbCodigo.Text.Length == 0)
            {
                if(ControlAte.SalvarAtendimento((int)cbDiagnostico.SelectedValue,(int)cbPaciente.SelectedValue,
                                (int)cbMedico.SelectedValue,dtpAtendimento.Value,tbAnamnese.Text))
                {
                    limpa();
                    pnDados.Enabled = false;
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Não foi possivel salvar");
                }
            }
            else
            {
                if(tbcausamorte.Visible)
                {
                    if (!ControlAte.AlterarAtendimentoCMorte(Convert.ToInt32(tbCodigo.Text), (int)cbDiagnostico.SelectedValue,
                                (int)cbPaciente.SelectedValue, (int)cbMedico.SelectedValue, dtpAtendimento.Value, tbAnamnese.Text,
                                tbcausamorte.Text, dtpaltaobito.Value))
                        MessageBox.Show("Não foi possivel alterar");
                    else
                    {
                        limpa();
                        pnDados.Enabled = false;
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
                else if(dtpretorno.Visible)
                {
                    if(!ControlAte.AlterarAtendimentoCAlta(Convert.ToInt32(tbCodigo.Text), (int)cbDiagnostico.SelectedValue,
                                (int)cbPaciente.SelectedValue, (int)cbMedico.SelectedValue, dtpAtendimento.Value, tbAnamnese.Text,
                                dtpretorno.Value, dtpaltaobito.Value))
                        MessageBox.Show("Não foi possivel alterar");
                    else
                    {
                        limpa();
                        pnDados.Enabled = false;
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
                else
                {
                    if(!ControlAte.AlterarAtendimento(Convert.ToInt32(tbCodigo.Text), (int)cbDiagnostico.SelectedValue,
                                (int)cbPaciente.SelectedValue, (int)cbMedico.SelectedValue, dtpAtendimento.Value, tbAnamnese.Text))
                        MessageBox.Show("Não foi possivel alterar");
                    else
                    {
                        limpa();
                        pnDados.Enabled = false;
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                }
            }
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
            if(rbatendimento.Checked)
            {
                if (tbPesqNomePac.TextLength > 0 && cbMedico2.SelectedIndex == -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPNomeData(tbPesqNomePac.Text, dtpPeriodo.Value, dtpPeriodoObito.Value, 'a');
                }
                else if (tbPesqNomePac.TextLength > 0 && cbMedico2.SelectedIndex != -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPNomeDataMed(tbPesqNomePac.Text, dtpPeriodo.Value, dtpPeriodoObito.Value, Convert.ToInt32(cbMedico2.SelectedValue),'a');
                }
                else if (tbPesqNomePac.TextLength == 0 && cbMedico2.SelectedIndex != -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPDataMed(dtpPeriodo.Value, dtpPeriodoObito.Value, Convert.ToInt32(cbMedico2.SelectedValue),'a');
                }
                else if (tbPesqNomePac.TextLength == 0 && cbMedico2.SelectedIndex == -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPData(dtpPeriodo.Value, dtpPeriodoObito.Value,'a');
                }
            }
            else if(rbobito.Checked)
            {
                if (tbPesqNomePac.TextLength > 0 && cbMedico2.SelectedIndex == -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPNomeData(tbPesqNomePac.Text, dtpPeriodo.Value, dtpPeriodoObito.Value,'o');
                }
                else if (tbPesqNomePac.TextLength > 0 && cbMedico2.SelectedIndex != -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPNomeDataMed(tbPesqNomePac.Text, dtpPeriodo.Value, dtpPeriodoObito.Value, Convert.ToInt32(cbMedico2.SelectedValue),'o');
                }
                else if (tbPesqNomePac.TextLength == 0 && cbMedico2.SelectedIndex != -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPDataMed(dtpPeriodo.Value, dtpPeriodoObito.Value, Convert.ToInt32(cbMedico2.SelectedValue),'o');
                }
                else if (tbPesqNomePac.TextLength == 0 && cbMedico2.SelectedIndex == -1)
                {
                    dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPData(dtpPeriodo.Value, dtpPeriodoObito.Value,'o');
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvAtendimentos.CurrentRow.Cells[13].Value.ToString() == "S")
            {
                MessageBox.Show("Atendimento já fechado, não é possivel fazer a exclusão", "Atendimento Fechado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                if (MessageBox.Show("Deseja mesmo excluir o atendimento?", "Alerta!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    if (!ControlAte.ExcluiAtendimento((int)dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_codigo"]))
                        MessageBox.Show("Atendimento já está em uso por outra classe", "Erro na exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dtatends.Rows.RemoveAt(dgvAtendimentos.CurrentRow.Index);
            }
        }

        private void limpaOpc()
        {
            rbatendimento.Checked = true;
            tbPesqNomePac.Text = "";
            cbMedico2.SelectedIndex = -1;
            dgvAtendimentos.DataSource = dtatends = ControlAte.BuscaAtendimentosPData(dtpPeriodo.Value, dtpPeriodoObito.Value, 'a');
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limpaOpc();
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if(dgvProcedimentos.SelectedRows.Count>0)
            {
                ControlAte.RemoveConta(dtConta.Rows[dgvAtendimentos.CurrentRow.Index]);
                dtConta.Rows[dgvProcedimentos.CurrentRow.Index].Delete();
            }
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMedico.DataSource = ControlAte.BuscaMedicos(Convert.ToInt32(cbPaciente.SelectedValue));
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMedico2.SelectedIndex = -1;
            if(tabsatendimento.SelectedIndex == 1)
            {
                limpaOpc();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbMedico2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProcede_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbValor.Text = ControlAte.BuscaValorConta((int)cbProcede.SelectedValue).ToString();
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            if(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtobito"] == DBNull.Value && 
                dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtalta"] == DBNull.Value)
            {
                DialogResult dr = MessageBox.Show("O paciente foi a óbito?", "Resultado",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dtpaltaobito.Visible = true;
                    lblaltaobito.Visible = true;
                    tbcausamorte.Visible = true;
                    lblcausamorte.Visible = true;
                    JogaNaOutraTela();
                    LiberaCampos();
                    tabsatendimento.SelectedIndex = 0;
                    tbcausamorte.Focus();
                }
                else if (dr == DialogResult.No && MessageBox.Show("O paciente teve alta?", "Resultado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtpaltaobito.Visible = true;
                    lblaltaobito.Visible = true;
                    lblretorno.Visible = true;
                    dtpretorno.Visible = true;
                    JogaNaOutraTela();
                    LiberaCampos();
                    dtpretorno.Value = dtpretorno.Value.AddDays(30);
                    tabsatendimento.SelectedIndex = 0;
                    dtpaltaobito.Focus();
                }
            }
            else
            {
                MessageBox.Show("Esse Atendimento já tem um resultado");
            }
        }

        private void dgvAtendimentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double valorrest = 0;
            if(dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_contafechada"].ToString() == "N" &&
                (dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtobito"] != DBNull.Value ||
                dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_dtalta"] != DBNull.Value))
            {
                gbPagamento.Enabled = true;
                dgvdepositos.Enabled = true;
                tbAtendimento.Text = dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_codigo"].ToString();
                tbValorConta.Text = (dtatends.Rows[dgvAtendimentos.CurrentRow.Index]["atn_vrconta"]).ToString();
                dgvdepositos.DataSource = dtdeps = ControlAte.BuscaDepositos(Convert.ToInt32(tbAtendimento.Text));
                cont = 0;
                for (int i = 0; i < dtdeps.Rows.Count; i++)
                {
                    valorrest += Convert.ToDouble(dtdeps.Rows[i]["dep_valor"]);
                    cont++;
                }
                tbvalorrestante.Text = (Convert.ToDouble(tbValorConta.Text) - valorrest).ToString();
                tabsatendimento.SelectedIndex = 2;
                tbParcela.Text = cont.ToString();
            }
            else
            {
                MessageBox.Show("A conta deve estar aberta e algum resultado de atendimento especificado");
            }
        }

        private void btConfirmaPags_Click(object sender, EventArgs e)
        {
            if(ControlAte.SalvarDepositos(dtdeps))
            {
                if(Convert.ToInt32(tbvalorrestante.Text)<=0)
                {
                    MessageBox.Show("Conta totalmente paga (será automaticamene fechada)","Conta Fechada",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ControlAte.FechaConta(Convert.ToInt32(tbAtendimento.Text));
                }
                gbPagamento.Enabled = false;
                dgvdepositos.Enabled = false;
                tbParcela.Clear();
                dtdeps.Rows.Clear();
                tbCheque.Clear();
                tbValorConta.Clear();
                tbvalorrestante.Clear();
                tbAtendimento.Clear();
                tbValorPag.Clear();
            }
            
        }

        private void btAddDeposito_Click(object sender, EventArgs e)
        {
            if(tbValorConta.TextLength == 0)
            {
                MessageBox.Show("O valor deve ser informado");
                tbValorConta.Focus();
            }
            else if(tbCheque.TextLength == 0)
            {
                MessageBox.Show("Numero do cheque deve ser informado");
                tbCheque.Focus();
            }
            else if(tbParcela.TextLength == 0)
            {
                MessageBox.Show("Codigo da parcela deve ser informado");
                tbParcela.Focus();
            }
            else
            {
                DataRow row = dtdeps.NewRow();
                row["atn_codigo"] = tbAtendimento.Text;
                row["dep_parcela"] = tbParcela.Text;
                row["dep_data"] = dtpDeposito.Value;
                row["dep_valor"] = tbValorPag.Text;
                row["dep_nrcheque"] = tbCheque.Text;
                row["dep_dtcompensa"] = dtpDataComp.Value;
                dtdeps.Rows.Add(row);
                double valor = 0;
                for (int i = 0; i < dtdeps.Rows.Count; i++)
                    valor += Convert.ToDouble(dtdeps.Rows[i]["dep_valor"]);
                tbvalorrestante.Text = (Convert.ToDouble(tbValorConta.Text) - valor).ToString();
                cont++;
                tbParcela.Text = cont.ToString();
            }
        }

        private void btRemoveDepositos_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente remover esse deposito","Exclusão",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtdeps.Rows.RemoveAt(dgvdepositos.CurrentRow.Index);
                double valor = 0;
                for (int i = 0; i < dtdeps.Rows.Count; i++)
                    valor += Convert.ToDouble(dtdeps.Rows[i]["dep_valor"]);
                tbvalorrestante.Text = (Convert.ToDouble(tbValorConta.Text) - valor).ToString();
            }
        }

        private void TbQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TbCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TbValorPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                if (e.KeyChar != ',')
                    e.Handled = true;
                else if (tbValorPag.Text.IndexOf(',') > 0)
                    e.Handled = true;
            }
        }
    }
}
