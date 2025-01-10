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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmInserirProduto clientes = new FrmInserirProduto();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelEstoque.Controls.Clear();
            panelEstoque.Controls.Add(clientes);
            clientes.Show();
        }

        private void btnEstoqueGeral_Click(object sender, EventArgs e)
        {
            FrmEstoqueGeral clientes = new FrmEstoqueGeral();
            clientes.TopLevel = false;
            clientes.Dock = DockStyle.Fill;
            panelEstoque.Controls.Clear();
            panelEstoque.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
