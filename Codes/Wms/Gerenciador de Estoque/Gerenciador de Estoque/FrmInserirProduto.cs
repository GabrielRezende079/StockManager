using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque
{
    public partial class FrmInserirProduto : Form
    {
        public FrmInserirProduto()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtProduto.Text;
            string marca = txtMarca.Text;
            string codigo = txtCodigo.Text;
            string valor = txtValor.Text;
            string entrada = maskedTxtEntrada.Text;
            string saida = maskedTxtSaida.Text;
            string quantidade = txtQuantidade.Text;
            string categoria = txtCategoria.Text;

            // Define o caminho do arquivo onde os dados serão salvos
            string caminhoDiretorio = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms";
            string caminhoArquivo = Path.Combine(caminhoDiretorio, "EstoqueBD.txt");

            // Verifica se o diretório existe e o cria, se necessário
            if (!Directory.Exists(caminhoDiretorio))
            {
                Directory.CreateDirectory(caminhoDiretorio);
            }

            // Organiza os dados em uma linha formatada
            string dadosProduto = $"Produto: {nomeProduto}, Marca: {marca}, Código: {codigo}, " +
                $"Valor: {valor}, Entrada: {entrada}, Saída: {saida}, Quantidade: {quantidade}, Categoria: {categoria}";

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
