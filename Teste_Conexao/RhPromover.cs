using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Conexao.Rh;

namespace Teste_Conexao
{
    public partial class RhPromover : Form
    {
        SqlConnection conexao;
        private Funcionario _logado;
        public RhPromover(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
            CarregarPromocoes();
            this.SizeChanged += PromocoesRh_SizeChanged;
        }

        private void CarregarPromocoes()
        {
            // Limpar o FlowLayoutPanel antes de carregar novos dados
            flpPromocoes.Controls.Clear();

            conexao = clnConexao.getConexao();

            PromocaoDAL dAL = new PromocaoDAL();
            dAL.abrirConexao(conexao);

            // Obter os dados das promoções
            List<Promocao> promocoes = dAL.ListarPromocoes(conexao);

            foreach (var promocao in promocoes)
            {
                // Criar painel com bordas arredondadas para representar a promoção
                Panel panelPromocao = CriarPanelArredondado(flpPromocoes.ClientSize.Width - 20, 200, Color.LightGreen);

                // Adicionar as informações da promoção no painel
                Label lblNomeFuncionario = new Label
                {
                    Text = "Nome funcionário: " + promocao.NomeFuncionario,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10) // Posição dentro do painel
                };

                Label lblIdFuncionario = new Label
                {
                    Text = "ID do Funcionário: " + promocao.IdFuncionarioPromovido,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 30) // Posição abaixo do nome do funcionário
                };

                Label lblFuncaoAtual = new Label
                {
                    Text = "Função: " + promocao.FuncaoAtual,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 50)
                };

                Label lblNovaFuncao = new Label
                {
                    Text = "Nova função: " + promocao.NovaFuncao,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 70)
                };

                Label lblSalarios = new Label
                {
                    Text = $"Salário atual: {promocao.SalarioAtual:C}, Salário novo: {promocao.NovoSalario:C}",
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 90)
                };

                Label lblDataAdmissao = new Label
                {
                    Text = "Data de admissão: " + promocao.DataAdmissao.ToString("dd/MM/yyyy"),
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 110)
                };

                // Novo Label para exibir o status da promoção
                Label lblStatus = new Label
                {
                    Text = "Status: " + promocao.Status,
                    Font = new Font("Arial", 9, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 130)
                };

                // Botão de confirmar promoção
                Button btnConfirmar = new Button
                {
                    Text = "CONFIRMAR",
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    BackColor = Color.White,
                    Width = 100,
                    Height = 30,
                    Location = new Point(panelPromocao.Width - 120, 160) // Posição no painel
                };

                // Associar o objeto "Promocao" ao botão usando a propriedade "Tag"
                btnConfirmar.Tag = promocao;
                btnConfirmar.Click += BtnConfirmar_Click;

                // Adiciona os controles ao painel
                panelPromocao.Controls.Add(lblNomeFuncionario);
                panelPromocao.Controls.Add(lblIdFuncionario); // Adicionar o Label com o ID
                panelPromocao.Controls.Add(lblFuncaoAtual);
                panelPromocao.Controls.Add(lblNovaFuncao);
                panelPromocao.Controls.Add(lblSalarios);
                panelPromocao.Controls.Add(lblDataAdmissao);
                panelPromocao.Controls.Add(lblStatus);
                panelPromocao.Controls.Add(btnConfirmar);

                // Adiciona o painel ao FlowLayoutPanel
                flpPromocoes.Controls.Add(panelPromocao);
            }
        }



        // Método para criar um painel com bordas arredondadas
        private Panel CriarPanelArredondado(int largura, int altura, Color corFundo)
        {
            Panel panel = new Panel
            {
                Width = largura,
                Height = altura,
                BackColor = corFundo
            };

            panel.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Define as bordas arredondadas
                GraphicsPath path = new GraphicsPath();
                int raio = 20; // Raio das bordas
                path.AddArc(0, 0, raio, raio, 180, 90); // Canto superior esquerdo
                path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90); // Superior direito
                path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90); // Inferior direito
                path.AddArc(0, panel.Height - raio, raio, raio, 90, 90); // Inferior esquerdo
                path.CloseAllFigures();

                panel.Region = new Region(path); // Aplica o recorte arredondado
            };

            return panel;
        }

        // Evento para redimensionamento dinâmico dos painéis
        private void PromocoesRh_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control panel in flpPromocoes.Controls)
            {
                panel.Width = flpPromocoes.ClientSize.Width - 20; // Ajusta largura
            }
        }

        // Método para o evento de clique do botão "Confirmar"
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Recuperar o botão que disparou o evento
            Button btn = sender as Button;

            // Recuperar a promoção associada ao botão
            Promocao promocaoSelecionada = btn.Tag as Promocao;

            if (promocaoSelecionada != null)
            {
                conexao = clnConexao.getConexao();
                FuncionarioFazDAL funcionarioFazDAL = new FuncionarioFazDAL();
                PromocaoDAL promocaoDAL = new PromocaoDAL();

                try
                {
                    funcionarioFazDAL.abrirConexao(conexao);
                    Funcionario promovido = funcionarioFazDAL.BuscarFuncionarioPorId(conexao, promocaoSelecionada.IdFuncionarioPromovido);

                    funcionarioFazDAL.AtualizarFuncionario(conexao, promovido.Id, promocaoSelecionada.NovaFuncao, (double)promocaoSelecionada.NovoSalario);

                    promocaoDAL.abrirConexao(conexao);
                    promocaoDAL.AtualizarStatusPromocao(conexao, promocaoSelecionada.PromocaoId, "Aprovado");
                    MessageBox.Show("Funcionario promovido com sucesso!");

                    RhPromover rh = new RhPromover(_logado);
                    this.Hide();
                    rh.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally
                {
                    promocaoDAL.fecharConexao(conexao);
                    funcionarioFazDAL.fecharConexao(conexao);
                }
               
            }
            else
            {
                MessageBox.Show("Erro ao acessar a promoção associada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RhCadastroFuncionario rh = new RhCadastroFuncionario(_logado, null);
            this.Hide();
            rh.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            RhFuncionarios rh = new RhFuncionarios(_logado);
            this.Hide();
            rh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            RhInitial rh = new RhInitial(_logado);
            this.Hide();
            rh.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
