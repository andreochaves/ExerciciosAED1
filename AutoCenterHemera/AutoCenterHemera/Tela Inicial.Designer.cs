namespace AutoCenterHemera
{
    partial class telaP
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_VerOrcamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(134, 134);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(171, 167);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo Orçamento";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_VerOrcamento
            // 
            this.btn_VerOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerOrcamento.Location = new System.Drawing.Point(430, 134);
            this.btn_VerOrcamento.Name = "btn_VerOrcamento";
            this.btn_VerOrcamento.Size = new System.Drawing.Size(171, 167);
            this.btn_VerOrcamento.TabIndex = 1;
            this.btn_VerOrcamento.Text = "Ver Orçamento";
            this.btn_VerOrcamento.UseVisualStyleBackColor = true;
            // 
            // telaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_VerOrcamento);
            this.Controls.Add(this.btn_Novo);
            this.Name = "telaP";
            this.Text = "Hemera Auto Center";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_VerOrcamento;
    }
}

