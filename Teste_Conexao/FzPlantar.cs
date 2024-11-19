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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Conexao
{
    public partial class FzPlantar : Form
    {
        private Funcionario _logado;
        private SqlConnection conexao;
        private string _categoria;
        public FzPlantar(Funcionario logado, string categoria)
        {
            InitializeComponent();
            _logado = logado;
            _categoria = categoria;
            AlteraImagem();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FzInicial fz = new FzInicial(_logado);
            this.Hide();
            fz.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void AlteraImagem()
        {
            conexao = clnConexao.getConexao();
            List<Plantio> listaPlantio = new List<Plantio>();

            PlantioDAL dAL = new PlantioDAL();

            try
            {
                dAL.abrirConexao(conexao);
                listaPlantio = dAL.BuscaListaPlantioImagem(conexao);
                AlteracaoDasImagens(listaPlantio);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco", ex.Message);
            }finally
            {
                dAL.fecharConexao(conexao);
            }
        }

        private void AlteracaoDasImagens(List<Plantio> listaPlantio)
        {
            foreach (Plantio p in listaPlantio)
            {
                if (File.Exists(p.Imagem))
                {
                    switch (p.NomePlantio)
                    {
                        case "A1":
                            pbA1.Image = Image.FromFile(p.Imagem);
                            break;

                        case "A2":
                            pbA2.Image = Image.FromFile(p.Imagem);
                            break;

                        case "A3":
                            pbA3.Image = Image.FromFile(p.Imagem);
                            break;

                        case "A4":
                            pbA4.Image = Image.FromFile(p.Imagem);
                            break;

                        case "B1":
                            pbB1.Image = Image.FromFile(p.Imagem);
                            break;

                        case "B2":
                            pbB2.Image = Image.FromFile(p.Imagem);
                            break;

                        case "B3":
                            pbB3.Image = Image.FromFile(p.Imagem);
                            break;

                        case "B4":
                            pbB4.Image = Image.FromFile(p.Imagem);
                            break;

                        default:
                            // Ação para quando o NomePlantio não corresponder a nenhum dos casos acima
                            break;
                    }


                }
            }
        }

        private void pbA1_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A1");
            this.Hide();
            fz.Show();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A1");
            this.Hide();
            fz.Show();
        }

        private void pbA2_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A2");
            this.Hide();
            fz.Show();
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A2");
            this.Hide();
            fz.Show();
        }

        private void pbA3_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A3");
            this.Hide();
            fz.Show();
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A3");
            this.Hide();
            fz.Show();
        }

        private void pbA4_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A4");
            this.Hide();
            fz.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "A4");
            this.Hide();
            fz.Show();
        }

        private void pbB1_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B1");
            this.Hide();
            fz.Show();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B1");
            this.Hide();
            fz.Show();
        }

        private void pbB2_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B2");
            this.Hide();
            fz.Show();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B2");
            this.Hide();
            fz.Show();
        }

        private void pbB3_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B3");
            this.Hide();
            fz.Show();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B3");
            this.Hide();
            fz.Show();
        }

        private void pbB4_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B4");
            this.Hide();
            fz.Show();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            FzPlantioForm fz = new FzPlantioForm(_logado, _categoria, "B4");
            this.Hide();
            fz.Show();
        }
    }
}
