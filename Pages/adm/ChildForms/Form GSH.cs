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
    public partial class Form_GSH : Form
    {
        string idselecionado;
        OleDbDataAdapter adapt;
        Comandos co = new Comandos();
        public Form_GSH()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                string Query1 = "SELECT Hemocentros.Codigo,Hemocentros.Nome,Hemocentros.Cidade,Hemocentros.Endereco,Hemocentros.Telefone,Hemocentros.UF,Hemocentros.CNPJ, " +
                                "(SELECT COUNT(Doadores.HemocentroCadastrado) FROM Doadores " +
                                "WHERE Doadores.HemocentroCadastrado = Hemocentros.Codigo) AS DoadoresCadastrados " +
                                "FROM Hemocentros;";

                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new OleDbDataAdapter(Query1, conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception erro)
            {
                co.conectado = false;
                MessageBox.Show(erro.Message);
            }
        }

        private void Form_GSH_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormGSH_A filho = new FormGSH_A();
            while (filho.cadastrado == false)
            {
                filho.ShowDialog();
                if (filho.cadastrado == true) { DisplayData(); }
                break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormGSH_E filho = new FormGSH_E();
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
                MessageBox.Show("Não foi selecionado nenhum Hemocentro!\n Selecione um para ser editado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string local = "bd/Administradores.accdb";
                string Stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                co.conectado = true;
                co.VerificaDH(conn, idselecionado);
                co.ExcluirH(conn, idselecionado);
                conn.Close();
                conn.Dispose();
                DisplayData();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
