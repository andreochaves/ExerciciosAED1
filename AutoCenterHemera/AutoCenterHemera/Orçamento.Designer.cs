namespace AutoCenterHemera
{
    partial class Orçamento
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdc = new System.Windows.Forms.Button();
            this.btProxT2 = new System.Windows.Forms.Button();
            this.btVoltT2 = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadosOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoCenterDataSet = new AutoCenterHemera.AutoCenterDataSet();
            this.autoCenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosOrcamentoTableAdapter = new AutoCenterHemera.AutoCenterDataSetTableAdapters.dadosOrcamentoTableAdapter();
            this.tableAdapterManager = new AutoCenterHemera.AutoCenterDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCenterDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Lista de Serviços";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(118, 64);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(363, 20);
            this.txtServico.TabIndex = 23;
            this.txtServico.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Novo Serviço";
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(653, 65);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(75, 23);
            this.btnAdc.TabIndex = 31;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // btProxT2
            // 
            this.btProxT2.Location = new System.Drawing.Point(653, 415);
            this.btProxT2.Name = "btProxT2";
            this.btProxT2.Size = new System.Drawing.Size(75, 23);
            this.btProxT2.TabIndex = 33;
            this.btProxT2.Text = "Próximo";
            this.btProxT2.UseVisualStyleBackColor = true;
            this.btProxT2.Click += new System.EventHandler(this.btProxT2_Click);
            // 
            // btVoltT2
            // 
            this.btVoltT2.Location = new System.Drawing.Point(37, 415);
            this.btVoltT2.Name = "btVoltT2";
            this.btVoltT2.Size = new System.Drawing.Size(75, 23);
            this.btVoltT2.TabIndex = 32;
            this.btVoltT2.Text = "Voltar";
            this.btVoltT2.UseVisualStyleBackColor = true;
            this.btVoltT2.Click += new System.EventHandler(this.btVoltT2_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(582, 68);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(36, 20);
            this.txtQtd.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dadosOrcamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(691, 282);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // servicoDataGridViewTextBoxColumn
            // 
            this.servicoDataGridViewTextBoxColumn.DataPropertyName = "Servico";
            this.servicoDataGridViewTextBoxColumn.HeaderText = "Servico";
            this.servicoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.servicoDataGridViewTextBoxColumn.Name = "servicoDataGridViewTextBoxColumn";
            this.servicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicoDataGridViewTextBoxColumn.Width = 350;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dadosOrcamentoBindingSource
            // 
            this.dadosOrcamentoBindingSource.DataMember = "dadosOrcamento";
            this.dadosOrcamentoBindingSource.DataSource = this.autoCenterDataSet;
            // 
            // autoCenterDataSet
            // 
            this.autoCenterDataSet.DataSetName = "AutoCenterDataSet";
            this.autoCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoCenterDataSetBindingSource
            // 
            this.autoCenterDataSetBindingSource.DataSource = this.autoCenterDataSet;
            this.autoCenterDataSetBindingSource.Position = 0;
            // 
            // dadosOrcamentoTableAdapter
            // 
            this.dadosOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dadosCarroTableAdapter = null;
            this.tableAdapterManager.dadosClienteTableAdapter = null;
            this.tableAdapterManager.dadosOrcamentoTableAdapter = this.dadosOrcamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoCenterHemera.AutoCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Orçamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btProxT2);
            this.Controls.Add(this.btVoltT2);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.label1);
            this.Name = "Orçamento";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.Orçamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCenterDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button btProxT2;
        private System.Windows.Forms.Button btVoltT2;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource autoCenterDataSetBindingSource;
        private AutoCenterDataSet autoCenterDataSet;
        private System.Windows.Forms.BindingSource dadosOrcamentoBindingSource;
        private AutoCenterDataSetTableAdapters.dadosOrcamentoTableAdapter dadosOrcamentoTableAdapter;
        private AutoCenterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}