namespace TrabHospital.Visão
{
	partial class TelaRelatórios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatórios));
			this.tabs = new System.Windows.Forms.TabControl();
			this.tbPacientes = new System.Windows.Forms.TabPage();
			this.tabAtendimento = new System.Windows.Forms.TabPage();
			this.dgvPacientes = new System.Windows.Forms.DataGridView();
			this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
			this.tabs.SuspendLayout();
			this.tbPacientes.SuspendLayout();
			this.tabAtendimento.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tbPacientes);
			this.tabs.Controls.Add(this.tabAtendimento);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(784, 461);
			this.tabs.TabIndex = 0;
			// 
			// tbPacientes
			// 
			this.tbPacientes.Controls.Add(this.dgvPacientes);
			this.tbPacientes.Location = new System.Drawing.Point(4, 22);
			this.tbPacientes.Name = "tbPacientes";
			this.tbPacientes.Padding = new System.Windows.Forms.Padding(3);
			this.tbPacientes.Size = new System.Drawing.Size(776, 435);
			this.tbPacientes.TabIndex = 0;
			this.tbPacientes.Text = "Pacientes";
			this.tbPacientes.UseVisualStyleBackColor = true;
			// 
			// tabAtendimento
			// 
			this.tabAtendimento.Controls.Add(this.dgvAtendimentos);
			this.tabAtendimento.Location = new System.Drawing.Point(4, 22);
			this.tabAtendimento.Name = "tabAtendimento";
			this.tabAtendimento.Padding = new System.Windows.Forms.Padding(3);
			this.tabAtendimento.Size = new System.Drawing.Size(776, 435);
			this.tabAtendimento.TabIndex = 1;
			this.tabAtendimento.Text = "Atendimentos";
			this.tabAtendimento.UseVisualStyleBackColor = true;
			// 
			// dgvPacientes
			// 
			this.dgvPacientes.AllowUserToAddRows = false;
			this.dgvPacientes.AllowUserToDeleteRows = false;
			this.dgvPacientes.BackgroundColor = System.Drawing.Color.PowderBlue;
			this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPacientes.Location = new System.Drawing.Point(3, 3);
			this.dgvPacientes.Name = "dgvPacientes";
			this.dgvPacientes.ReadOnly = true;
			this.dgvPacientes.Size = new System.Drawing.Size(770, 429);
			this.dgvPacientes.TabIndex = 0;
			// 
			// dgvAtendimentos
			// 
			this.dgvAtendimentos.AllowUserToAddRows = false;
			this.dgvAtendimentos.AllowUserToDeleteRows = false;
			this.dgvAtendimentos.BackgroundColor = System.Drawing.Color.PowderBlue;
			this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAtendimentos.Location = new System.Drawing.Point(3, 3);
			this.dgvAtendimentos.Name = "dgvAtendimentos";
			this.dgvAtendimentos.ReadOnly = true;
			this.dgvAtendimentos.Size = new System.Drawing.Size(770, 429);
			this.dgvAtendimentos.TabIndex = 0;
			// 
			// TelaRelatórios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tabs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaRelatórios";
			this.Text = "Relatórios";
			this.tabs.ResumeLayout(false);
			this.tbPacientes.ResumeLayout(false);
			this.tabAtendimento.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tbPacientes;
		private System.Windows.Forms.TabPage tabAtendimento;
		private System.Windows.Forms.DataGridView dgvPacientes;
		private System.Windows.Forms.DataGridView dgvAtendimentos;
	}
}