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
    public partial class FormCH : Form
    {
        Comandos co = new Comandos();
        public FormCH()
        {
            InitializeComponent();
            cbUF.Visible = false;
            tbPesCidade.Visible = false;
            tbPesCNPJ.Visible = false;
            tbPesNome.Visible = false;
            lbUF.Visible = false;
            lbCidade.Visible = false;
            lbCNPJ.Visible = false;
            lbNome.Visible = false;
            btnProcurar.Visible = false;
            dataGridView1.Visible = false;
        }

        private void preencheCbHemocentro()
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                string Query = "SELECT UF FROM Hemocentros GROUP BY UF";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                OleDbCommand cm = new OleDbCommand(Query, conn);
                OleDbDataReader reader = cm.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();
                row["UF"] = "Escolha";
                table.Rows.InsertAt(row, 0);
                this.cbUF.DataSource = table;
                this.cbUF.ValueMember = "UF";
                this.cbUF.DisplayMember = "UF";
                reader.Close();
                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FormCH_Load(object sender, EventArgs e)
        {
            preencheCbHemocentro();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string indexstring = cbEscolhaPD.SelectedIndex.ToString();
            string index = null;
            string searchstring = null;
            if (indexstring.Equals("0"))
            {
                index = "UF";
                searchstring = cbUF.Text;
            }
            if (indexstring.Equals("1"))
            {
                index = "NOME";
                searchstring = tbPesNome.Text;
            }
            if (indexstring.Equals("2"))
            {
                index = "CIDADE";
                searchstring = tbPesCidade.Text;
            }
            if (indexstring.Equals("3"))
            {
                index = "CNPJ";
                searchstring = tbPesCNPJ.Text;
            }

            if (cbUF.Visible == true || tbPesCidade.Visible == true || tbPesCNPJ.Visible == true || tbPesNome.Visible == true)
            {
                dataGridView1.Visible = true;
                try
                {
                    string local = "bd/Administradores.accdb";
                    string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();
                    co.conectado = true;
                    co.ProcurarContatoH(searchstring, index, conn, dataGridView1);
                    conn.Close();

                }
                catch (Exception erro)
                {
                    co.conectado = false;
                    MessageBox.Show(erro.Message);
                }


            }
        }

        private void cbEscolhaPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCB.Visible = false;
            if (cbEscolhaPD.SelectedIndex == 0)
            {
                cbUF.Visible = true;
                lbUF.Visible = true;
                btnProcurar.Visible = true;
            }
            else
            {
                cbUF.Text = "";
                cbUF.Visible = false;
                lbUF.Visible = false;
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
                tbPesCidade.Visible = true;
                lbCidade.Visible = true;
                btnProcurar.Visible = true;
            }
            else
            {
                tbPesCidade.Text = "";
                tbPesCidade.Visible = false;
                lbCidade.Visible = false;
            }

            if (cbEscolhaPD.SelectedIndex == 3)
            {
                tbPesCNPJ.Visible = true;
                lbCNPJ.Visible = true;
                btnProcurar.Visible = true;
            }
            else
            {
                tbPesCNPJ.Text = "";
                tbPesCNPJ.Visible = false;
                lbCNPJ.Visible = false;
            }
        }
    }
}
