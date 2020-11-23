using ProjetoBloodye.cbd;
using ProjetoBloodye.Pages;
using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.CodeDom.Compiler;

namespace ProjetoBloodye
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comandos comandos = new Comandos();
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+local+";Persist Security Info=False;";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                comandos.conectado = true;
                comandos.Logar(tbLogin.Text, tbSenha.Text, conn);
                conn.Close();
                while (comandos.logado == true) { Admin adm = new Admin(this); adm.Show();this.Hide();if (adm.Visible == false) this.Show(); break; }
            }
            catch (Exception erro)
            {
                comandos.conectado = false;
                MessageBox.Show(erro.Message);
            }
        }
    }
}
