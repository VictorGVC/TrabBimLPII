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

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			char sexo;
            if(tbCodigo.Text == "")
            {

            }
            else if(tbNome.Text == "")
            {

            }
            else if(cbSexo.Text == "")
            {

            }
            else if(tbEndereco.Text == "")
            {

            }
            else if(tbCidade.Text == "")
            {

            }
            else if(cbUF.Text == "")
            {

            }
            else if(tbCep.Text == "")
            {

            }
            else if(tbTelefone.Text == "")
            {

            }
            else
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
		}

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
