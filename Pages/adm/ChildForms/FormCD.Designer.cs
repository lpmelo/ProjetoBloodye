namespace ProjetoBloodye.Pages.adm.ChildForms
{
    partial class FormCD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbEscolhaPD = new System.Windows.Forms.ComboBox();
            this.tbPesNome = new System.Windows.Forms.TextBox();
            this.lbTS = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.labelCB = new System.Windows.Forms.Label();
            this.cbTS = new System.Windows.Forms.ComboBox();
            this.tbPesCPF = new System.Windows.Forms.TextBox();
            this.cbHemocentro = new System.Windows.Forms.ComboBox();
            this.lbHemocentro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnProcurar.TabIndex = 10;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.Location = new System.Drawing.Point(17, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 396);
            this.dataGridView1.TabIndex = 18;
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
            this.cbEscolhaPD.TabIndex = 19;
            this.cbEscolhaPD.SelectedIndexChanged += new System.EventHandler(this.cbEscolhaPD_SelectedIndexChanged);
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
            this.tbPesNome.TabIndex = 27;
            // 
            // lbTS
            // 
            this.lbTS.AutoSize = true;
            this.lbTS.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTS.Location = new System.Drawing.Point(9, 73);
            this.lbTS.Name = "lbTS";
            this.lbTS.Size = new System.Drawing.Size(243, 13);
            this.lbTS.TabIndex = 21;
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
            this.lbNome.TabIndex = 22;
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
            this.lbCPF.TabIndex = 23;
            this.lbCPF.Text = "Você esta procurando pelo CPF";
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
            this.labelCB.TabIndex = 20;
            this.labelCB.Text = "Escolha uma pesquisa";
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
            this.cbTS.TabIndex = 25;
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
            this.tbPesCPF.TabIndex = 26;
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
            this.cbHemocentro.TabIndex = 28;
            // 
            // lbHemocentro
            // 
            this.lbHemocentro.AutoSize = true;
            this.lbHemocentro.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHemocentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbHemocentro.Location = new System.Drawing.Point(9, 74);
            this.lbHemocentro.Name = "lbHemocentro";
            this.lbHemocentro.Size = new System.Drawing.Size(222, 13);
            this.lbHemocentro.TabIndex = 29;
            this.lbHemocentro.Text = "Você esta procurando pelo Hemocentro";
            // 
            // FormCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(748, 622);
            this.Controls.Add(this.lbHemocentro);
            this.Controls.Add(this.cbHemocentro);
            this.Controls.Add(this.tbPesNome);
            this.Controls.Add(this.tbPesCPF);
            this.Controls.Add(this.cbTS);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTS);
            this.Controls.Add(this.labelCB);
            this.Controls.Add(this.cbEscolhaPD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcurar);
            this.Name = "FormCD";
            this.Text = "FormCD";
            this.Load += new System.EventHandler(this.FormCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbEscolhaPD;
        private System.Windows.Forms.TextBox tbPesNome;
        private System.Windows.Forms.Label lbTS;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label labelCB;
        private System.Windows.Forms.ComboBox cbTS;
        private System.Windows.Forms.TextBox tbPesCPF;
        private System.Windows.Forms.ComboBox cbHemocentro;
        private System.Windows.Forms.Label lbHemocentro;
    }
}