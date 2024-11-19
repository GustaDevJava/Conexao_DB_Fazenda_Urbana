using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Conexao
{
    public partial class FzAlterarProduto : Form
    {
        private Funcionario _logado;
        private string caminhoImagem;
        private Produto _produtoAltera;
        private SqlConnection conexao;
        public FzAlterarProduto(Funcionario logado, Produto produtoAltera)
        {
            InitializeComponent();
            _logado = logado;
            _produtoAltera = produtoAltera;
            PopulaTela(produtoAltera);
        }

        private void PopulaTela(Produto produtoAltera)
        {
            tbAlterarNomeProduto.Text = produtoAltera.Nome;
            tbAlterarPreco.Text = produtoAltera.Preco.ToString();
            tbAlterarQuantidade.Text = produtoAltera.Quantidade.ToString();
            var imagem = CarregarImagem(produtoAltera.Imagem);
            if (imagem != null)
            {
                pbImagem.Image = imagem;
            }
            else
            {
                pbImagem.Image = null; // Define vazio se não conseguir carregar
            }
        }

        private Image CarregarImagem(string caminho)
        {
            try
            {
                // Verifica se é uma URL válida
                if (Uri.TryCreate(caminho, UriKind.Absolute, out Uri uriResult) &&
                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    using (var httpClient = new HttpClient())
                    {
                        // Baixa a imagem como um array de bytes
                        var bytes = httpClient.GetByteArrayAsync(caminho).Result;

                        // Converte os bytes em um fluxo e cria a imagem
                        using (var ms = new MemoryStream(bytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }

                // Caso seja um arquivo local, carrega diretamente
                if (File.Exists(caminho))
                {
                    return Image.FromFile(caminho);
                }

                throw new Exception("O caminho especificado não é válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Retorna nulo se não conseguir carregar a imagem
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FzInicial fz = new FzInicial(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FzProdutos fz = new FzProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FzCadastrarProdutos fz = new FzCadastrarProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnPlantar_Click(object sender, EventArgs e)
        {
            FzPlantarSelect fz = new FzPlantarSelect(_logado);
            this.Hide();
            fz.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Arquivos de imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Selecione uma Imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salva o caminho da imagem
                    caminhoImagem = openFileDialog.FileName;

                    // Exibe a imagem no PictureBox
                    pbImagem.Image = Image.FromFile(caminhoImagem);
                    pbImagem.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta o tamanho da imagem
                }
            }
        }

        private void btnCancelarFz_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void tbAlterarProdutoFz_Click(object sender, EventArgs e)
        {
            _produtoAltera.Nome = tbAlterarNomeProduto.Text;
            _produtoAltera.Quantidade = int.Parse(tbAlterarQuantidade.Text);
            if (caminhoImagem != null)
            {
                _produtoAltera.Imagem = caminhoImagem;
            }
           if (double.TryParse(tbAlterarPreco.Text, out double preco))
            {
                _produtoAltera.Preco = preco;
            }
            else
            {
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexao = clnConexao.getConexao();

            ProdutoDAL dAL = new ProdutoDAL();

            try
            {
                dAL.abrirConexao(conexao);
                dAL.AlteraProduto(conexao, _produtoAltera);

                MessageBox.Show("Produto Alterado com Sucesso!");

                FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
                this.Hide();
                fz.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Produto", ex.Message);
            }
        }
    }
}
