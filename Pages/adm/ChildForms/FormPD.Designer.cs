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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbEscolhaPD = new System.Windows.Forms.ComboBox();
            this.labelCB = new System.Windows.Forms.Label();
            this.lbTS = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.cbTS = new System.Windows.Forms.ComboBox();
            this.tbPesCPF = new System.Windows.Forms.TextBox();
            this.tbPesNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbHemocentro = new System.Windows.Forms.ComboBox();
            this.lbHemocentro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            "CPF",
            "Hemocentro"});
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
            // cbTS
            // 
            this.cbTS.BackColor = System.Drawing.Color.DarkRed;
            this.cbTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTS.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbTS.FormattingEnabled = true;
            this.cbTS.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbTS.Location = new System.Drawing.Point(12, 45);
            this.cbTS.Name = "cbTS";
            this.cbTS.Size = new System.Drawing.Size(50, 24);
            this.cbTS.TabIndex = 14;
            // 
            // tbPesCPF
            // 
            this.tbPesCPF.BackColor = System.Drawing.Color.DarkRed;
            this.tbPesCPF.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbPesCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbPesCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPesCPF.Location = new System.Drawing.Point(12, 46);
            this.tbPesCPF.Name = "tbPesCPF";
            this.tbPesCPF.Size = new System.Drawing.Size(151, 22);
            this.tbPesCPF.TabIndex = 15;
            // 
            // tbPesNome
            // 
            this.tbPesNome.BackColor = System.Drawing.Color.DarkRed;
            this.tbPesNome.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbPesNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbPesNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPesNome.Location = new System.Drawing.Point(12, 46);
            this.tbPesNome.Name = "tbPesNome";
            this.tbPesNome.Size = new System.Drawing.Size(151, 22);
            this.tbPesNome.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.Location = new System.Drawing.Point(17, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 396);
            this.dataGridView1.TabIndex = 17;
            // 
            // cbHemocentro
            // 
            this.cbHemocentro.BackColor = System.Drawing.Color.DarkRed;
            this.cbHemocentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHemocentro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbHemocentro.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbHemocentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbHemocentro.FormattingEnabled = true;
            this.cbHemocentro.Location = new System.Drawing.Point(12, 45);
            this.cbHemocentro.Name = "cbHemocentro";
            this.cbHemocentro.Size = new System.Drawing.Size(50, 24);
            this.cbHemocentro.TabIndex = 18;
            // 
            // lbHemocentro
            // 
            this.lbHemocentro.AutoSize = true;
            this.lbHemocentro.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHemocentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbHemocentro.Location = new System.Drawing.Point(9, 74);
            this.lbHemocentro.Name = "lbHemocentro";
            this.lbHemocentro.Size = new System.Drawing.Size(222, 13);
            this.lbHemocentro.TabIndex = 19;
            this.lbHemocentro.Text = "Você esta procurando pelo Hemocentro";
            // 
            // FormPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(748, 622);
            this.Controls.Add(this.lbHemocentro);
            this.Controls.Add(this.cbHemocentro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbPesNome);
            this.Controls.Add(this.tbPesCPF);
            this.Controls.Add(this.cbTS);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTS);
            this.Controls.Add(this.labelCB);
            this.Controls.Add(this.cbEscolhaPD);
            this.Name = "FormPD";
            this.Text = "FormPD";
            this.Load += new System.EventHandler(this.FormPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEscolhaPD;
        private System.Windows.Forms.Label labelCB;
        private System.Windows.Forms.Label lbTS;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ComboBox cbTS;
        private System.Windows.Forms.TextBox tbPesCPF;
        private System.Windows.Forms.TextBox tbPesNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbHemocentro;
        private System.Windows.Forms.Label lbHemocentro;
    }
}