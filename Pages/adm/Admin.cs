using ProjetoBloodye.cbd;
using ProjetoBloodye.Pages.adm.ChildForms;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProjetoBloodye.Pages
{
    public partial class Admin : Form
    {
        private Inicio principal;
        public Admin(Inicio frm)
        {
            principal = frm;
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            subMenuP1.Visible = false;
            subMenuP2.Visible = false;
            subMenuP3.Visible = false;
        }

        private void HideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnDoadores_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuP1);
        }

        private void btnSDGerenciar_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP1);
            openChildForm(new FormGSD());
        }

        private void btnSDProcurar_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP1);
            openChildForm(new FormPD());
        }

        private void btnSDContato_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP1);
            openChildForm(new FormCD());
        }


        private void btnSHGerenciar_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP2);
        }

        private void btnSHProcurar_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP2);
        }

        private void btnSHContato_Click(object sender, EventArgs e)
        {
            HideSubMenu(subMenuP2);
        }

        private void btnHemocentros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuP2);
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuP3);
        }

        private void btnSAManual_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuP3);
        }

        private void btnSAContato_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuP3);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/br/autores/freepik");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/br");
        }

        private Form activeForm = null;
        private void openChildForm(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(child);
            panelChildForm.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSobre());
        }

        private void PBLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                HideSubMenu(subMenuP1);
                HideSubMenu(subMenuP2);
                HideSubMenu(subMenuP3);
            }
            activeForm = null;
        }
    }
}
