﻿namespace TrabHospital.Visão
{
	partial class TelaPacientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPacientes));
			this.pnlFuncoes = new System.Windows.Forms.Panel();
			this.tabs = new System.Windows.Forms.TabControl();
			this.painel = new System.Windows.Forms.TabPage();
			this.pnDados = new System.Windows.Forms.Panel();
			this.tbCep = new System.Windows.Forms.MaskedTextBox();
			this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbPlano = new System.Windows.Forms.ComboBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.cbUF = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSexo = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCidade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlBotoes = new System.Windows.Forms.Panel();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tabPesquisa = new System.Windows.Forms.TabPage();
			this.dgvPacientes = new System.Windows.Forms.DataGridView();
			this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plano_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cep_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.tbPesqNome = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pnlImage = new System.Windows.Forms.Panel();
			this.pnlFuncoes.SuspendLayout();
			this.tabs.SuspendLayout();
			this.painel.SuspendLayout();
			this.pnDados.SuspendLayout();
			this.pnlBotoes.SuspendLayout();
			this.tabPesquisa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlFuncoes
			// 
			this.pnlFuncoes.Controls.Add(this.tabs);
			this.pnlFuncoes.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlFuncoes.Location = new System.Drawing.Point(304, 0);
			this.pnlFuncoes.Name = "pnlFuncoes";
			this.pnlFuncoes.Size = new System.Drawing.Size(480, 461);
			this.pnlFuncoes.TabIndex = 0;
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.painel);
			this.tabs.Controls.Add(this.tabPesquisa);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(480, 461);
			this.tabs.TabIndex = 36;
			this.tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
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
			this.pnDados.Controls.Add(this.tbCep);
			this.pnDados.Controls.Add(this.tbTelefone);
			this.pnDados.Controls.Add(this.label11);
			this.pnDados.Controls.Add(this.cbPlano);
			this.pnDados.Controls.Add(this.tbNome);
			this.pnDados.Controls.Add(this.cbUF);
			this.pnDados.Controls.Add(this.label1);
			this.pnDados.Controls.Add(this.cbSexo);
			this.pnDados.Controls.Add(this.label9);
			this.pnDados.Controls.Add(this.label6);
			this.pnDados.Controls.Add(this.label10);
			this.pnDados.Controls.Add(this.dtpNascimento);
			this.pnDados.Controls.Add(this.label2);
			this.pnDados.Controls.Add(this.label4);
			this.pnDados.Controls.Add(this.tbCidade);
			this.pnDados.Controls.Add(this.label3);
			this.pnDados.Controls.Add(this.label5);
			this.pnDados.Controls.Add(this.tbCodigo);
			this.pnDados.Controls.Add(this.tbEndereco);
			this.pnDados.Controls.Add(this.label7);
			this.pnDados.Enabled = false;
			this.pnDados.Location = new System.Drawing.Point(6, 6);
			this.pnDados.Name = "pnDados";
			this.pnDados.Size = new System.Drawing.Size(458, 379);
			this.pnDados.TabIndex = 52;
			// 
			// tbCep
			// 
			this.tbCep.Location = new System.Drawing.Point(369, 182);
			this.tbCep.Mask = "00000-000";
			this.tbCep.Name = "tbCep";
			this.tbCep.Size = new System.Drawing.Size(85, 20);
			this.tbCep.TabIndex = 55;
			// 
			// tbTelefone
			// 
			this.tbTelefone.Location = new System.Drawing.Point(310, 61);
			this.tbTelefone.Mask = "(99) 00000-0000";
			this.tbTelefone.Name = "tbTelefone";
			this.tbTelefone.Size = new System.Drawing.Size(145, 20);
			this.tbTelefone.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(197, 84);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 13);
			this.label11.TabIndex = 53;
			this.label11.Text = "Plano de saúde";
			// 
			// cbPlano
			// 
			this.cbPlano.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbPlano.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbPlano.FormattingEnabled = true;
			this.cbPlano.Location = new System.Drawing.Point(199, 100);
			this.cbPlano.Name = "cbPlano";
			this.cbPlano.Size = new System.Drawing.Size(145, 21);
			this.cbPlano.TabIndex = 6;
			// 
			// tbNome
			// 
			this.tbNome.Location = new System.Drawing.Point(4, 61);
			this.tbNome.MaxLength = 50;
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(300, 20);
			this.tbNome.TabIndex = 2;
			// 
			// cbUF
			// 
			this.cbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbUF.FormattingEnabled = true;
			this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO",
            ""});
			this.cbUF.Location = new System.Drawing.Point(310, 182);
			this.cbUF.Name = "cbUF";
			this.cbUF.Size = new System.Drawing.Size(53, 21);
			this.cbUF.TabIndex = 9;
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
			// cbSexo
			// 
			this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.Items.AddRange(new object[] {
            "Maculino",
            "Feminino"});
			this.cbSexo.Location = new System.Drawing.Point(5, 100);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(86, 21);
			this.cbSexo.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(307, 167);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 13);
			this.label9.TabIndex = 34;
			this.label9.Text = "UF";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 49;
			this.label6.Text = "Sexo";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(366, 166);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(28, 13);
			this.label10.TabIndex = 34;
			this.label10.Text = "CEP";
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNascimento.Location = new System.Drawing.Point(97, 101);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(96, 20);
			this.dtpNascimento.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 35;
			this.label2.Text = "Nome do Paciente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Endereço";
			// 
			// tbCidade
			// 
			this.tbCidade.Location = new System.Drawing.Point(5, 182);
			this.tbCidade.MaxLength = 40;
			this.tbCidade.Name = "tbCidade";
			this.tbCidade.Size = new System.Drawing.Size(299, 20);
			this.tbCidade.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(94, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Dt. Nascimento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(307, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 38;
			this.label5.Text = "Telefone";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Enabled = false;
			this.tbCodigo.Location = new System.Drawing.Point(4, 24);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(86, 20);
			this.tbCodigo.TabIndex = 1;
			// 
			// tbEndereco
			// 
			this.tbEndereco.Location = new System.Drawing.Point(5, 142);
			this.tbEndereco.MaxLength = 60;
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(450, 20);
			this.tbEndereco.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 38;
			this.label7.Text = "Cidade";
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
			this.tabPesquisa.Controls.Add(this.dgvPacientes);
			this.tabPesquisa.Controls.Add(this.btnPesquisar);
			this.tabPesquisa.Controls.Add(this.btnExcluir);
			this.tabPesquisa.Controls.Add(this.btnAlterar);
			this.tabPesquisa.Controls.Add(this.tbPesqNome);
			this.tabPesquisa.Controls.Add(this.label8);
			this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
			this.tabPesquisa.Name = "tabPesquisa";
			this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
			this.tabPesquisa.Size = new System.Drawing.Size(472, 435);
			this.tabPesquisa.TabIndex = 1;
			this.tabPesquisa.Text = "Pesquisa";
			// 
			// dgvPacientes
			// 
			this.dgvPacientes.AllowUserToAddRows = false;
			this.dgvPacientes.AllowUserToDeleteRows = false;
			this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
			this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nome_pac,
            this.sexo,
            this.fone,
            this.nasc,
            this.plano_pac,
            this.endereco,
            this.cidade,
            this.cep_pac,
            this.uf});
			this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvPacientes.Location = new System.Drawing.Point(3, 116);
			this.dgvPacientes.Name = "dgvPacientes";
			this.dgvPacientes.ReadOnly = true;
			this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPacientes.Size = new System.Drawing.Size(466, 316);
			this.dgvPacientes.TabIndex = 61;
			// 
			// cod
			// 
			this.cod.DataPropertyName = "pac_codigo";
			this.cod.HeaderText = "Codigo";
			this.cod.Name = "cod";
			this.cod.ReadOnly = true;
			this.cod.Width = 50;
			// 
			// nome_pac
			// 
			this.nome_pac.DataPropertyName = "pac_nome";
			this.nome_pac.HeaderText = "Nome";
			this.nome_pac.Name = "nome_pac";
			this.nome_pac.ReadOnly = true;
			this.nome_pac.Width = 200;
			// 
			// sexo
			// 
			this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.sexo.DataPropertyName = "pac_sexo";
			this.sexo.HeaderText = "Sexo";
			this.sexo.Name = "sexo";
			this.sexo.ReadOnly = true;
			this.sexo.Width = 40;
			// 
			// fone
			// 
			this.fone.DataPropertyName = "pac_fone";
			this.fone.HeaderText = "Telefone";
			this.fone.Name = "fone";
			this.fone.ReadOnly = true;
			// 
			// nasc
			// 
			this.nasc.DataPropertyName = "pac_dtnasc";
			this.nasc.HeaderText = "Data Nascimento";
			this.nasc.Name = "nasc";
			this.nasc.ReadOnly = true;
			// 
			// plano_pac
			// 
			this.plano_pac.DataPropertyName = "pla_nome";
			this.plano_pac.HeaderText = "Convênio";
			this.plano_pac.Name = "plano_pac";
			this.plano_pac.ReadOnly = true;
			this.plano_pac.Width = 150;
			// 
			// endereco
			// 
			this.endereco.DataPropertyName = "pac_endereco";
			this.endereco.HeaderText = "Endereco";
			this.endereco.Name = "endereco";
			this.endereco.ReadOnly = true;
			this.endereco.Width = 200;
			// 
			// cidade
			// 
			this.cidade.DataPropertyName = "pac_cidade";
			this.cidade.HeaderText = "Cidade";
			this.cidade.Name = "cidade";
			this.cidade.ReadOnly = true;
			// 
			// cep_pac
			// 
			this.cep_pac.DataPropertyName = "pac_cep";
			this.cep_pac.HeaderText = "CEP";
			this.cep_pac.Name = "cep_pac";
			this.cep_pac.ReadOnly = true;
			this.cep_pac.Width = 80;
			// 
			// uf
			// 
			this.uf.DataPropertyName = "pac_uf";
			this.uf.HeaderText = "UF";
			this.uf.Name = "uf";
			this.uf.ReadOnly = true;
			this.uf.Width = 40;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.White;
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
			this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPesquisar.Location = new System.Drawing.Point(52, 60);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(89, 36);
			this.btnPesquisar.TabIndex = 60;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.White;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(333, 60);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(89, 36);
			this.btnExcluir.TabIndex = 59;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.White;
			this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(197, 60);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(89, 36);
			this.btnAlterar.TabIndex = 58;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
			// 
			// tbPesqNome
			// 
			this.tbPesqNome.Location = new System.Drawing.Point(52, 34);
			this.tbPesqNome.MaxLength = 50;
			this.tbPesqNome.Name = "tbPesqNome";
			this.tbPesqNome.Size = new System.Drawing.Size(370, 20);
			this.tbPesqNome.TabIndex = 57;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(52, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 13);
			this.label8.TabIndex = 56;
			this.label8.Text = "Nome do Paciente";
			// 
			// pnlImage
			// 
			this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
			this.pnlImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImage.BackgroundImage")));
			this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlImage.Location = new System.Drawing.Point(0, 0);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(300, 461);
			this.pnlImage.TabIndex = 3;
			// 
			// TelaPacientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.pnlImage);
			this.Controls.Add(this.pnlFuncoes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaPacientes";
			this.Text = "Gerenciar Pacientes";
			this.Load += new System.EventHandler(this.TelaPacientes_Load);
			this.pnlFuncoes.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.painel.ResumeLayout(false);
			this.pnDados.ResumeLayout(false);
			this.pnDados.PerformLayout();
			this.pnlBotoes.ResumeLayout(false);
			this.tabPesquisa.ResumeLayout(false);
			this.tabPesquisa.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlFuncoes;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage painel;
		private System.Windows.Forms.Panel pnDados;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbPlano;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.ComboBox cbUF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.TextBox tbEndereco;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnlBotoes;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TabPage tabPesquisa;
		private System.Windows.Forms.DataGridView dgvPacientes;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.TextBox tbPesqNome;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel pnlImage;
		private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn plano_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
		private System.Windows.Forms.MaskedTextBox tbTelefone;
		private System.Windows.Forms.MaskedTextBox tbCep;
	}
}