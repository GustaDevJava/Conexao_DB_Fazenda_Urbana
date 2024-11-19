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
    public partial class GrFuncionarioSelect : Form
    {
        private Funcionario _logado;
        private SqlConnection conexao;
        public GrFuncionarioSelect(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
            CarregarFuncionarios();
            this.SizeChanged += RhFuncionarios_SizeChanged;
        }

        private void CarregarFuncionarios()
        {
            // Limpar o FlowLayoutPanel antes de carregar novos dados
            flpFuncionarios.Controls.Clear();

            conexao = clnConexao.getConexao();

            FuncionarioFazDAL dAL = new FuncionarioFazDAL();
            dAL.abrirConexao(conexao);

            // Obter os dados dos funcionários
            List<Funcionario> funcionarios = dAL.ListarFuncionarios(conexao);

            foreach (var funcionario in funcionarios)
            {
                // Criar painel com bordas arredondadas para representar o funcionário
                Panel panelFuncionario = CriarPanelArredondado(flpFuncionarios.ClientSize.Width - 20, 100, Color.LightGreen);

                // Adiciona evento de clique ao painel
                panelFuncionario.Click += (s, e) => AbrirDetalhesFuncionario(funcionario);

                // Adiciona as informações do funcionário no painel
                Label lblNome = new Label
                {
                    Text = "Nome: " + funcionario.Nome,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(10, 10), // Posição dentro do painel
                };

                Label lblCpf = new Label
                {
                    Text = "CPF: " + funcionario.Cpf,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 40),
                };

                Label lblFuncao = new Label
                {
                    Text = "Função: " + funcionario.Funcao,
                    Font = new Font("Arial", 9),
                    AutoSize = true,
                    Location = new Point(10, 70),
                };

                // Adiciona os labels ao painel
                panelFuncionario.Controls.Add(lblNome);
                panelFuncionario.Controls.Add(lblCpf);
                panelFuncionario.Controls.Add(lblFuncao);

                // Adiciona o painel ao FlowLayoutPanel
                flpFuncionarios.Controls.Add(panelFuncionario);
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
        private void RhFuncionarios_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control panel in flpFuncionarios.Controls)
            {
                panel.Width = flpFuncionarios.ClientSize.Width - 20; // Ajusta largura
            }
        }

        // Método para abrir detalhes do funcionário
        private void AbrirDetalhesFuncionario(Funcionario funcionario)
        {
            GrFuncionarioInfo detalhes = new GrFuncionarioInfo(_logado, funcionario);
            this.Hide();
            detalhes.Show();

        }
    }
}
