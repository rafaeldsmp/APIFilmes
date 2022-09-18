namespace WinFormsFilmes.Formularios
{
    partial class FormularioFilmes
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
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDiretor = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDiretor = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxDuracao = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridViewFilmes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botaoGet = new System.Windows.Forms.Button();
            this.botaoPost = new System.Windows.Forms.Button();
            this.botaoGetId = new System.Windows.Forms.Button();
            this.DataGridViewBotaoAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(62, 58);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(56, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelDiretor
            // 
            this.labelDiretor.AutoSize = true;
            this.labelDiretor.Location = new System.Drawing.Point(62, 110);
            this.labelDiretor.Name = "labelDiretor";
            this.labelDiretor.Size = new System.Drawing.Size(67, 25);
            this.labelDiretor.TabIndex = 1;
            this.labelDiretor.Text = "Diretor";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(329, 61);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(69, 25);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Gênero";
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Location = new System.Drawing.Point(329, 107);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(78, 25);
            this.labelDuracao.TabIndex = 3;
            this.labelDuracao.Text = "Duração";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(82, 175);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 25);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(134, 58);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(164, 31);
            this.textBoxTitulo.TabIndex = 5;
            // 
            // textBoxDiretor
            // 
            this.textBoxDiretor.Location = new System.Drawing.Point(135, 110);
            this.textBoxDiretor.Name = "textBoxDiretor";
            this.textBoxDiretor.Size = new System.Drawing.Size(164, 31);
            this.textBoxDiretor.TabIndex = 6;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(404, 61);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(164, 31);
            this.textBoxGenero.TabIndex = 7;
            // 
            // textBoxDuracao
            // 
            this.textBoxDuracao.Location = new System.Drawing.Point(404, 107);
            this.textBoxDuracao.Name = "textBoxDuracao";
            this.textBoxDuracao.Size = new System.Drawing.Size(164, 31);
            this.textBoxDuracao.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(135, 172);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(164, 31);
            this.textBoxId.TabIndex = 9;
            // 
            // dataGridViewFilmes
            // 
            this.dataGridViewFilmes.AllowUserToDeleteRows = false;
            this.dataGridViewFilmes.AllowUserToOrderColumns = true;
            this.dataGridViewFilmes.AutoGenerateColumns = false;
            this.dataGridViewFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.diretorDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.duracaoDataGridViewTextBoxColumn,
            this.Excluir,
            this.Alterar});
            this.dataGridViewFilmes.DataSource = this.filmeBindingSource;
            this.dataGridViewFilmes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFilmes.Location = new System.Drawing.Point(0, 349);
            this.dataGridViewFilmes.Name = "dataGridViewFilmes";
            this.dataGridViewFilmes.RowHeadersWidth = 62;
            this.dataGridViewFilmes.RowTemplate.Height = 33;
            this.dataGridViewFilmes.Size = new System.Drawing.Size(1541, 638);
            this.dataGridViewFilmes.TabIndex = 10;
            this.dataGridViewFilmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilmes_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // diretorDataGridViewTextBoxColumn
            // 
            this.diretorDataGridViewTextBoxColumn.DataPropertyName = "Diretor";
            this.diretorDataGridViewTextBoxColumn.HeaderText = "Diretor";
            this.diretorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diretorDataGridViewTextBoxColumn.Name = "diretorDataGridViewTextBoxColumn";
            this.diretorDataGridViewTextBoxColumn.Width = 150;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 150;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            this.duracaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 8;
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 150;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.MinimumWidth = 8;
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 150;
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataSource = typeof(WinFormsFilmes.Model.Filme);
            // 
            // botaoGet
            // 
            this.botaoGet.Location = new System.Drawing.Point(185, 268);
            this.botaoGet.Name = "botaoGet";
            this.botaoGet.Size = new System.Drawing.Size(112, 34);
            this.botaoGet.TabIndex = 11;
            this.botaoGet.Text = "Get";
            this.botaoGet.UseVisualStyleBackColor = true;
            this.botaoGet.Click += new System.EventHandler(this.botaoGet_Click);
            // 
            // botaoPost
            // 
            this.botaoPost.Location = new System.Drawing.Point(470, 268);
            this.botaoPost.Name = "botaoPost";
            this.botaoPost.Size = new System.Drawing.Size(112, 34);
            this.botaoPost.TabIndex = 12;
            this.botaoPost.Text = "Post";
            this.botaoPost.UseVisualStyleBackColor = true;
            this.botaoPost.Click += new System.EventHandler(this.botaoPost_Click);
            // 
            // botaoGetId
            // 
            this.botaoGetId.Location = new System.Drawing.Point(329, 268);
            this.botaoGetId.Name = "botaoGetId";
            this.botaoGetId.Size = new System.Drawing.Size(112, 34);
            this.botaoGetId.TabIndex = 13;
            this.botaoGetId.Text = "Get Id";
            this.botaoGetId.UseVisualStyleBackColor = true;
            this.botaoGetId.Click += new System.EventHandler(this.botaoGetId_Click);
            // 
            // DataGridViewBotaoAlterar
            // 
            this.DataGridViewBotaoAlterar.HeaderText = "Alterar";
            this.DataGridViewBotaoAlterar.MinimumWidth = 8;
            this.DataGridViewBotaoAlterar.Name = "DataGridViewBotaoAlterar";
            this.DataGridViewBotaoAlterar.Width = 150;
            // 
            // FormularioFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 987);
            this.Controls.Add(this.botaoGetId);
            this.Controls.Add(this.botaoPost);
            this.Controls.Add(this.botaoGet);
            this.Controls.Add(this.dataGridViewFilmes);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxDuracao);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxDiretor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDiretor);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormularioFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioFilmes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Label labelDiretor;
        private Label labelGenero;
        private Label labelDuracao;
        private Label labelId;
        private TextBox textBoxTitulo;
        private TextBox textBoxDiretor;
        private TextBox textBoxGenero;
        private TextBox textBoxDuracao;
        private TextBox textBoxId;
        private DataGridView dataGridViewFilmes;
        private Button botaoGet;
        private Button botaoPost;
        private Button botaoGetId;
        private BindingSource filmeBindingSource;
        private DataGridViewButtonColumn DataGridViewBotaoAlterar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diretorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Excluir;
        private DataGridViewButtonColumn Alterar;
    }
}