using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListaDC_Click(object sender, EventArgs e)
        {
            FrmListaDClientes clientes = new FrmListaDClientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelClientes.Controls.Clear();
            panelClientes.Controls.Add(clientes);
            clientes.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar clientes = new FrmCadastrar();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelClientes.Controls.Clear();
            panelClientes.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
