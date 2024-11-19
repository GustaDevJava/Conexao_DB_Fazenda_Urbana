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
using Teste_Conexao.Rh;

namespace Teste_Conexao
{
    public partial class FuncionarioAtualizar : Form
    {
        Funcionario _logado;
        string caminhoImagem;
        SqlConnection _conexao;
        public FuncionarioAtualizar(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
            PopulaCampos(logado);
            label5.Text = _logado.Nome.ToString();
        }

        private void PopulaCampos(Funcionario funcionario) 
        {
            lbNomeFuncInfo.Text = funcionario.Nome;
            tbNRF.Text = funcionario.Id.ToString();
            tbFuncao.Text = funcionario.Funcao;
            tbSupervisor.Text = funcionario.NomeGerente;
            tbDataAdmissao.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
            tbSalario.Text = funcionario.Salario.ToString("C2");
            tbCpf.Text = funcionario.Cpf;
            tbNasc.Text = funcionario.DataNascimento.ToString();
            tbCpf.Text = funcionario.Cpf.ToString();
            tbEmail.Text = funcionario.Email;
            tbSenha.Text = funcionario.Senha;
            tbFone.Text = funcionario.Celular;
            if (!string.IsNullOrEmpty(funcionario.Imagem))
            {
                var imagem = CarregarImagem(funcionario.Imagem);
                pbImagem.Image = imagem ?? null; // Define null se não conseguir carregar
            }
            else
            {
                pbImagem.Image = null; // Define vazio caso a propriedade Imagem seja nula ou vazia
            }
        }

        private void tbNasc_TextChanged(object sender, EventArgs e)
        {

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

        private void btnDemitir_Click(object sender, EventArgs e)
        {
            _conexao = clnConexao.getConexao();
            FuncionarioFazDAL dAL = new FuncionarioFazDAL();

            Funcionario funcionario = new Funcionario();

            funcionario.Id = string.IsNullOrEmpty(tbNRF.Text) ? 0 : int.Parse(tbNRF.Text);
            funcionario.Nome = lbNomeFuncInfo.Text;
            funcionario.Funcao = tbFuncao.Text;
            funcionario.NomeGerente = tbSupervisor.Text;
            funcionario.Salario = string.IsNullOrEmpty(tbSalario.Text)
                ? 0
                : double.Parse(tbSalario.Text, System.Globalization.NumberStyles.Currency);
            funcionario.Cpf = tbCpf.Text;
            funcionario.DataNascimento = string.IsNullOrEmpty(tbNasc.Text)
                ? DateTime.MinValue
                : DateTime.Parse(tbNasc.Text);
            funcionario.Email = tbEmail.Text;
            funcionario.Senha = tbSenha.Text;
            funcionario.Celular = tbFone.Text;
            funcionario.Imagem = pbImagem.Image.ToString();

            try
            {
                dAL.abrirConexao(_conexao);
                dAL.AtualizarFuncionario(_conexao, funcionario.Id, funcionario);

                MessageBox.Show("Atualizado com sucesso!");

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                dAL.fecharConexao(_conexao);
            }
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            switch (_logado.Funcao)
            {
                case "RH":
                    RhInitial rh = new RhInitial(_logado);
                    this.Hide();
                    rh.Show();
                    break;
                case "Fazendeiro":
                    FzInicial fz = new FzInicial(_logado);
                    this.Hide();
                    fz.Show();
                    break;
                case "Gerente":
                    GrInicial gr = new GrInicial(_logado);
                    this.Hide();
                    gr.Show();
                    break;
                default:
                    MessageBox.Show("Funcionario: " + _logado.Nome + " não tem função");
                    break;
            }
        }
    }
}
