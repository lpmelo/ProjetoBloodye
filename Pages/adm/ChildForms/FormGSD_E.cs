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
using ProjetoBloodye.cbd;

namespace ProjetoBloodye.Pages.adm.ChildForms
{
    public partial class FormGSD_E : Form
    {
        public bool editado = false;
        public string idrecebido;
        Comandos co = new Comandos();
        public FormGSD_E()
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

            string Query = "SELECT * FROM Doadores WHERE Codigo=@id;";
            OleDbCommand cm = new OleDbCommand(Query, conexao);
            cm.Parameters.AddWithValue("@id", idrecebido);
            OleDbDataReader registro = cm.ExecuteReader();
            if (registro.Read())
            {
                tbNome.Text = registro["Nome"].ToString();
                mtbRG.Text = registro["RG"].ToString();
                mtbCPF.Text = registro["CPF"].ToString();
                cbTS.Text = registro["TipoSangue"].ToString();
                tbEndereco.Text = registro["Endereco"].ToString();
                mtbTelefone.Text = registro["Telefone"].ToString();
                mtbCelular.Text = registro["Celular"].ToString();
                bool validado = (bool)registro["Validado"];
                cbValidado.Checked = validado;
                var hemocentro = registro["HemocentroCadastrado"];
                cbHemocentro.Text = hemocentro.ToString();
            }
            else
            {
                MessageBox.Show("Não foi possível coletar os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbHemocentro.SelectedIndex == 0)
            {
                MessageBox.Show("O código do Hemocentro não pode ser igual a zero!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbNome.Text == "" || mtbRG.Text == "" || mtbCPF.Text == "" || cbTS.Text == "")
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
                        co.Editar(idrecebido, tbNome.Text, mtbRG.Text, mtbCPF.Text, cbTS.Text, tbEndereco.Text, mtbTelefone.Text, mtbCelular.Text, cbValidado.Checked, cbHemocentro.SelectedIndex, conn);
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
        private void preencheCb()
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                string Query = "SELECT Codigo FROM Hemocentros ORDER BY Codigo ASC";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                OleDbCommand cm = new OleDbCommand(Query, conn);
                OleDbDataReader reader = cm.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();
                row["Codigo"] = 0;
                table.Rows.InsertAt(row, 0);
                this.cbHemocentro.DataSource = table;
                this.cbHemocentro.ValueMember = "Codigo";
                this.cbHemocentro.DisplayMember = "Codigo";
                reader.Close();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FormGSD_E_Load(object sender, EventArgs e)
        {
            preencheCb();
            IniciarEdicao();
        }
    }
}
