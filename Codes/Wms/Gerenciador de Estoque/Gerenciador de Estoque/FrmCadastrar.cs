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
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        public bool ValidarCPF(string cpf)
        {
            // Remove caracteres especiais
            cpf = cpf.Replace(",", "").Replace("-", "");

            // Verifica se o CPF tem 11 dígitos e se não é uma sequência de números iguais
            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
            {
                return false;
            }

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            // Calcula o segundo dígito verificador
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomeCliente = txtNome.Text;
            string codigo = txtCodigo.Text;
            string telefone = maskedTXTtelefone.Text;
            string cpf = maskedTXTCPF.Text;
            string endereco = TxtEndereço.Text;

            if (!ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido. Por favor, insira um CPF válido.");
                return;
            }

            // Define o caminho do arquivo onde os dados serão salvos
            string caminhoDiretorio = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms";
            string caminhoArquivo = Path.Combine(caminhoDiretorio, "BD.txt");

            // Verifica se o diretório existe e o cria, se necessário
            if (!Directory.Exists(caminhoDiretorio))
            {
                Directory.CreateDirectory(caminhoDiretorio);
            }

            // Organiza os dados em uma linha formatada
            string dadosProduto = $"Nome: {nomeCliente}, Código: {codigo}, " +
                $"Telefone: {telefone}, CPF: {cpf}, Endereço: {endereco}";

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

        private void maskedTXTtelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void panelCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void maskedTXTCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
