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
            // TODO: esta linha de código carrega dados na tabela 'administradoresDataSet1.Doadores'. Você pode movê-la ou removê-la conforme necessário.
            this.doadoresTableAdapter.Fill(this.administradoresDataSet1.Doadores);

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
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new OleDbDataAdapter("SELECT * FROM Doadores", conn);
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

    }
}

