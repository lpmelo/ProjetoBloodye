using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBloodye.Pages.adm.ChildForms
{
    public partial class FormPD : Form
    {
        public FormPD()
        {
            InitializeComponent();
        }

        private void cbEscolhaPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCB.Visible = false;
        }
    }
}
