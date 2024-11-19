using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Conexao
{
    public partial class FzCadastrarProdutos : Form
    {
        private Funcionario _logado;
        private string caminhoImagem;
        SqlConnection conexao;
        public FzCadastrarProdutos(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnPlantar_Click(object sender, EventArgs e)
        {
            FzPlantarSelect fz = new FzPlantarSelect(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnSelecionaImg_Click(object sender, EventArgs e)
        {
            // Cria o OpenFileDialog para selecionar a imagem
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

        private void tbCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = tbNomeProduto.Text;
            produto.Preco = double.Parse(tbPreco.Text);
            produto.Categoria = tbCategoria.Text;
            produto.Imagem = caminhoImagem;
            produto.Quantidade = int.Parse(tbQuantidade.Text);


            conexao = clnConexao.getConexao();
            ProdutoDAL dAL = new ProdutoDAL();
            try
            {
                dAL.abrirConexao(conexao);
                dAL.CadastrarProduto(conexao, produto);

                tbNomeProduto.Text = "";
                tbPreco.Text = "";
                tbCategoria.Text = "";
                pbImagem.Image = null;
                tbQuantidade.Text = "";

                MessageBox.Show("Produto cadastrar com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Produto!", ex.Message);
            }
        }
    }
}
