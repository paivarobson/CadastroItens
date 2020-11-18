using System;
using System.Windows.Forms;

namespace CadastroItensCompra
{
    public partial class CadastroCompra : Form
    {
        public CadastroCompra()
        {
            InitializeComponent();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            gbCompra.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbCompra.Enabled = false;
        }
    }
}
