namespace ProjetoBloodye.Pages.adm.ChildForms
{
    partial class FormPD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEscolhaPD = new System.Windows.Forms.ComboBox();
            this.labelCB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEscolhaPD
            // 
            this.cbEscolhaPD.BackColor = System.Drawing.Color.Brown;
            this.cbEscolhaPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolhaPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEscolhaPD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscolhaPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbEscolhaPD.FormattingEnabled = true;
            this.cbEscolhaPD.Items.AddRange(new object[] {
            "Tipo sanguíneo",
            "Nome",
            "CPF"});
            this.cbEscolhaPD.Location = new System.Drawing.Point(12, 12);
            this.cbEscolhaPD.Name = "cbEscolhaPD";
            this.cbEscolhaPD.Size = new System.Drawing.Size(151, 22);
            this.cbEscolhaPD.TabIndex = 0;
            this.cbEscolhaPD.SelectedIndexChanged += new System.EventHandler(this.cbEscolhaPD_SelectedIndexChanged);
            // 
            // labelCB
            // 
            this.labelCB.AutoSize = true;
            this.labelCB.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCB.Location = new System.Drawing.Point(14, 16);
            this.labelCB.Name = "labelCB";
            this.labelCB.Size = new System.Drawing.Size(128, 13);
            this.labelCB.TabIndex = 1;
            this.labelCB.Text = "Escolha uma pesquisa";
            // 
            // FormPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(748, 622);
            this.Controls.Add(this.labelCB);
            this.Controls.Add(this.cbEscolhaPD);
            this.Name = "FormPD";
            this.Text = "FormPD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEscolhaPD;
        private System.Windows.Forms.Label labelCB;
    }
}