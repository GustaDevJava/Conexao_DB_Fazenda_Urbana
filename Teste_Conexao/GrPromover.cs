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

namespace Teste_Conexao
{
    public partial class GrPromover : Form
    {
        private Funcionario _logado;
        private SqlConnection conexao;
        public GrPromover(Funcionario logado)
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
            List<Promocao> promocoesPorGerente = new List<Promocao>();

            for (int i = 0; i < promocoes.Count; i++) 
            { 
                Promocao promocao = promocoes[i];
                if (promocao.IdGerente == _logado.Id)
                {
                    promocoesPorGerente.Add(promocao);
                }
                
            }

            foreach (var promocao in promocoesPorGerente)
            {
                // Criar painel com bordas arredondadas para representar a promoção
                Panel panelPromocao = CriarPanelArredondado(flpPromocoes.ClientSize.Width - 20, 180, Color.LightGreen);

                // Adicionar as informações da promoção no painel
                Label lblNomeFuncionario = new Label
                {
                    Text = "Nome funcionário: " + promocao.NomeFuncionario,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10) // Posição dentro do painel
                };

                Label lblFuncaoAtual = new Label
                {
                    Text = "Função: " + promocao.FuncaoAtual,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 40)
                };

                Label lblNovaFuncao = new Label
                {
                    Text = "Nova função: " + promocao.NovaFuncao,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 60)
                };

                Label lblSalarios = new Label
                {
                    Text = $"Salário atual: {promocao.SalarioAtual:C}, Salário novo: {promocao.NovoSalario:C}",
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 80)
                };

                Label lblDataAdmissao = new Label
                {
                    Text = "Data de admissão: " + promocao.DataAdmissao.ToString("dd/MM/yyyy"),
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 100)
                };

                // Novo Label para exibir o status da promoção
                Label lblStatus = new Label
                {
                    Text = "Status: " + promocao.Status,
                    Font = new Font("Arial", 9, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 120)
                };


                // Adiciona os controles ao painel
                panelPromocao.Controls.Add(lblNomeFuncionario);
                panelPromocao.Controls.Add(lblFuncaoAtual);
                panelPromocao.Controls.Add(lblNovaFuncao);
                panelPromocao.Controls.Add(lblSalarios);
                panelPromocao.Controls.Add(lblDataAdmissao);
                panelPromocao.Controls.Add(lblStatus);

                // Adiciona o painel ao FlowLayoutPanel
                flpPromocoes.Controls.Add(panelPromocao);
            }
        }

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

        private void PromocoesRh_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control panel in flpPromocoes.Controls)
            {
                panel.Width = flpPromocoes.ClientSize.Width - 20; // Ajusta largura
            }
        }

        private void btnSolicita_Click(object sender, EventArgs e)
        {
            GrFuncionarioSelect grFuncionarioSelect = new GrFuncionarioSelect(_logado);
            this.Hide();
            grFuncionarioSelect.Show();
        }
    }
}
