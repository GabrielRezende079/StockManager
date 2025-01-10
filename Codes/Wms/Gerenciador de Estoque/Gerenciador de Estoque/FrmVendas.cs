using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque
{
    public partial class FrmVendas : Form
    {
        private string caminhoArquivo = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms\VendasBD.txt";
        private Dictionary<string, string> clientes;

        public FrmVendas()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarVendas();
        }

        private void ConfigurarListView()
        {
            // Configura o ListView com colunas
            listViewHistorico.View = View.Details;
            listViewHistorico.Columns.Add("Produto", 100);
            listViewHistorico.Columns.Add("Cliente", 150);
            listViewHistorico.Columns.Add("Veículo", 150);
            listViewHistorico.Columns.Add("Data", 100);
            listViewHistorico.FullRowSelect = true;
        }

        private void CarregarVendas(string filtro = "")
        {

            // Limpa o ListView
            listViewHistorico.Items.Clear();

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
                if (dados.Length >= 4)
                {
                    // Extrai os dados do cliente
                    string codigoProduto = dados[0].Replace("Produto: ", "");
                    string codigoCliente = dados[1].Replace("Cliente: ", "");
                    string veiculo = dados[2].Replace("Veículo: ", "");
                    string data = dados[3].Replace("Data: ", "");



                    // Cria o item do ListView
                    var item = new ListViewItem(codigoProduto);
                    item.SubItems.Add(codigoCliente);
                    item.SubItems.Add(veiculo);
                    item.SubItems.Add(data);
                    listViewHistorico.Items.Add(item);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigoProduto.Text;
            string codigoCliente = txtCodigoCliente.Text;
            string veiculo = txtValor.Text;
            string data = maskedTxtData.Text;

            // Define o caminho do arquivo onde os dados serão salvos
            string caminhoDiretorio = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms";
            string caminhoArquivo = Path.Combine(caminhoDiretorio, "VendasBD.txt");

            // Verifica se o diretório existe e o cria, se necessário
            if (!Directory.Exists(caminhoDiretorio))
            {
                Directory.CreateDirectory(caminhoDiretorio);
            }

            // Organiza os dados em uma linha formatada
            string dadosProduto = $"Produto: {codigoProduto}, Cliente: {codigoCliente}, Veículo: {veiculo}, " +
                $"Data: {data}";

            try
            {
                // Salva os dados no arquivo, adicionando uma nova linha para cada item
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                {
                    sw.WriteLine(dadosProduto);
                }

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
            }
        }

        private void listViewHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = TxtBuscar.Text;
            CarregarVendas(termoPesquisa);
        }

        private void btnExcluirTudo_Click(object sender, EventArgs e)
        {
            // Confirmação para exclusão
            var resultado = MessageBox.Show("Tem certeza de que deseja excluir todo o histórico de vendas?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Apaga o conteúdo do arquivo de vendas
                File.WriteAllText(caminhoArquivo, string.Empty);

                // Limpa o ListView de vendas
                listViewHistorico.Items.Clear();

                MessageBox.Show("Histórico de vendas excluído com sucesso.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
