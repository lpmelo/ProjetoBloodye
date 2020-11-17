using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBloodye.Pages.adm.ChildForms
{
    public partial class FormPD : Form
    {
        public FormPD()
        {
            InitializeComponent();
            tbPesTS.Visible = false;
            tbPesNome.Visible = false;
            tbPesCPF.Visible = false;
            lbTS.Visible = false; 
            lbNome.Visible = false;
            lbCPF.Visible = false;
        }

        private void cbEscolhaPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCB.Visible = false;
            if (cbEscolhaPD.SelectedIndex == 0)
            {
                tbPesTS.Visible = true;
                lbTS.Visible = true;
            }
            else
            {
                tbPesTS.Text = "";
                tbPesTS.Visible = false;
                lbTS.Visible = false;
            }
            if (cbEscolhaPD.SelectedIndex == 1)
            {
                tbPesNome.Visible = true;
                lbNome.Visible = true;
            }
            else
            {
                tbPesNome.Text = "";
                tbPesNome.Visible = false;
                lbNome.Visible = false;
            }

            if (cbEscolhaPD.SelectedIndex == 2)
            {
                tbPesCPF.Visible = true;
                lbCPF.Visible = true;
            }
            else
            {
                tbPesCPF.Text = "";
                tbPesCPF.Visible = false;
                lbCPF.Visible = false;
            }

            string v = tbPesTS.Text;

        }

    }
}
