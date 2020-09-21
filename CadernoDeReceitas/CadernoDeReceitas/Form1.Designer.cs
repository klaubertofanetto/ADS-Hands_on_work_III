namespace CadernoDeReceitas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovaReceita = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExibeReceita = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCbOpcoesBusca = new System.Windows.Forms.ComboBox();
            this.dgvListaReceitas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dificuldade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaReceita
            // 
            this.btnNovaReceita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaReceita.Location = new System.Drawing.Point(13, 12);
            this.btnNovaReceita.Name = "btnNovaReceita";
            this.btnNovaReceita.Size = new System.Drawing.Size(290, 23);
            this.btnNovaReceita.TabIndex = 0;
            this.btnNovaReceita.Text = "Cadastrar nova receita";
            this.btnNovaReceita.UseVisualStyleBackColor = true;
            this.btnNovaReceita.Click += new System.EventHandler(this.btnNovaReceita_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(13, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Excluir receita";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(230, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 21);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExibeReceita
            // 
            this.btnExibeReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibeReceita.Location = new System.Drawing.Point(170, 126);
            this.btnExibeReceita.Name = "btnExibeReceita";
            this.btnExibeReceita.Size = new System.Drawing.Size(133, 23);
            this.btnExibeReceita.TabIndex = 3;
            this.btnExibeReceita.Text = "Exibir receita";
            this.btnExibeReceita.UseVisualStyleBackColor = true;
            this.btnExibeReceita.Click += new System.EventHandler(this.btnExibeReceita_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Location = new System.Drawing.Point(13, 57);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(290, 20);
            this.txtBusca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por:";
            // 
            // txtCbOpcoesBusca
            // 
            this.txtCbOpcoesBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCbOpcoesBusca.FormattingEnabled = true;
            this.txtCbOpcoesBusca.Items.AddRange(new object[] {
            "nome",
            "ingrediente",
            "dificuldade"});
            this.txtCbOpcoesBusca.Location = new System.Drawing.Point(79, 83);
            this.txtCbOpcoesBusca.Name = "txtCbOpcoesBusca";
            this.txtCbOpcoesBusca.Size = new System.Drawing.Size(145, 21);
            this.txtCbOpcoesBusca.TabIndex = 6;
            this.txtCbOpcoesBusca.Text = "selecione uma opção";
            // 
            // dgvListaReceitas
            // 
            this.dgvListaReceitas.AllowUserToResizeRows = false;
            this.dgvListaReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaReceitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReceitas.ColumnHeadersVisible = false;
            this.dgvListaReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Dificuldade,
            this.id});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaReceitas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaReceitas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaReceitas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListaReceitas.Location = new System.Drawing.Point(13, 162);
            this.dgvListaReceitas.MultiSelect = false;
            this.dgvListaReceitas.Name = "dgvListaReceitas";
            this.dgvListaReceitas.ReadOnly = true;
            this.dgvListaReceitas.RowHeadersVisible = false;
            this.dgvListaReceitas.Size = new System.Drawing.Size(290, 276);
            this.dgvListaReceitas.TabIndex = 7;
            this.dgvListaReceitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaReceitas_CellClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Dificuldade
            // 
            this.Dificuldade.HeaderText = "dificuldade";
            this.Dificuldade.Name = "Dificuldade";
            this.Dificuldade.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 2);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(9, 114);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 2);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListaReceitas);
            this.Controls.Add(this.txtCbOpcoesBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnExibeReceita);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNovaReceita);
            this.Name = "Form1";
            this.Text = "Minhas Receitas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaReceita;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExibeReceita;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCbOpcoesBusca;
        private System.Windows.Forms.DataGridView dgvListaReceitas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dificuldade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

