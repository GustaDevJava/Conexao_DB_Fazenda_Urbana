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
    public partial class FzPlantioForm : Form
    {
        private Funcionario _logado;
        private SqlConnection conexao;
        private string _categoria;
        private string _nomePlantio;
        private List<Produto> produtos;
        public FzPlantioForm(Funcionario logado, string categoria, string nomePlantio)
        {
            InitializeComponent();
            _logado = logado;
            _categoria = categoria;
            _nomePlantio = nomePlantio;
            PreencherComboBoxProdutos(categoria);
            tbPlantio.Text = _nomePlantio;
            PopularPlantioSeOcupado(nomePlantio);
        }

        private void PopularPlantioSeOcupado(string nomePlantio)
        {
            conexao = clnConexao.getConexao();
            PlantioDAL dAL = new PlantioDAL();
            Plantio plantio = new Plantio();

            try
            {
                dAL.abrirConexao(conexao);

                plantio = dAL.BuscarPlantioPorNome(conexao, nomePlantio);

               
                if(!string.IsNullOrEmpty(plantio.Status))
                {
                    if(plantio.Status.Equals("Em plantação"))
                    {
                        cbProdutos.Items.Clear(); // Limpa os itens existentes
                        cbProdutos.Items.Add(plantio.NomeProduto); // Adiciona o NomeProduto
                        cbProdutos.SelectedIndex = 0; // Seleciona o único item adicionado
                        tbUnidade.Text = plantio.FazendaId.ToString();
                        tbQuantidade.Text = plantio.Quantidade.ToString();
                        dtColheita.Text = plantio.DataColheita.ToString();
                        dtPlantacao.Text = plantio.DataPlantacao.ToString();

                    }
                }

                FzPlantarSelect fz = new FzPlantarSelect(_logado);
                this.Hide();
                fz.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco: " + ex.Message);
            }

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

        private void btnCancelarFz_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, _categoria);
            this.Hide();
            fz.Show();
        }

       

        private void PreencherComboBoxProdutos(string categoria)
        {

            conexao = clnConexao.getConexao();
            ProdutoDAL dAL = new ProdutoDAL();

            try
            {
                dAL.abrirConexao(conexao);

                List<Produto> listaProdutos = dAL.BuscarProdutosPorCategoria(conexao, categoria);
                produtos = listaProdutos;
                // Limpa os itens do ListBox antes de adicionar novos
                cbProdutos.Items.Clear();

                // Adiciona os nomes dos produtos ao ListBox
                foreach (Produto produto in listaProdutos)
                {
                    cbProdutos.Items.Add(produto.Nome);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao acessar banco: " + ex.Message);
            }finally
            {
                dAL.fecharConexao(conexao);
            }
          
            
        }

        private void tbAlterarProdutoFz_Click(object sender, EventArgs e)
        {
            Plantio plantio = new Plantio();
            if (cbProdutos.SelectedItem != null)
            {
                // Atribui o nome do produto selecionado
                plantio.NomeProduto = cbProdutos.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto.");
                return; // Interrompe o processo caso não tenha seleção
            }
            plantio.Status = tbStatusPlantio.Text;
            plantio.Quantidade = Convert.ToInt32(tbQuantidade.Text);
            plantio.FazendaId = Convert.ToInt32(tbUnidade.Text);
            plantio.NomePlantio = _nomePlantio;
            try
            {
                // Converte o texto do TextBox para DateTime
                plantio.DataPlantacao = DateTime.Parse(dtPlantacao.Text);
                plantio.DataColheita = DateTime.Parse(dtColheita.Text);
            }
            catch (FormatException)
            {
                // Exibe uma mensagem se a conversão falhar
                MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            plantio.Imagem = "C:\\Users\\fcngu\\git pim\\imagens\\folha vermelha.png";

            conexao = clnConexao.getConexao();
            PlantioDAL dAL = new PlantioDAL();
            
            try
            {
                dAL.abrirConexao(conexao);

                dAL.AtualizarPlantio(conexao, plantio);

                MessageBox.Show("Sucesso \n Será disponibilizado no local escolhido os itens necessarios para realizar a plantação");

                FzPlantarSelect fz = new FzPlantarSelect(_logado);
                this.Hide();
                fz.Show();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao acessar banco: " + ex.Message);
            }
        }

        private void btnColher_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            DateTime dataColheita = DateTime.Now;


            try
            {
                // Converte o texto do TextBox para DateTime
                dataColheita = DateTime.Parse(dtColheita.Text);
         
            }
            catch (FormatException)
            {
                // Exibe uma mensagem se a conversão falhar
                MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dt < dataColheita)
            {
                MessageBox.Show("A colheita não pode ser realizada, pois a data de colheita é anterior à data atual.", "Validação de Colheita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ProdutoDAL produtoDAL = new ProdutoDAL();
                PlantioDAL plantioDAL = new PlantioDAL();   
                conexao = clnConexao.getConexao();

                Produto produto = new Produto();
                if (cbProdutos.SelectedItem != null)
                {
                    foreach (Produto p in produtos)
                    {
                        if (p.Nome.Equals(cbProdutos.SelectedItem.ToString()))
                        {
                            produto.Nome = p.Nome;
                            produto.Quantidade = p.Quantidade;
                        }
                    }
                }

                produto.Quantidade += Convert.ToInt32(tbQuantidade.Text);

                try
                {
                    produtoDAL.abrirConexao(conexao);
                    produtoDAL.AlterarQuantidadeProduto(conexao, produto.Nome, produto.Quantidade);

                    plantioDAL.abrirConexao(conexao);
                    Plantio plantio = plantioDAL.BuscarPlantioPorNome(conexao, _nomePlantio);

                    plantio.NomeProduto = null;
                    plantio.Status = null;
                    plantio.Quantidade = 0;
                    plantio.FazendaId = null;
                    plantio.DataPlantacao = null;
                    plantio.DataColheita = null;
                    plantio.Imagem = "C:\\Users\\fcngu\\git pim\\imagens\\folha verde.png";

                    plantioDAL.AtualizarPlantio(conexao, plantio);

                    MessageBox.Show("Quantidade de produtos alterada com Sucesso!");

                    FzPlantarSelect fz = new FzPlantarSelect(_logado);
                    this.Hide();
                    fz.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar banco: " + ex.Message);
                }
            }

            

            
        }
    }
}
