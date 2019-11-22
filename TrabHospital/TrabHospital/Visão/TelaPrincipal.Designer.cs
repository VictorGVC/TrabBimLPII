namespace TrabHospital
{
	partial class TelaPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.atendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.atendimentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlImage = new System.Windows.Forms.Panel();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.btnRelatorios = new System.Windows.Forms.Button();
			this.btnAtendimentos = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPacientes = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PacientesToolStripMenuItem,
            this.atendimentosToolStripMenuItem});
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.cadastrosToolStripMenuItem.Text = "Gerenciamentos";
			// 
			// PacientesToolStripMenuItem
			// 
			this.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem";
			this.PacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.PacientesToolStripMenuItem.Text = "Pacientes";
			this.PacientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
			// 
			// atendimentosToolStripMenuItem
			// 
			this.atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
			this.atendimentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.atendimentosToolStripMenuItem.Text = "Atendimentos";
			this.atendimentosToolStripMenuItem.Click += new System.EventHandler(this.AtendimentosToolStripMenuItem_Click);
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem1,
            this.atendimentosToolStripMenuItem1});
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.relatóriosToolStripMenuItem.Text = "Relatórios";
			// 
			// pacientesToolStripMenuItem1
			// 
			this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
			this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.pacientesToolStripMenuItem1.Text = "Pacientes";
			this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.PacientesToolStripMenuItem1_Click);
			// 
			// atendimentosToolStripMenuItem1
			// 
			this.atendimentosToolStripMenuItem1.Name = "atendimentosToolStripMenuItem1";
			this.atendimentosToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
			this.atendimentosToolStripMenuItem1.Text = "Atendimentos";
			this.atendimentosToolStripMenuItem1.Click += new System.EventHandler(this.AtendimentosToolStripMenuItem1_Click);
			// 
			// pnlImage
			// 
			this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
			this.pnlImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImage.BackgroundImage")));
			this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlImage.Location = new System.Drawing.Point(0, 24);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(390, 461);
			this.pnlImage.TabIndex = 2;
			// 
			// pnlButtons
			// 
			this.pnlButtons.BackColor = System.Drawing.Color.PowderBlue;
			this.pnlButtons.Controls.Add(this.btnRelatorios);
			this.pnlButtons.Controls.Add(this.btnAtendimentos);
			this.pnlButtons.Controls.Add(this.label1);
			this.pnlButtons.Controls.Add(this.btnPacientes);
			this.pnlButtons.Controls.Add(this.btnFechar);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlButtons.Location = new System.Drawing.Point(394, 24);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(390, 461);
			this.pnlButtons.TabIndex = 3;
			// 
			// btnRelatorios
			// 
			this.btnRelatorios.BackColor = System.Drawing.Color.White;
			this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
			this.btnRelatorios.Location = new System.Drawing.Point(143, 302);
			this.btnRelatorios.Name = "btnRelatorios";
			this.btnRelatorios.Size = new System.Drawing.Size(106, 40);
			this.btnRelatorios.TabIndex = 4;
			this.btnRelatorios.Text = "Relatórios";
			this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRelatorios.UseVisualStyleBackColor = false;
			this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
			// 
			// btnAtendimentos
			// 
			this.btnAtendimentos.BackColor = System.Drawing.Color.White;
			this.btnAtendimentos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAtendimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendimentos.Image")));
			this.btnAtendimentos.Location = new System.Drawing.Point(143, 256);
			this.btnAtendimentos.Name = "btnAtendimentos";
			this.btnAtendimentos.Size = new System.Drawing.Size(106, 40);
			this.btnAtendimentos.TabIndex = 3;
			this.btnAtendimentos.Text = "Gerenciar Atendimentos";
			this.btnAtendimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAtendimentos.UseVisualStyleBackColor = false;
			this.btnAtendimentos.Click += new System.EventHandler(this.BtnAtendimentos_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 42);
			this.label1.TabIndex = 20;
			this.label1.Text = "Controle Hospitalar";
			// 
			// btnPacientes
			// 
			this.btnPacientes.BackColor = System.Drawing.Color.White;
			this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
			this.btnPacientes.Location = new System.Drawing.Point(143, 210);
			this.btnPacientes.Name = "btnPacientes";
			this.btnPacientes.Size = new System.Drawing.Size(106, 40);
			this.btnPacientes.TabIndex = 2;
			this.btnPacientes.Text = "Gerenciar Pacientes";
			this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPacientes.UseVisualStyleBackColor = false;
			this.btnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.BackColor = System.Drawing.Color.White;
			this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
			this.btnFechar.Location = new System.Drawing.Point(143, 409);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(106, 40);
			this.btnFechar.TabIndex = 1;
			this.btnFechar.Text = " Fechar";
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 485);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.pnlImage);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaPrincipal";
			this.Text = "Atendimentos Hospitalares ";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.pnlButtons.ResumeLayout(false);
			this.pnlButtons.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PacientesToolStripMenuItem;
		private System.Windows.Forms.Panel pnlImage;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Button btnPacientes;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAtendimentos;
		private System.Windows.Forms.ToolStripMenuItem atendimentosToolStripMenuItem;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem atendimentosToolStripMenuItem1;
	}
}

