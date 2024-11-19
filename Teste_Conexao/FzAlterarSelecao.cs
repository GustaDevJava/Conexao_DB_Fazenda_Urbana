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
    public partial class FzAlterarSelecao : Form
    {
        private Funcionario _logado;
        private SqlConnection _conexao;
        public FzAlterarSelecao(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;

            // Configurar o FlowLayoutPanel
            ConfigurarFlowLayoutPanel();

            // Carregar produtos do banco de dados
            CarregarProdutos();

            // Evento para redimensionamento dinâmico
            this.SizeChanged += FzProdutos_SizeChanged;
        }

        private void ConfigurarFlowLayoutPanel()
        {
            flpProdutos.AutoScroll = true; // Habilita scroll
            flpProdutos.WrapContents = true; // Permite quebra de linha
            flpProdutos.FlowDirection = FlowDirection.LeftToRight; // Alinha horizontalmente
        }

        private void CarregarProdutos()
        {
            // Limpa o FlowLayoutPanel antes de adicionar os produtos
            flpProdutos.Controls.Clear();

            // Obter os produtos do banco de dados
            List<Produto> produtos = ObterProdutosDoBanco();

            foreach (var produto in produtos)
            {
                // Cria o painel do produto
                Panel panelProduto = CriarPanelProduto(produto);

                // Adiciona evento de clique ao painel
                panelProduto.Click += (s, e) => AbrirDetalhesProduto(produto);

                // Adiciona eventos de clique para controles internos
                foreach (Control control in panelProduto.Controls)
                {
                    control.Click += (s, e) => AbrirDetalhesProduto(produto);
                }

                // Adiciona o painel ao FlowLayoutPanel
                flpProdutos.Controls.Add(panelProduto);
            }
        }

        private Panel CriarPanelProduto(Produto produto)
        {
            Panel panel = new Panel
            {
                Width = 150, // Largura
                Height = 200, // Altura
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10) // Espaçamento entre os painéis
            };

            // Adiciona imagem do produto
            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = produto.Imagem, // URL ou caminho local
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 130,
                Height = 130,
                Location = new Point(10, 10) // Margem interna
            };

            // Adiciona nome do produto
            Label lblNome = new Label
            {
                Text = produto.Nome,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 130,
                Height = 20,
                Location = new Point(10, 150)
            };

            // Adiciona preço do produto
            Label lblPreco = new Label
            {
                Text = $"R$ {produto.Preco:F2}",
                Font = new Font("Arial", 9),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 130,
                Height = 20,
                Location = new Point(10, 170)
            };

            // Adiciona os controles ao painel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblNome);
            panel.Controls.Add(lblPreco);

            return panel;
        }

        private List<Produto> ObterProdutosDoBanco()
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                _conexao = clnConexao.getConexao();
                ProdutoDAL produtoDAL = new ProdutoDAL();
                produtoDAL.abrirConexao(_conexao);

                // Obter produtos do banco de dados
                produtos = produtoDAL.BuscarProdutos(_conexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao != null && _conexao.State == System.Data.ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }

            return produtos;
        }

        private void AbrirDetalhesProduto(Produto produto)
        {
            // Exemplo: Abre um formulário com detalhes do produto
            FzAlterarProduto detalhes = new FzAlterarProduto(_logado, produto);
            this.Hide();
            detalhes.Show();
        }

        private void FzProdutos_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control panel in flpProdutos.Controls)
            {
                panel.Width = flpProdutos.ClientSize.Width / 5 - 20; // Ajusta largura de acordo com o tamanho da janela
            }
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
    }
}
