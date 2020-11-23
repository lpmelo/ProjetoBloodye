using ProjetoBloodye.cbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBloodye.Pages.adm.ChildForms
{
    public partial class FormPD : Form
    {
        Comandos co = new Comandos();
        public FormPD()
        {
            InitializeComponent();
            cbTS.Visible = false;
            tbPesNome.Visible = false;
            tbPesCPF.Visible = false;
            lbTS.Visible = false; 
            lbNome.Visible = false;
            lbCPF.Visible = false;
            btnProcurar.Visible = false;
        }

        private void cbEscolhaPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCB.Visible = false;
            if (cbEscolhaPD.SelectedIndex == 0)
            {
                cbTS.Visible = true;
                lbTS.Visible = true;
                btnProcurar.Visible = true;
            }
            else
            {
                cbTS.Text = "";
                cbTS.Visible = false;
                lbTS.Visible = false;
            }
            if (cbEscolhaPD.SelectedIndex == 1)
            {
                tbPesNome.Visible = true;
                lbNome.Visible = true;
                btnProcurar.Visible = true;
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
                btnProcurar.Visible = true;
            }
            else
            {
                tbPesCPF.Text = "";
                tbPesCPF.Visible = false;
                lbCPF.Visible = false;
            }

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string indexstring = cbEscolhaPD.SelectedIndex.ToString();
            string index = null;
            string searchstring = null;
            if (indexstring.Equals("0"))
            {
                index = "TIPOSANGUE";
                searchstring = cbTS.Text;
            }
            if (indexstring.Equals("1"))
            {
                index = "NOME";
                searchstring = tbPesNome.Text;
            }
            if (indexstring.Equals("2"))
            {
                index = "CPF";
                searchstring = tbPesCPF.Text;
            }

            if (cbTS.Visible == true || tbPesNome.Visible == true || tbPesCPF.Visible == true)
            {
                try
                {
                    string local = "bd/Administradores.accdb";
                    string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();
                    co.conectado = true;
                    co.Procurar(searchstring, index, conn);
                    conn.Close();

                }
                catch (Exception erro)
                {
                    co.conectado = false;
                    MessageBox.Show(erro.Message);
                }


            }
        }
    }
}
