using ProjetoBloodye.Pages;
using System;
using System.Windows.Forms;

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
            Admin Form = new Admin();
            Form.Show();
        }
    }
}
