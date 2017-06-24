namespace Biblioteca
{
    partial class frmPrincipal
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
            this.gbCadLivro = new System.Windows.Forms.GroupBox();
            this.mskPaginas = new System.Windows.Forms.MaskedTextBox();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.mskEdicao = new System.Windows.Forms.MaskedTextBox();
            this.mskAnoPub = new System.Windows.Forms.MaskedTextBox();
            this.lbAnoPub = new System.Windows.Forms.Label();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.lbPaginas = new System.Windows.Forms.Label();
            this.lbEditora = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.gvListaLivro = new System.Windows.Forms.DataGridView();
            this.clnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnoPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.gbCadLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadLivro
            // 
            this.gbCadLivro.Controls.Add(this.mskPaginas);
            this.gbCadLivro.Controls.Add(this.tbEditora);
            this.gbCadLivro.Controls.Add(this.tbAutor);
            this.gbCadLivro.Controls.Add(this.mskEdicao);
            this.gbCadLivro.Controls.Add(this.mskAnoPub);
            this.gbCadLivro.Controls.Add(this.lbAnoPub);
            this.gbCadLivro.Controls.Add(this.lbEdicao);
            this.gbCadLivro.Controls.Add(this.lbPaginas);
            this.gbCadLivro.Controls.Add(this.lbEditora);
            this.gbCadLivro.Controls.Add(this.lbAutor);
            this.gbCadLivro.Controls.Add(this.lbIsbn);
            this.gbCadLivro.Controls.Add(this.tbIsbn);
            this.gbCadLivro.Controls.Add(this.tbTitulo);
            this.gbCadLivro.Controls.Add(this.lblTitulo);
            this.gbCadLivro.Controls.Add(this.btnLimparCampos);
            this.gbCadLivro.Controls.Add(this.btnSalvarLivro);
            this.gbCadLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadLivro.Location = new System.Drawing.Point(12, 12);
            this.gbCadLivro.Name = "gbCadLivro";
            this.gbCadLivro.Size = new System.Drawing.Size(300, 537);
            this.gbCadLivro.TabIndex = 0;
            this.gbCadLivro.TabStop = false;
            this.gbCadLivro.Text = "Cadastro de livros";
            // 
            // mskPaginas
            // 
            this.mskPaginas.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPaginas.Location = new System.Drawing.Point(204, 424);
            this.mskPaginas.Mask = "00000";
            this.mskPaginas.Name = "mskPaginas";
            this.mskPaginas.Size = new System.Drawing.Size(53, 26);
            this.mskPaginas.TabIndex = 6;
            this.mskPaginas.ValidatingType = typeof(int);
            // 
            // tbEditora
            // 
            this.tbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditora.Location = new System.Drawing.Point(6, 307);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(281, 26);
            this.tbEditora.TabIndex = 3;
            // 
            // tbAutor
            // 
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutor.Location = new System.Drawing.Point(6, 218);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(281, 26);
            this.tbAutor.TabIndex = 2;
            // 
            // mskEdicao
            // 
            this.mskEdicao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskEdicao.Location = new System.Drawing.Point(115, 424);
            this.mskEdicao.Mask = "00";
            this.mskEdicao.Name = "mskEdicao";
            this.mskEdicao.Size = new System.Drawing.Size(27, 26);
            this.mskEdicao.TabIndex = 5;
            // 
            // mskAnoPub
            // 
            this.mskAnoPub.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAnoPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAnoPub.Location = new System.Drawing.Point(9, 424);
            this.mskAnoPub.Mask = "0000";
            this.mskAnoPub.Name = "mskAnoPub";
            this.mskAnoPub.Size = new System.Drawing.Size(47, 26);
            this.mskAnoPub.TabIndex = 4;
            // 
            // lbAnoPub
            // 
            this.lbAnoPub.AutoSize = true;
            this.lbAnoPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoPub.Location = new System.Drawing.Point(5, 367);
            this.lbAnoPub.Name = "lbAnoPub";
            this.lbAnoPub.Size = new System.Drawing.Size(85, 40);
            this.lbAnoPub.TabIndex = 10;
            this.lbAnoPub.Text = "Ano de \r\npublicação";
            // 
            // lbEdicao
            // 
            this.lbEdicao.AutoSize = true;
            this.lbEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicao.Location = new System.Drawing.Point(111, 387);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(58, 20);
            this.lbEdicao.TabIndex = 9;
            this.lbEdicao.Text = "Edição";
            // 
            // lbPaginas
            // 
            this.lbPaginas.AutoSize = true;
            this.lbPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaginas.Location = new System.Drawing.Point(200, 367);
            this.lbPaginas.Name = "lbPaginas";
            this.lbPaginas.Size = new System.Drawing.Size(87, 40);
            this.lbPaginas.TabIndex = 8;
            this.lbPaginas.Text = "Número de\r\npáginas";
            // 
            // lbEditora
            // 
            this.lbEditora.AutoSize = true;
            this.lbEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditora.Location = new System.Drawing.Point(5, 275);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(60, 20);
            this.lbEditora.TabIndex = 7;
            this.lbEditora.Text = "Editora";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(5, 186);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(48, 20);
            this.lbAutor.TabIndex = 6;
            this.lbAutor.Text = "Autor";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbn.Location = new System.Drawing.Point(5, 109);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(47, 20);
            this.lbIsbn.TabIndex = 5;
            this.lbIsbn.Text = "ISBN";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(6, 62);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(281, 26);
            this.tbTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(6, 496);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 35);
            this.btnLimparCampos.TabIndex = 8;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLivro.Location = new System.Drawing.Point(218, 496);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(75, 35);
            this.btnSalvarLivro.TabIndex = 7;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // gvListaLivro
            // 
            this.gvListaLivro.AllowUserToAddRows = false;
            this.gvListaLivro.AllowUserToDeleteRows = false;
            this.gvListaLivro.AllowUserToResizeColumns = false;
            this.gvListaLivro.AllowUserToResizeRows = false;
            this.gvListaLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTitulo,
            this.clmIsbn,
            this.clmAutor,
            this.clmEditora,
            this.clmAnoPub,
            this.clmEdicao,
            this.clmPaginas});
            this.gvListaLivro.Location = new System.Drawing.Point(330, 12);
            this.gvListaLivro.MultiSelect = false;
            this.gvListaLivro.Name = "gvListaLivro";
            this.gvListaLivro.ReadOnly = true;
            this.gvListaLivro.Size = new System.Drawing.Size(745, 537);
            this.gvListaLivro.TabIndex = 1;
            // 
            // clnTitulo
            // 
            this.clnTitulo.HeaderText = "Título";
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.ReadOnly = true;
            // 
            // clmIsbn
            // 
            this.clmIsbn.HeaderText = "ISBN";
            this.clmIsbn.Name = "clmIsbn";
            this.clmIsbn.ReadOnly = true;
            // 
            // clmAutor
            // 
            this.clmAutor.HeaderText = "Autor";
            this.clmAutor.Name = "clmAutor";
            this.clmAutor.ReadOnly = true;
            // 
            // clmEditora
            // 
            this.clmEditora.HeaderText = "Editora";
            this.clmEditora.Name = "clmEditora";
            this.clmEditora.ReadOnly = true;
            // 
            // clmAnoPub
            // 
            this.clmAnoPub.HeaderText = "Ano de publicação";
            this.clmAnoPub.Name = "clmAnoPub";
            this.clmAnoPub.ReadOnly = true;
            // 
            // clmEdicao
            // 
            this.clmEdicao.HeaderText = "Edição";
            this.clmEdicao.Name = "clmEdicao";
            this.clmEdicao.ReadOnly = true;
            // 
            // clmPaginas
            // 
            this.clmPaginas.HeaderText = "Páginas";
            this.clmPaginas.Name = "clmPaginas";
            this.clmPaginas.ReadOnly = true;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIsbn.Location = new System.Drawing.Point(6, 132);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(281, 26);
            this.tbIsbn.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.gvListaLivro);
            this.Controls.Add(this.gbCadLivro);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.gbCadLivro.ResumeLayout(false);
            this.gbCadLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadLivro;
        private System.Windows.Forms.DataGridView gvListaLivro;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbIsbn;
        private System.Windows.Forms.Label lbPaginas;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.MaskedTextBox mskEdicao;
        private System.Windows.Forms.MaskedTextBox mskAnoPub;
        private System.Windows.Forms.Label lbAnoPub;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.MaskedTextBox mskPaginas;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnoPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaginas;
        private System.Windows.Forms.TextBox tbIsbn;
    }
}

