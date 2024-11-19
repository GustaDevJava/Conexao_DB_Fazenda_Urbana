using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Conexao.Rh;

namespace Teste_Conexao
{
    public partial class RhCadastroFuncionario : Form
    {
        Funcionario _funcionarioLogado;

        Funcionario _funcionadoRetornoEnd;
        public RhCadastroFuncionario(Funcionario funcionarioLogado, Funcionario funcRetornado)
        {
            InitializeComponent();
            PreencherComboBoxFuncoes();
            _funcionarioLogado = funcionarioLogado;
            _funcionadoRetornoEnd = funcRetornado;

            if (funcRetornado != null) 
            {
                PreencherCamposComDadosDoFuncionario(funcRetornado);
            }
            
            
        }

        private void PreencherComboBoxFuncoes()
        {
            // Limpa o ComboBox caso tenha dados anteriores
            cbFuncao.Items.Clear();

            // Adiciona as funções ao ComboBox
            cbFuncao.Items.Add("Gerente");
            cbFuncao.Items.Add("RH");
            cbFuncao.Items.Add("Fazendeiro");
        }

        private void tbContinuar_Click(object sender, EventArgs e)
        {
            Funcionario novoFunc = new Funcionario();

            novoFunc.Nome = tbNome.Text;
            novoFunc.Cpf = tbCpf.Text;
            novoFunc.Email = tbEmail.Text;
            novoFunc.Celular = tbTelefone.Text;
            novoFunc.Funcao = cbFuncao.SelectedItem.ToString();
            novoFunc.Senha = tbEmail.Text;
            novoFunc.NomeGerente = tbGerente.Text;

            try
            {
                // Converte o texto do TextBox para DateTime
                novoFunc.DataNascimento = DateTime.Parse(tbDataNasc.Text);
            }
            catch (FormatException)
            {
                // Exibe uma mensagem se a conversão falhar
                MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (int.TryParse(tbUnidade.Text, out int unidade))
            {
                novoFunc.FazendaId = unidade;
            }
            else
            {
                MessageBox.Show("O valor informado para a Unidade não é válido. Insira um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

           
            if (double.TryParse(tbSalario.Text, out double salario))
            {
                novoFunc.Salario = salario;
            }
            else
            {
                MessageBox.Show("O valor informado para o Salário não é válido. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RhCadastrarFuncEnd contEndereco = new RhCadastrarFuncEnd(_funcionarioLogado, novoFunc);
            this.Hide();
            contEndereco.Show();
        }


        private void PreencherCamposComDadosDoFuncionario(Funcionario funcionario)
        {
            // Preenche os campos com os dados do objeto _funcionadoRetornoEnd
            tbNome.Text = funcionario.Nome;
            tbCpf.Text = funcionario.Cpf;
            tbEmail.Text = funcionario.Email;
            tbTelefone.Text = funcionario.Celular;
            cbFuncao.Text = funcionario.Funcao;
            tbDataNasc.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
            tbUnidade.Text = funcionario.FazendaId.ToString();
            tbSalario.Text = funcionario.Salario.ToString("F2");
            tbGerente.Text = funcionario.NomeGerente.ToString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            RhInitial rhInitial = new RhInitial(_funcionarioLogado);
            this.Hide();
            rhInitial.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            RhFuncionarios rh = new RhFuncionarios(_funcionarioLogado);
            this.Hide();
            rh.Show();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            RhPromover rh = new RhPromover(_funcionarioLogado);
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
