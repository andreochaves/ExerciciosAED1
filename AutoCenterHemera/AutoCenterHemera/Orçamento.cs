using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoCenterHemera
{
    public partial class Orçamento : Form
    {
        public Orçamento()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btProxT2_Click(object sender, EventArgs e)
        {

        }

        private void btVoltT2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formulario janela = new Formulario();
            janela.ShowDialog(this);
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orçamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autoCenterDataSet.dadosOrcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosOrcamentoTableAdapter.Fill(this.autoCenterDataSet.dadosOrcamento);

        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
           // SqlConnection conn = new SqlConnection(AutoCenter.mdf);
        }
    }
}
