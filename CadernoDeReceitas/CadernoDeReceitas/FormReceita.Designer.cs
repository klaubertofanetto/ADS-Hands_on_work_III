namespace CadernoDeReceitas
{
    partial class FormReceita
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnVoltaInicio = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredientes:";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModoPreparo.BackColor = System.Drawing.SystemColors.Control;
            this.txtModoPreparo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModoPreparo.Location = new System.Drawing.Point(276, 33);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModoPreparo.Size = new System.Drawing.Size(430, 257);
            this.txtModoPreparo.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(570, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Salvar alterações";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnVoltaInicio
            // 
            this.btnVoltaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltaInicio.Location = new System.Drawing.Point(428, 302);
            this.btnVoltaInicio.Name = "btnVoltaInicio";
            this.btnVoltaInicio.Size = new System.Drawing.Size(136, 23);
            this.btnVoltaInicio.TabIndex = 5;
            this.btnVoltaInicio.Text = "Voltar";
            this.btnVoltaInicio.UseVisualStyleBackColor = true;
            this.btnVoltaInicio.Click += new System.EventHandler(this.btnVoltaInicio_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(16, 14);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 42);
            this.txtNome.TabIndex = 6;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BackColor = System.Drawing.SystemColors.Control;
            this.txtIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(16, 80);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngredientes.Size = new System.Drawing.Size(232, 245);
            this.txtIngredientes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modo de Preparo:";
            // 
            // FormReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVoltaInicio);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.label2);
            this.Name = "FormReceita";
            this.Text = "Minha Receita";
            this.Load += new System.EventHandler(this.FormReceita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnVoltaInicio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label1;
    }
}