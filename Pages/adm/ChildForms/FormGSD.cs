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
    public partial class FormGSD : Form
    {
        string idselecionado;
        OleDbDataAdapter adapt;
        Comandos cm = new Comandos();


        public FormGSD()
        {
            InitializeComponent();
            DisplayData();
        }

        private void FormGSD_Load(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idselecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
            }
        }
        private void DisplayData()
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                string Query1 = "SELECT Doadores.Codigo,Doadores.Nome,Doadores.RG,Doadores.CPF,Doadores.TipoSangue," +
                                "Doadores.Endereco,Doadores.Validado,Hemocentros.Nome AS NomeHemocentro FROM Doadores " +
                                "LEFT JOIN Hemocentros ON Doadores.HemocentroCadastrado = Hemocentros.Codigo";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new OleDbDataAdapter(Query1, conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }catch(Exception erro)
            {
                cm.conectado = false;
                MessageBox.Show(erro.Message);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                cm.conectado = true;
                cm.Validar(idselecionado, conn);
                DisplayData();
                conn.Close();
               
            }
            catch (Exception erro)
            {
                cm.conectado = false;
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormGSD_A filho = new FormGSD_A();
            while (filho.cadastrado == false)
            {
                filho.ShowDialog();
                if (filho.cadastrado == true) { DisplayData();}
                break;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormGSD_E filho = new FormGSD_E();
            filho.idrecebido = idselecionado;
            if (idselecionado != null)
            {
                while (filho.editado == false)
                {
                    filho.ShowDialog();
                    if (filho.editado == true) { DisplayData(); }
                    break;
                }
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum doador!\n Selecione um para ser editado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var pergunta = MessageBox.Show("Tem certeza que deseja excluir este doador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                try
                {
                    string local = "bd/Administradores.accdb";
                    string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                    OleDbConnection conn = new OleDbConnection(Stringcon);
                    conn.Open();
                    cm.conectado = true;
                    cm.Excluir(conn, idselecionado);
                    DisplayData();
                    conn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

