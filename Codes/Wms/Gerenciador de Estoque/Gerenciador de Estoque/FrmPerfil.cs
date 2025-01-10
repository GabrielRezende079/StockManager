using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque
{
    public partial class FrmPerfil : Form
    {
        private string caminhoArquivo = @"C:\Users\Pichau\Desktop\Exercicios coding\Wms\usuarios.txt";

        public FrmPerfil()
        {
            InitializeComponent();
            ConfigurarListView();
            CarregarList();
        }


        private void ConfigurarListView()
        {
            listViewUsuarios.View = View.Details;
            listViewUsuarios.Columns.Add("Usuarios",150);
            listViewUsuarios.Columns.Add("Senha",150);
            listViewUsuarios.FullRowSelect = true;

        }

        private void CarregarList( string filtro = "")
        {
            // Limpa o ListView
            listViewUsuarios.Items.Clear();

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
            foreach (var linha in linhasFiltradas)
            {
                var dados = linha.Split(new[] { ";" }, StringSplitOptions.None);

                // Verifica se a linha tem o formato esperado
                if (dados.Length >= 2)
                {
                    // Extrai os dados do cliente
                    string novoUsuario = dados[0].Replace("Usuario: ","");
                    string novaSenha = dados[1].Replace("Senha: ","");


                    // Cria o item do ListView
                    var item = new ListViewItem(novoUsuario);
                    item.SubItems.Add(novaSenha);
                    listViewUsuarios.Items.Add(item);
                }
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void TxtCriarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCriarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            string novoUsuario = TxtCriarUsuario.Text;
            string novaSenha = TxtCriarSenha.Text;

            if (string.IsNullOrWhiteSpace(novoUsuario) || string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show("Usuário e senha não podem estar vazios.");
                return;
            }

            if (AdicionarUsuario(novoUsuario, novaSenha))
            {
                MessageBox.Show("Usuário criado com sucesso!");
                TxtCriarUsuario.Clear();
                TxtCriarSenha.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao criar usuário. Verifique se o arquivo existe.");
            }


        }
        private bool AdicionarUsuario(string usuario, string senha)
        {
            // Caminho do arquivo onde estão armazenados os usuários e senhas

            try
            {

                // Adiciona o novo usuário e senha ao final do arquivo
                using (StreamWriter sw = File.AppendText(caminhoArquivo))
                {
                    sw.WriteLine($"{usuario};{senha}");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisar.Text;
            CarregarList(termoPesquisa);
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
