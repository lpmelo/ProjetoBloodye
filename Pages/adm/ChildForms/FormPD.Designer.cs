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
            this.tbPesTS = new System.Windows.Forms.TextBox();
            this.tbPesNome = new System.Windows.Forms.TextBox();
            this.tbPesCPF = new System.Windows.Forms.TextBox();
            this.lbTS = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEscolhaPD
            // 
            this.cbEscolhaPD.BackColor = System.Drawing.Color.DarkRed;
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
            this.labelCB.BackColor = System.Drawing.Color.DarkRed;
            this.labelCB.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCB.Location = new System.Drawing.Point(14, 16);
            this.labelCB.Name = "labelCB";
            this.labelCB.Size = new System.Drawing.Size(128, 13);
            this.labelCB.TabIndex = 1;
            this.labelCB.Text = "Escolha uma pesquisa";
            // 
            // tbPesTS
            // 
            this.tbPesTS.Location = new System.Drawing.Point(12, 50);
            this.tbPesTS.Name = "tbPesTS";
            this.tbPesTS.Size = new System.Drawing.Size(151, 20);
            this.tbPesTS.TabIndex = 2;
            // 
            // tbPesNome
            // 
            this.tbPesNome.Location = new System.Drawing.Point(12, 50);
            this.tbPesNome.Name = "tbPesNome";
            this.tbPesNome.Size = new System.Drawing.Size(151, 20);
            this.tbPesNome.TabIndex = 3;
            // 
            // tbPesCPF
            // 
            this.tbPesCPF.Location = new System.Drawing.Point(12, 50);
            this.tbPesCPF.Name = "tbPesCPF";
            this.tbPesCPF.Size = new System.Drawing.Size(151, 20);
            this.tbPesCPF.TabIndex = 4;
            // 
            // lbTS
            // 
            this.lbTS.AutoSize = true;
            this.lbTS.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTS.Location = new System.Drawing.Point(9, 73);
            this.lbTS.Name = "lbTS";
            this.lbTS.Size = new System.Drawing.Size(243, 13);
            this.lbTS.TabIndex = 5;
            this.lbTS.Text = "Você esta procurando pelo Tipo Sanguíneo";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbNome.Location = new System.Drawing.Point(9, 73);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(187, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Você esta procurando pelo Nome";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCPF.Location = new System.Drawing.Point(9, 73);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(179, 13);
            this.lbCPF.TabIndex = 7;
            this.lbCPF.Text = "Você esta procurando pelo CPF";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.DarkRed;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcurar.Location = new System.Drawing.Point(169, 45);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(83, 27);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // FormPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(748, 622);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTS);
            this.Controls.Add(this.tbPesCPF);
            this.Controls.Add(this.tbPesNome);
            this.Controls.Add(this.tbPesTS);
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
        private System.Windows.Forms.TextBox tbPesTS;
        private System.Windows.Forms.TextBox tbPesNome;
        private System.Windows.Forms.TextBox tbPesCPF;
        private System.Windows.Forms.Label lbTS;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Button btnProcurar;
    }
}