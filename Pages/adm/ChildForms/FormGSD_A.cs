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
    public partial class FormGSD_A : Form
    {

        public bool cadastrado = false;
        Comandos co = new Comandos();
        public FormGSD_A()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "" || mtbRG.Text == ""|| mtbCPF.Text == "" || cbTS.Text == "") {
                MessageBox.Show("Preencha todos os campos com o asterístico (*)!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    string local = "bd/Administradores.accdb";
                    string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();
                    co.conectado = true;
                    co.Adicionar(conn, tbNome.Text, mtbRG.Text, mtbCPF.Text, cbTS.Text, tbEndereco.Text, mtbTelefone.Text, mtbCelular.Text,cbValidado.Checked);
                    conn.Close();
                    cadastrado = co.cadastrorealizado;
                    if(cadastrado==true)this.Close();
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
