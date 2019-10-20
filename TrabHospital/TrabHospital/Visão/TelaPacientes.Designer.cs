namespace TrabHospital.Visão
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.tbCidade = new System.Windows.Forms.TextBox();
			this.tbTelefone = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.tbEndereco = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbCep = new System.Windows.Forms.TextBox();
			this.tbUf = new System.Windows.Forms.TextBox();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgvPacientes = new System.Windows.Forms.DataGridView();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.tbPesqNome = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(549, 346);
			this.tabControl1.TabIndex = 35;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.dtpNascimento);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.tbCidade);
			this.tabPage1.Controls.Add(this.tbTelefone);
			this.tabPage1.Controls.Add(this.tbNome);
			this.tabPage1.Controls.Add(this.tbEndereco);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.tbCep);
			this.tabPage1.Controls.Add(this.tbUf);
			this.tabPage1.Controls.Add(this.tbCodigo);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(541, 320);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cadastro";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Maculino",
            "Feminino"});
			this.comboBox1.Location = new System.Drawing.Point(21, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(86, 21);
			this.comboBox1.TabIndex = 50;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 49;
			this.label6.Text = "Sexo";
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNascimento.Location = new System.Drawing.Point(113, 74);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
			this.dtpNascimento.TabIndex = 43;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnNovo);
			this.panel1.Controls.Add(this.btnSalvar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(535, 41);
			this.panel1.TabIndex = 48;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(443, 8);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(82, 23);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnNovo
			// 
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNovo.Location = new System.Drawing.Point(267, 8);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(82, 23);
			this.btnNovo.TabIndex = 9;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(355, 8);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(82, 23);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
			// 
			// tbCidade
			// 
			this.tbCidade.Location = new System.Drawing.Point(21, 112);
			this.tbCidade.Name = "tbCidade";
			this.tbCidade.Size = new System.Drawing.Size(209, 20);
			this.tbCidade.TabIndex = 45;
			// 
			// tbTelefone
			// 
			this.tbTelefone.Location = new System.Drawing.Point(356, 112);
			this.tbTelefone.Name = "tbTelefone";
			this.tbTelefone.Size = new System.Drawing.Size(172, 20);
			this.tbTelefone.TabIndex = 45;
			// 
			// tbNome
			// 
			this.tbNome.Location = new System.Drawing.Point(113, 37);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(415, 20);
			this.tbNome.TabIndex = 42;
			// 
			// tbEndereco
			// 
			this.tbEndereco.Location = new System.Drawing.Point(227, 73);
			this.tbEndereco.Name = "tbEndereco";
			this.tbEndereco.Size = new System.Drawing.Size(301, 20);
			this.tbEndereco.TabIndex = 41;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 38;
			this.label7.Text = "Cidade";
			// 
			// tbCep
			// 
			this.tbCep.Location = new System.Drawing.Point(264, 112);
			this.tbCep.Name = "tbCep";
			this.tbCep.Size = new System.Drawing.Size(86, 20);
			this.tbCep.TabIndex = 41;
			// 
			// tbUf
			// 
			this.tbUf.Location = new System.Drawing.Point(236, 112);
			this.tbUf.Name = "tbUf";
			this.tbUf.Size = new System.Drawing.Size(22, 20);
			this.tbUf.TabIndex = 41;
			this.tbUf.Text = "SP";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Location = new System.Drawing.Point(21, 37);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(86, 20);
			this.tbCodigo.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(353, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 38;
			this.label5.Text = "Telefone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(110, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Dt. Nascimento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Endereço";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 35;
			this.label2.Text = "Nome do Paciente";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(266, 95);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(28, 13);
			this.label10.TabIndex = 34;
			this.label10.Text = "CEP";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(233, 95);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 13);
			this.label9.TabIndex = 34;
			this.label9.Text = "UF";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 34;
			this.label1.Text = "Código";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgvPacientes);
			this.tabPage2.Controls.Add(this.btnPesquisar);
			this.tabPage2.Controls.Add(this.btnExcluir);
			this.tabPage2.Controls.Add(this.btnAlterar);
			this.tabPage2.Controls.Add(this.tbPesqNome);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(541, 320);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pesquisa";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dgvPacientes
			// 
			this.dgvPacientes.AllowUserToAddRows = false;
			this.dgvPacientes.AllowUserToDeleteRows = false;
			this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvPacientes.Location = new System.Drawing.Point(3, 62);
			this.dgvPacientes.Name = "dgvPacientes";
			this.dgvPacientes.ReadOnly = true;
			this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPacientes.Size = new System.Drawing.Size(535, 255);
			this.dgvPacientes.TabIndex = 61;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPesquisar.Location = new System.Drawing.Point(243, 26);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(89, 23);
			this.btnPesquisar.TabIndex = 60;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(434, 26);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(89, 23);
			this.btnExcluir.TabIndex = 59;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(338, 26);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(89, 23);
			this.btnAlterar.TabIndex = 58;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// tbPesqNome
			// 
			this.tbPesqNome.Location = new System.Drawing.Point(17, 29);
			this.tbPesqNome.Name = "tbPesqNome";
			this.tbPesqNome.Size = new System.Drawing.Size(216, 20);
			this.tbPesqNome.TabIndex = 57;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 13);
			this.label8.TabIndex = 56;
			this.label8.Text = "Nome do Paciente";
			// 
			// TelaPacientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 346);
			this.Controls.Add(this.tabControl1);
			this.Name = "TelaPacientes";
			this.Text = "Cadastro de Pacientes";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox tbTelefone;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dgvPacientes;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.TextBox tbPesqNome;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbCidade;
		private System.Windows.Forms.TextBox tbEndereco;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbCep;
		private System.Windows.Forms.TextBox tbUf;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}