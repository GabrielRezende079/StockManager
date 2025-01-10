using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Gerenciador_de_Estoque
{
    public partial class FrmEstoqueGeral : Form
    {

        private string caminhoArquivo = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms\EstoqueBD.txt";

        public FrmEstoqueGeral()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarProdutos();
        }

        private void ConfigurarListView()
        {
            // Configura o ListView com colunas
            listViewEstoque.View = View.Details;
            listViewEstoque.Columns.Add("Produto", 100);
            listViewEstoque.Columns.Add("Marca", 150);
            listViewEstoque.Columns.Add("Código", 80);
            listViewEstoque.Columns.Add("Valor", 80);
            listViewEstoque.Columns.Add("Entrada", 120);
            listViewEstoque.Columns.Add("Saída", 120);
            listViewEstoque.Columns.Add("Quantidade", 100);
            listViewEstoque.Columns.Add("Categoria", 120);
            listViewEstoque.FullRowSelect = true;
        }

        private void CarregarProdutos(string filtro = "")
        {
            // Limpa o ListView
            listViewEstoque.Items.Clear();

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
                if (dados.Length >= 8)
                {
                    // Extrai os dados do cliente
                    string nomeProduto = dados[0].Replace("Produto: ", "");
                    string marca = dados[1].Replace("Marca: ", "");
                    string codigo = dados[2].Replace("Código: ", "");
                    string valor = dados[3].Replace("Valor: ", "");
                    string entrada = dados[4].Replace("Entrada: ", "");
                    string saida = dados[5].Replace("Saída: ", "");
                    string quantidade = dados[6].Replace("Quantidade: ", "");
                    string categoria = dados[7].Replace("Categoria: ", "");


                    // Cria o item do ListView
                    var item = new ListViewItem(nomeProduto);
                    item.SubItems.Add(marca);
                    item.SubItems.Add(codigo);
                    item.SubItems.Add(valor);
                    item.SubItems.Add(entrada);
                    item.SubItems.Add(saida);
                    item.SubItems.Add(quantidade);
                    item.SubItems.Add(categoria);
                    listViewEstoque.Items.Add(item);
                }
            }
        }

        public void ExportarParaExcel()
        {
            try
            {
                // Crie uma nova aplicação Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Adicione um novo workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Estoque";

                // Leitura do arquivo VendasBD.txt
                string[] linhas = File.ReadAllLines("EstoqueBD.txt");

                // Adiciona cabeçalhos
                worksheet.Cells[1, 1] = "Produto";
                worksheet.Cells[1, 2] = "Marca";
                worksheet.Cells[1, 3] = "Codigo";
                worksheet.Cells[1, 4] = "Valor";
                worksheet.Cells[1, 5] = "Data de Entrada";
                worksheet.Cells[1, 6] = "Data de Saida";
                worksheet.Cells[1, 7] = "Quantidade";
                worksheet.Cells[1, 8] = "Categoria";

                int linhaExcel = 2; // Começa na segunda linha, após os cabeçalhos

                // Preenche as células com os dados do arquivo
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(','); // Supondo que os dados estejam separados por ";"
                    for (int i = 0; i < dados.Length; i++)
                    {
                        worksheet.Cells[linhaExcel, i + 1] = dados[i];
                    }
                    linhaExcel++;
                }

                // Ajusta as colunas
                worksheet.Columns.AutoFit();

                // Opcional: Salvar o arquivo Excel automaticamente
                workbook.SaveAs("C:\\Users\\Pichau\\Desktop\\Exercicios coding\\Wms\\Estoque.xlsx");
                workbook.Close();
                excelApp.Quit();
                Console.WriteLine("Exportação concluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao exportar: " + ex.Message);
            }
        }

        private void listViewEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisa.Text;
            CarregarProdutos(termoPesquisa);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewEstoque.SelectedItems.Count > 0)
            {
                var itemSelecionado = listViewEstoque.SelectedItems[0];
                string clienteRemover = $"Produto: {itemSelecionado.Text}, Marca: {itemSelecionado.SubItems[1].Text}" +
                    $", Código: {itemSelecionado.SubItems[2].Text}, Valor: {itemSelecionado.SubItems[3].Text}, Entrada: {itemSelecionado.SubItems[4].Text}, Saída: {itemSelecionado.SubItems[5].Text}, Quantidade: {itemSelecionado.SubItems[6].Text}, Categoria: {itemSelecionado.SubItems[7].Text}";

                // Carrega todas as linhas do arquivo
                var linhas = File.ReadAllLines(caminhoArquivo).ToList();

                // Remove o cliente selecionado
                linhas.Remove(clienteRemover);

                // Reescreve o arquivo sem o cliente removido
                File.WriteAllLines(caminhoArquivo, linhas);

                // Atualiza o ListView
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Pichau\\Desktop\\Exercicios coding\\Wms\\EstoqueBD.txt";
            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start("notepad.exe", filePath);
            }
            else
            {
                MessageBox.Show("O arquivo EstoqueBD.txt não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEstoqueGeral_Load(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarParaExcel();
        }
    }
}
