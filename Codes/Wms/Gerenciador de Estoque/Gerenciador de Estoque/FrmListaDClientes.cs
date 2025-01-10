using System;
using System.IO;
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
    public partial class FrmListaDClientes : Form
    {

        private string caminhoArquivo = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms\BD.txt";

        public FrmListaDClientes()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarClientes();
        }

        private void ConfigurarListView()
        {
            // Configura o ListView com colunas
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("Nome", 150);
            listViewClientes.Columns.Add("Código", 80);
            listViewClientes.Columns.Add("Telefone", 120);
            listViewClientes.Columns.Add("CPF", 120);
            listViewClientes.Columns.Add("Endereço", 200);
            listViewClientes.FullRowSelect = true;
        }

        private void CarregarClientes(string filtro = "")
        {
            // Limpa o ListView
            listViewClientes.Items.Clear();

            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de clientes não encontrado!");
                return;
            }

            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(caminhoArquivo);

            // Filtra as linhas conforme o termo de busca
            var linhasFiltradas = linhas
                .Where(l => string.IsNullOrWhiteSpace(filtro) || l.ToLower().Contains(filtro.ToLower()))
                .ToList();

            // Adiciona as linhas ao ListView
            foreach (var linha in linhasFiltradas)
            {
                var dados = linha.Split(new[] { ", " }, StringSplitOptions.None);

                // Verifica se a linha tem o formato esperado
                if (dados.Length >= 5)
                {
                    // Extrai os dados do cliente
                    string nome = dados[0].Replace("Nome: ", "");
                    string codigo = dados[1].Replace("Código: ", "");
                    string telefone = dados[2].Replace("Telefone: ", "");
                    string cpf = dados[3].Replace("CPF: ", "");
                    string endereco = dados[4].Replace("Endereço: ", "");

                    // Aplica a máscara para o telefone e CPF
                    telefone = FormatTelefone(telefone);
                    cpf = FormatCPF(cpf);

                    // Cria o item do ListView
                    var item = new ListViewItem(nome);
                    item.SubItems.Add(codigo);
                    item.SubItems.Add(telefone);
                    item.SubItems.Add(cpf);
                    item.SubItems.Add(endereco);
                    listViewClientes.Items.Add(item);
                }
            }
        }

        // Função para formatar o CPF no formato 000.000.000-00
        private string FormatCPF(string cpf)
        {
            if (cpf.Length == 11)
            {
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
            }
            return cpf;
        }

        // Função para formatar o Telefone no formato (00)00000-0000
        private string FormatTelefone(string telefone)
        {
            if (telefone.Length == 11)
            {
                return $"({telefone.Substring(0, 2)}){telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
            }
            return telefone;
        }



        private void FrmListaDClientes_Load(object sender, EventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            string termoPesquisa = txtPesquisa.Text;
            CarregarClientes(termoPesquisa);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewClientes.SelectedItems.Count > 0)
            {
                var itemSelecionado = listViewClientes.SelectedItems[0];
                string clienteRemover = $"Nome: {itemSelecionado.Text}, Código: {itemSelecionado.SubItems[1].Text}, Telefone: {itemSelecionado.SubItems[2].Text}, CPF: {itemSelecionado.SubItems[3].Text}, Endereço: {itemSelecionado.SubItems[4].Text}";

                // Carrega todas as linhas do arquivo
                var linhas = File.ReadAllLines(caminhoArquivo).ToList();

                // Remove o cliente selecionado
                linhas.Remove(clienteRemover);

                // Reescreve o arquivo sem o cliente removido
                File.WriteAllLines(caminhoArquivo, linhas);

                // Atualiza o ListView
                CarregarClientes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }
    }
}
