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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstoque clientes = new FrmEstoque();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(clientes);
            clientes.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmVendas clientes = new FrmVendas ();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(clientes);
            clientes.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            FrmClientes clientes = new FrmClientes();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(clientes);
            clientes.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmPerfil clientes = new FrmPerfil();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(clientes);
            clientes.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            FrmPerfil clientes = new FrmPerfil();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
