using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenterHemera
{
    public partial class telaP : Form
    {
        public telaP()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formulario janela = new Formulario();
            janela.ShowDialog(this);
            this.Dispose();
        }
    }
}
