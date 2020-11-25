using ProjetoBloodye.cbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetoBloodye.Pages.adm.ChildForms
{
    public partial class FormGSH_E : Form
    {
        public bool editado = false;
        public string idrecebido;
        Comandos co = new Comandos();
        public FormGSH_E()
        {
            InitializeComponent();
        }

        public void IniciarEdicao()
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                co.conectado = true;
                ProcuraId(conn);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro na conexao", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ProcuraId(OleDbConnection conexao)
        {
            string Query = "SELECT * FROM Hemocentros WHERE Codigo=@id;";
            OleDbCommand cm = new OleDbCommand(Query, conexao);
            cm.Parameters.AddWithValue("@id", idrecebido);
            OleDbDataReader registro = cm.ExecuteReader();
            if (registro.Read())
            {
                tbNome.Text = registro["Nome"].ToString();
                tbCidade.Text = registro["Cidade"].ToString();
                tbEndereco.Text = registro["Endereco"].ToString();
                cbUF.Text = registro["UF"].ToString();
                mtbTelefone.Text = registro["Telefone"].ToString();
                mtbCNPJ.Text = registro["CNPJ"].ToString();
            }
            else
            {
                MessageBox.Show("Não foi possível coletar os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGSH_E_Load(object sender, EventArgs e)
        {
            IniciarEdicao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "" || tbCidade.Text == "" || tbEndereco.Text == "" || mtbCNPJ.Text == "" || cbUF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos com o asterístico (*)!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string local = "bd/Administradores.accdb";
                    string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();
                    co.conectado = true;
                    co.EditarH(idrecebido,tbNome.Text,tbCidade.Text,tbEndereco.Text,mtbTelefone.Text,cbUF.Text,mtbCNPJ.Text,conn);
                    conn.Close();
                    editado = co.edicaorealizada;
                    if (editado == true)
                    {
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na conexao", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
