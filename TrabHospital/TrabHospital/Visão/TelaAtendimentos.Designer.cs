namespace TrabHospital.Visão
{
	partial class TelaAtendimentos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAtendimentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabsatendimento = new System.Windows.Forms.TabControl();
            this.painel = new System.Windows.Forms.TabPage();
            this.pnDados = new System.Windows.Forms.Panel();
            this.lblretorno = new System.Windows.Forms.Label();
            this.dtpretorno = new System.Windows.Forms.DateTimePicker();
            this.lblcausamorte = new System.Windows.Forms.Label();
            this.tbcausamorte = new System.Windows.Forms.TextBox();
            this.lblaltaobito = new System.Windows.Forms.Label();
            this.dtpaltaobito = new System.Windows.Forms.DateTimePicker();
            this.gbConta = new System.Windows.Forms.GroupBox();
            this.tbValor = new System.Windows.Forms.MaskedTextBox();
            this.tbQtde = new System.Windows.Forms.MaskedTextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDataConta = new System.Windows.Forms.DateTimePicker();
            this.cbProcede = new System.Windows.Forms.ComboBox();
            this.dgvProcedimentos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAnamnese = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAtendimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbDiagnostico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.rbatendimento = new System.Windows.Forms.RadioButton();
            this.rbobito = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpPeriodoObito = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMedico2 = new System.Windows.Forms.ComboBox();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.codigoatn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_diag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anamnese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtretorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causamortis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtatendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtobito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbPesqNomePac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabFechaAtt = new System.Windows.Forms.TabPage();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.tbValorConta = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpDataComp = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCheque = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbValorPg = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbParcela = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btSeleciona = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.tabsatendimento.SuspendLayout();
            this.painel.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.gbConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimentos)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.tabFechaAtt.SuspendLayout();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabsatendimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 461);
            this.panel2.TabIndex = 1;
            // 
            // tabsatendimento
            // 
            this.tabsatendimento.Controls.Add(this.painel);
            this.tabsatendimento.Controls.Add(this.tabPesquisa);
            this.tabsatendimento.Controls.Add(this.tabFechaAtt);
            this.tabsatendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsatendimento.Location = new System.Drawing.Point(0, 0);
            this.tabsatendimento.Name = "tabsatendimento";
            this.tabsatendimento.SelectedIndex = 0;
            this.tabsatendimento.Size = new System.Drawing.Size(480, 461);
            this.tabsatendimento.TabIndex = 37;
            this.tabsatendimento.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // painel
            // 
            this.painel.Controls.Add(this.pnDados);
            this.painel.Controls.Add(this.pnlBotoes);
            this.painel.Location = new System.Drawing.Point(4, 22);
            this.painel.Name = "painel";
            this.painel.Padding = new System.Windows.Forms.Padding(3);
            this.painel.Size = new System.Drawing.Size(472, 435);
            this.painel.TabIndex = 0;
            this.painel.Text = "Cadastro";
            this.painel.UseVisualStyleBackColor = true;
            // 
            // pnDados
            // 
            this.pnDados.BackColor = System.Drawing.Color.PowderBlue;
            this.pnDados.Controls.Add(this.lblretorno);
            this.pnDados.Controls.Add(this.dtpretorno);
            this.pnDados.Controls.Add(this.lblcausamorte);
            this.pnDados.Controls.Add(this.tbcausamorte);
            this.pnDados.Controls.Add(this.lblaltaobito);
            this.pnDados.Controls.Add(this.dtpaltaobito);
            this.pnDados.Controls.Add(this.gbConta);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.tbAnamnese);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.dtpAtendimento);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.cbMedico);
            this.pnDados.Controls.Add(this.cbPaciente);
            this.pnDados.Controls.Add(this.cbDiagnostico);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.tbCodigo);
            this.pnDados.Enabled = false;
            this.pnDados.Location = new System.Drawing.Point(6, 6);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(458, 379);
            this.pnDados.TabIndex = 52;
            // 
            // lblretorno
            // 
            this.lblretorno.AutoSize = true;
            this.lblretorno.Location = new System.Drawing.Point(335, 8);
            this.lblretorno.Name = "lblretorno";
            this.lblretorno.Size = new System.Drawing.Size(86, 13);
            this.lblretorno.TabIndex = 47;
            this.lblretorno.Text = "Data do Retorno";
            this.lblretorno.Visible = false;
            // 
            // dtpretorno
            // 
            this.dtpretorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpretorno.Location = new System.Drawing.Point(338, 24);
            this.dtpretorno.Name = "dtpretorno";
            this.dtpretorno.Size = new System.Drawing.Size(117, 20);
            this.dtpretorno.TabIndex = 46;
            this.dtpretorno.Visible = false;
            // 
            // lblcausamorte
            // 
            this.lblcausamorte.AutoSize = true;
            this.lblcausamorte.Location = new System.Drawing.Point(98, 8);
            this.lblcausamorte.Name = "lblcausamorte";
            this.lblcausamorte.Size = new System.Drawing.Size(82, 13);
            this.lblcausamorte.TabIndex = 45;
            this.lblcausamorte.Text = "Causa da Morte";
            this.lblcausamorte.Visible = false;
            // 
            // tbcausamorte
            // 
            this.tbcausamorte.Location = new System.Drawing.Point(98, 24);
            this.tbcausamorte.Name = "tbcausamorte";
            this.tbcausamorte.Size = new System.Drawing.Size(119, 20);
            this.tbcausamorte.TabIndex = 44;
            this.tbcausamorte.Visible = false;
            // 
            // lblaltaobito
            // 
            this.lblaltaobito.AutoSize = true;
            this.lblaltaobito.Location = new System.Drawing.Point(220, 9);
            this.lblaltaobito.Name = "lblaltaobito";
            this.lblaltaobito.Size = new System.Drawing.Size(95, 13);
            this.lblaltaobito.TabIndex = 43;
            this.lblaltaobito.Text = "Data da alta/Óbito";
            this.lblaltaobito.Visible = false;
            // 
            // dtpaltaobito
            // 
            this.dtpaltaobito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpaltaobito.Location = new System.Drawing.Point(223, 24);
            this.dtpaltaobito.Name = "dtpaltaobito";
            this.dtpaltaobito.Size = new System.Drawing.Size(109, 20);
            this.dtpaltaobito.TabIndex = 42;
            this.dtpaltaobito.Visible = false;
            // 
            // gbConta
            // 
            this.gbConta.BackColor = System.Drawing.Color.Transparent;
            this.gbConta.Controls.Add(this.tbValor);
            this.gbConta.Controls.Add(this.tbQtde);
            this.gbConta.Controls.Add(this.btRemover);
            this.gbConta.Controls.Add(this.btAdd);
            this.gbConta.Controls.Add(this.label14);
            this.gbConta.Controls.Add(this.label13);
            this.gbConta.Controls.Add(this.label12);
            this.gbConta.Controls.Add(this.label10);
            this.gbConta.Controls.Add(this.dtpDataConta);
            this.gbConta.Controls.Add(this.cbProcede);
            this.gbConta.Controls.Add(this.dgvProcedimentos);
            this.gbConta.ForeColor = System.Drawing.Color.Black;
            this.gbConta.Location = new System.Drawing.Point(4, 129);
            this.gbConta.Name = "gbConta";
            this.gbConta.Size = new System.Drawing.Size(451, 247);
            this.gbConta.TabIndex = 41;
            this.gbConta.TabStop = false;
            this.gbConta.Text = "Conta";
            // 
            // tbValor
            // 
            this.tbValor.Enabled = false;
            this.tbValor.Location = new System.Drawing.Point(345, 40);
            this.tbValor.Mask = "0000000";
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 49;
            this.tbValor.ValidatingType = typeof(int);
            // 
            // tbQtde
            // 
            this.tbQtde.Location = new System.Drawing.Point(134, 40);
            this.tbQtde.Mask = "00000";
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(98, 20);
            this.tbQtde.TabIndex = 49;
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.White;
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(233, 66);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(78, 23);
            this.btRemover.TabIndex = 48;
            this.btRemover.Text = "Remover";
            this.btRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.White;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(142, 66);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(78, 23);
            this.btAdd.TabIndex = 47;
            this.btAdd.Text = "Adicionar";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Valor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Procedimento";
            // 
            // dtpDataConta
            // 
            this.dtpDataConta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConta.Location = new System.Drawing.Point(238, 40);
            this.dtpDataConta.Name = "dtpDataConta";
            this.dtpDataConta.Size = new System.Drawing.Size(101, 20);
            this.dtpDataConta.TabIndex = 8;
            // 
            // cbProcede
            // 
            this.cbProcede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProcede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProcede.FormattingEnabled = true;
            this.cbProcede.Location = new System.Drawing.Point(6, 40);
            this.cbProcede.Name = "cbProcede";
            this.cbProcede.Size = new System.Drawing.Size(121, 21);
            this.cbProcede.TabIndex = 6;
            this.cbProcede.SelectedIndexChanged += new System.EventHandler(this.cbProcede_SelectedIndexChanged);
            // 
            // dgvProcedimentos
            // 
            this.dgvProcedimentos.AllowUserToAddRows = false;
            this.dgvProcedimentos.AllowUserToDeleteRows = false;
            this.dgvProcedimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.procedimento,
            this.data,
            this.qtde,
            this.valor,
            this.total});
            this.dgvProcedimentos.Location = new System.Drawing.Point(6, 102);
            this.dgvProcedimentos.Name = "dgvProcedimentos";
            this.dgvProcedimentos.ReadOnly = true;
            this.dgvProcedimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvProcedimentos.RowHeadersVisible = false;
            this.dgvProcedimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimentos.Size = new System.Drawing.Size(439, 139);
            this.dgvProcedimentos.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Data de Atendimento";
            // 
            // tbAnamnese
            // 
            this.tbAnamnese.Location = new System.Drawing.Point(4, 103);
            this.tbAnamnese.MaxLength = 100;
            this.tbAnamnese.Name = "tbAnamnese";
            this.tbAnamnese.Size = new System.Drawing.Size(451, 20);
            this.tbAnamnese.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Anamnese";
            // 
            // dtpAtendimento
            // 
            this.dtpAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtendimento.Location = new System.Drawing.Point(338, 64);
            this.dtpAtendimento.Name = "dtpAtendimento";
            this.dtpAtendimento.Size = new System.Drawing.Size(117, 20);
            this.dtpAtendimento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Diagnóstico";
            // 
            // cbMedico
            // 
            this.cbMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(237, 63);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(95, 21);
            this.cbMedico.TabIndex = 4;
            // 
            // cbPaciente
            // 
            this.cbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(131, 63);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(100, 21);
            this.cbPaciente.TabIndex = 3;
            this.cbPaciente.SelectedIndexChanged += new System.EventHandler(this.cbPaciente_SelectedIndexChanged);
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiagnostico.FormattingEnabled = true;
            this.cbDiagnostico.Location = new System.Drawing.Point(4, 63);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Size = new System.Drawing.Size(121, 21);
            this.cbDiagnostico.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(4, 24);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(86, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnNovo);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(3, 391);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(466, 41);
            this.pnlBotoes.TabIndex = 48;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(331, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(82, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(240, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(53, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(145, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPesquisa.Controls.Add(this.rbatendimento);
            this.tabPesquisa.Controls.Add(this.rbobito);
            this.tabPesquisa.Controls.Add(this.btnLimpar);
            this.tabPesquisa.Controls.Add(this.dtpPeriodoObito);
            this.tabPesquisa.Controls.Add(this.label9);
            this.tabPesquisa.Controls.Add(this.cbMedico2);
            this.tabPesquisa.Controls.Add(this.dtpPeriodo);
            this.tabPesquisa.Controls.Add(this.label7);
            this.tabPesquisa.Controls.Add(this.dgvAtendimentos);
            this.tabPesquisa.Controls.Add(this.btnPesquisar);
            this.tabPesquisa.Controls.Add(this.btnExcluir);
            this.tabPesquisa.Controls.Add(this.btnAlterar);
            this.tabPesquisa.Controls.Add(this.tbPesqNomePac);
            this.tabPesquisa.Controls.Add(this.label8);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(472, 435);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
            // 
            // rbatendimento
            // 
            this.rbatendimento.AutoSize = true;
            this.rbatendimento.Location = new System.Drawing.Point(51, 103);
            this.rbatendimento.Name = "rbatendimento";
            this.rbatendimento.Size = new System.Drawing.Size(84, 17);
            this.rbatendimento.TabIndex = 70;
            this.rbatendimento.TabStop = true;
            this.rbatendimento.Text = "Atendimento";
            this.rbatendimento.UseVisualStyleBackColor = true;
            // 
            // rbobito
            // 
            this.rbobito.AutoSize = true;
            this.rbobito.Location = new System.Drawing.Point(201, 103);
            this.rbobito.Name = "rbobito";
            this.rbobito.Size = new System.Drawing.Size(50, 17);
            this.rbobito.TabIndex = 70;
            this.rbobito.TabStop = true;
            this.rbobito.Text = "Óbito";
            this.rbobito.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(335, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 36);
            this.btnLimpar.TabIndex = 69;
            this.btnLimpar.Text = "Limpar Filtros";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // dtpPeriodoObito
            // 
            this.dtpPeriodoObito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoObito.Location = new System.Drawing.Point(176, 73);
            this.dtpPeriodoObito.Name = "dtpPeriodoObito";
            this.dtpPeriodoObito.Size = new System.Drawing.Size(119, 20);
            this.dtpPeriodoObito.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Médico";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbMedico2
            // 
            this.cbMedico2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMedico2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMedico2.FormattingEnabled = true;
            this.cbMedico2.Location = new System.Drawing.Point(306, 73);
            this.cbMedico2.Name = "cbMedico2";
            this.cbMedico2.Size = new System.Drawing.Size(118, 21);
            this.cbMedico2.TabIndex = 64;
            this.cbMedico2.SelectedIndexChanged += new System.EventHandler(this.cbMedico2_SelectedIndexChanged);
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodo.Location = new System.Drawing.Point(51, 73);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(119, 20);
            this.dtpPeriodo.TabIndex = 63;
            this.dtpPeriodo.Value = new System.DateTime(2019, 1, 1, 7, 44, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Período";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.AllowUserToAddRows = false;
            this.dgvAtendimentos.AllowUserToDeleteRows = false;
            this.dgvAtendimentos.AllowUserToResizeColumns = false;
            this.dgvAtendimentos.AllowUserToResizeRows = false;
            this.dgvAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoatn,
            this.codmed,
            this.cod_diag,
            this.cod_pac,
            this.anamnese,
            this.dtalta,
            this.dtretorno,
            this.causamortis,
            this.valorconta,
            this.valordesconto,
            this.nome,
            this.diagnostico,
            this.medico,
            this.fechada,
            this.status,
            this.dtatendimento,
            this.dtobito});
            this.dgvAtendimentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAtendimentos.Location = new System.Drawing.Point(3, 169);
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.ReadOnly = true;
            this.dgvAtendimentos.RowHeadersVisible = false;
            this.dgvAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendimentos.Size = new System.Drawing.Size(466, 263);
            this.dgvAtendimentos.TabIndex = 61;
            // 
            // codigoatn
            // 
            this.codigoatn.DataPropertyName = "atn_codigo";
            this.codigoatn.HeaderText = "Codigo";
            this.codigoatn.Name = "codigoatn";
            this.codigoatn.ReadOnly = true;
            this.codigoatn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigoatn.Visible = false;
            // 
            // codmed
            // 
            this.codmed.DataPropertyName = "med_codigo";
            this.codmed.HeaderText = "codmed";
            this.codmed.Name = "codmed";
            this.codmed.ReadOnly = true;
            this.codmed.Visible = false;
            // 
            // cod_diag
            // 
            this.cod_diag.DataPropertyName = "dia_codigo";
            this.cod_diag.HeaderText = "cod dia";
            this.cod_diag.Name = "cod_diag";
            this.cod_diag.ReadOnly = true;
            this.cod_diag.Visible = false;
            // 
            // cod_pac
            // 
            this.cod_pac.DataPropertyName = "pac_codigo";
            this.cod_pac.HeaderText = "cod paciente";
            this.cod_pac.Name = "cod_pac";
            this.cod_pac.ReadOnly = true;
            this.cod_pac.Visible = false;
            // 
            // anamnese
            // 
            this.anamnese.DataPropertyName = "atn_anamnese";
            this.anamnese.HeaderText = "Anamnese";
            this.anamnese.Name = "anamnese";
            this.anamnese.ReadOnly = true;
            this.anamnese.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.anamnese.Visible = false;
            // 
            // dtalta
            // 
            this.dtalta.DataPropertyName = "atn_dtalta";
            this.dtalta.HeaderText = "Data Alta";
            this.dtalta.Name = "dtalta";
            this.dtalta.ReadOnly = true;
            this.dtalta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtalta.Visible = false;
            // 
            // dtretorno
            // 
            this.dtretorno.DataPropertyName = "atn_dtretorno";
            this.dtretorno.HeaderText = "Data Retorno";
            this.dtretorno.Name = "dtretorno";
            this.dtretorno.ReadOnly = true;
            this.dtretorno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtretorno.Visible = false;
            // 
            // causamortis
            // 
            this.causamortis.DataPropertyName = "atn_causamortis";
            this.causamortis.HeaderText = "Causa da Morte";
            this.causamortis.Name = "causamortis";
            this.causamortis.ReadOnly = true;
            this.causamortis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.causamortis.Visible = false;
            // 
            // valorconta
            // 
            this.valorconta.DataPropertyName = "atn_vrconta";
            this.valorconta.HeaderText = "Valor da Conta";
            this.valorconta.Name = "valorconta";
            this.valorconta.ReadOnly = true;
            this.valorconta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valorconta.Visible = false;
            // 
            // valordesconto
            // 
            this.valordesconto.DataPropertyName = "atn_vrdesconto";
            this.valordesconto.HeaderText = "Valor do desconto";
            this.valordesconto.Name = "valordesconto";
            this.valordesconto.ReadOnly = true;
            this.valordesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valordesconto.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "pac_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // diagnostico
            // 
            this.diagnostico.DataPropertyName = "dia_descricao";
            this.diagnostico.HeaderText = "Diagnostico";
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.ReadOnly = true;
            this.diagnostico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // medico
            // 
            this.medico.DataPropertyName = "med_nome";
            this.medico.HeaderText = "Medico";
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            this.medico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechada
            // 
            this.fechada.DataPropertyName = "atn_contafechada";
            this.fechada.HeaderText = "Fechada";
            this.fechada.Name = "fechada";
            this.fechada.ReadOnly = true;
            this.fechada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fechada.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Visible = false;
            // 
            // dtatendimento
            // 
            this.dtatendimento.DataPropertyName = "atn_data";
            this.dtatendimento.HeaderText = "Data Atendimento";
            this.dtatendimento.Name = "dtatendimento";
            this.dtatendimento.ReadOnly = true;
            this.dtatendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtobito
            // 
            this.dtobito.DataPropertyName = "atn_dtobito";
            this.dtobito.HeaderText = "Data Óbito";
            this.dtobito.Name = "dtobito";
            this.dtobito.ReadOnly = true;
            this.dtobito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(51, 127);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 36);
            this.btnPesquisar.TabIndex = 60;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(240, 127);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 36);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(145, 127);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 36);
            this.btnAlterar.TabIndex = 58;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // tbPesqNomePac
            // 
            this.tbPesqNomePac.Location = new System.Drawing.Point(51, 28);
            this.tbPesqNomePac.MaxLength = 50;
            this.tbPesqNomePac.Name = "tbPesqNomePac";
            this.tbPesqNomePac.Size = new System.Drawing.Size(370, 20);
            this.tbPesqNomePac.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Nome do Paciente";
            // 
            // tabFechaAtt
            // 
            this.tabFechaAtt.BackColor = System.Drawing.Color.PowderBlue;
            this.tabFechaAtt.Controls.Add(this.gbPagamento);
            this.tabFechaAtt.Controls.Add(this.btSeleciona);
            this.tabFechaAtt.Controls.Add(this.dataGridView1);
            this.tabFechaAtt.Location = new System.Drawing.Point(4, 22);
            this.tabFechaAtt.Name = "tabFechaAtt";
            this.tabFechaAtt.Size = new System.Drawing.Size(472, 435);
            this.tabFechaAtt.TabIndex = 2;
            this.tabFechaAtt.Text = "Fechar Atendimento";
            // 
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.tbValorConta);
            this.gbPagamento.Controls.Add(this.label19);
            this.gbPagamento.Controls.Add(this.dtpDataComp);
            this.gbPagamento.Controls.Add(this.label18);
            this.gbPagamento.Controls.Add(this.tbCheque);
            this.gbPagamento.Controls.Add(this.label17);
            this.gbPagamento.Controls.Add(this.tbValorPg);
            this.gbPagamento.Controls.Add(this.label16);
            this.gbPagamento.Controls.Add(this.tbParcela);
            this.gbPagamento.Controls.Add(this.label15);
            this.gbPagamento.Location = new System.Drawing.Point(3, 3);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(461, 113);
            this.gbPagamento.TabIndex = 2;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Pagamento";
            // 
            // tbValorConta
            // 
            this.tbValorConta.Enabled = false;
            this.tbValorConta.Location = new System.Drawing.Point(372, 82);
            this.tbValorConta.Mask = "$";
            this.tbValorConta.Name = "tbValorConta";
            this.tbValorConta.Size = new System.Drawing.Size(83, 20);
            this.tbValorConta.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(368, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Valor da Conta";
            // 
            // dtpDataComp
            // 
            this.dtpDataComp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataComp.Location = new System.Drawing.Point(232, 81);
            this.dtpDataComp.Name = "dtpDataComp";
            this.dtpDataComp.Size = new System.Drawing.Size(133, 20);
            this.dtpDataComp.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Data de Compensação";
            // 
            // tbCheque
            // 
            this.tbCheque.Location = new System.Drawing.Point(97, 81);
            this.tbCheque.Name = "tbCheque";
            this.tbCheque.Size = new System.Drawing.Size(129, 20);
            this.tbCheque.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(94, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cheque";
            // 
            // tbValorPg
            // 
            this.tbValorPg.Location = new System.Drawing.Point(10, 82);
            this.tbValorPg.Mask = "0000000";
            this.tbValorPg.Name = "tbValorPg";
            this.tbValorPg.Size = new System.Drawing.Size(77, 20);
            this.tbValorPg.TabIndex = 3;
            this.tbValorPg.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Valor";
            // 
            // tbParcela
            // 
            this.tbParcela.Enabled = false;
            this.tbParcela.Location = new System.Drawing.Point(10, 37);
            this.tbParcela.Name = "tbParcela";
            this.tbParcela.Size = new System.Drawing.Size(56, 20);
            this.tbParcela.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Parcela";
            // 
            // btSeleciona
            // 
            this.btSeleciona.BackColor = System.Drawing.Color.White;
            this.btSeleciona.Image = ((System.Drawing.Image)(resources.GetObject("btSeleciona.Image")));
            this.btSeleciona.Location = new System.Drawing.Point(323, 122);
            this.btSeleciona.Name = "btSeleciona";
            this.btSeleciona.Size = new System.Drawing.Size(141, 23);
            this.btSeleciona.TabIndex = 1;
            this.btSeleciona.Text = "Selecionar Paciente";
            this.btSeleciona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSeleciona.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(472, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "pro_codigo";
            this.codigo.FillWeight = 20F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // procedimento
            // 
            this.procedimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procedimento.DataPropertyName = "pro_descricao";
            this.procedimento.HeaderText = "Procedimento";
            this.procedimento.Name = "procedimento";
            this.procedimento.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "con_data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qtde.DataPropertyName = "con_qtde";
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 55;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.valor.DataPropertyName = "pro_valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 56;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.total.DataPropertyName = "pro_total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // TelaAtendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAtendimentos";
            this.Text = "Gerenciar Atendimentos";
            this.Load += new System.EventHandler(this.TelaAtendimentos_Load);
            this.panel2.ResumeLayout(false);
            this.tabsatendimento.ResumeLayout(false);
            this.painel.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.gbConta.ResumeLayout(false);
            this.gbConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimentos)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.tabFechaAtt.ResumeLayout(false);
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabsatendimento;
        private System.Windows.Forms.TabPage painel;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.DataGridView dgvAtendimentos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbPesqNomePac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cbDiagnostico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAtendimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAnamnese;
        private System.Windows.Forms.DateTimePicker dtpPeriodoObito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMedico2;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TabPage tabFechaAtt;
		private System.Windows.Forms.Button btSeleciona;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox gbConta;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpDataConta;
		private System.Windows.Forms.ComboBox cbProcede;
		private System.Windows.Forms.DataGridView dgvProcedimentos;
		private System.Windows.Forms.Button btRemover;
		private System.Windows.Forms.MaskedTextBox tbValor;
		private System.Windows.Forms.MaskedTextBox tbQtde;
		private System.Windows.Forms.GroupBox gbPagamento;
		private System.Windows.Forms.MaskedTextBox tbValorConta;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dtpDataComp;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tbCheque;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.MaskedTextBox tbValorPg;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox tbParcela;
		private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbatendimento;
        private System.Windows.Forms.RadioButton rbobito;
        private System.Windows.Forms.Label lblaltaobito;
        private System.Windows.Forms.DateTimePicker dtpaltaobito;
        private System.Windows.Forms.Label lblcausamorte;
        private System.Windows.Forms.TextBox tbcausamorte;
        private System.Windows.Forms.Label lblretorno;
        private System.Windows.Forms.DateTimePicker dtpretorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoatn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_diag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn anamnese;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtalta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtretorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn causamortis;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechada;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtatendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtobito;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}