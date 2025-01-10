using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string senha = txtSenha.Text;

            if (VerificarLogin(usuario, senha))
            {
             
                // Abre o formulário principal
                Main mainForm = new Main();
                mainForm.Show();


            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool VerificarLogin(string usuario, string senha)
        {
            // Caminho do arquivo onde estão armazenados os usuários e senhas
            string caminhoArquivo = "C:\\Users\\Pichau\\Desktop\\Exercicios coding\\Wms\\usuarios.txt";

            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.");
                return false;
            }

            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(caminhoArquivo);

            // Procura por uma linha que corresponda ao usuário e senha fornecidos
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length == 2)
                {
                    string usuarioArquivo = dados[0];
                    string senhaArquivo = dados[1];

                    if (usuario == usuarioArquivo && senha == senhaArquivo)
                    {
                        return true;
                    }
                }
            }

            return false;
        }



    }
   
}


