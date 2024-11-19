using DAL;
using Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Teste_Conexao.Rh;

namespace Teste_Conexao
{
    public partial class Login : Form
    {
        SqlConnection conexao;

        public Login()
        {
            InitializeComponent();

            label3.Text = "Bem-vindo de volta!";
            label3.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label3.AutoSize = true;
            label3.ForeColor = Color.White;

            // Associa os eventos das TextBox
            textEmail.Enter += textEmail_Enter;
            textEmail.Leave += textEmail_Leave;
            textSenha.Enter += textSenha_Enter;
            textSenha.Leave += textSenha_Leave;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
        }

        

        // Placeholder para textEmail
        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Digite seu e-mail")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                textEmail.Text = "Digite seu e-mail";
                textEmail.ForeColor = Color.Gray;
            }
        }

        // Placeholder para textSenha
        private void textSenha_Enter(object sender, EventArgs e)
        {
            if (textSenha.Text == "Digite sua senha")
            {
                textSenha.Text = "";
                textSenha.ForeColor = Color.Black;
                textSenha.UseSystemPasswordChar = true; // Ativa o modo de senha
            }
        }

        private void textSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSenha.Text))
            {
                textSenha.Text = "Digite sua senha";
                textSenha.ForeColor = Color.Gray;
                textSenha.UseSystemPasswordChar = false; // Desativa o modo de senha no placeholder
            }
        }

        // Evento para mostrar/ocultar senha
        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            textSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao = clnConexao.getConexao();
            string email = textEmail.Text;
            string senha = textSenha.Text;

            if (email.Equals(senha))
            { 
                PrimeiroLogin(email, senha);
            }
            else
            {

                Funcionario funcionario = new Funcionario();
                FuncionarioFazDAL dAL = new FuncionarioFazDAL();

                try
                {
                    // Abre a conexão
                    dAL.abrirConexao(conexao);

                    // Realiza o login do funcionário
                    funcionario = dAL.LoginFuncionario(conexao, email, senha);

                    if (funcionario == null)
                    {
                        // Caso o funcionário não seja encontrado
                        MessageBox.Show("Funcionário não encontrado ou credenciais inválidas.");
                        return;
                    }

                    switch (funcionario.Funcao)
                    {
                        case "RH":
                            RhInitial rh = new RhInitial(funcionario);
                            this.Hide();
                            rh.Show();
                            break;
                        case "Fazendeiro":
                            FzInicial fz = new FzInicial(funcionario);
                            this.Hide();
                            fz.Show();
                            break;
                        case "Gerente":
                            GrInicial gr = new GrInicial(funcionario);
                            this.Hide();
                            gr.Show();
                            break;
                        default:
                            MessageBox.Show("Funcionario: " + funcionario.Nome + " não tem função");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    // Caso ocorra erro durante o processo
                    MessageBox.Show("Erro ao realizar o login: " + ex.Message);
                }
                finally
                {
                    // Fecha a conexão com o banco de dados
                    dAL.fecharConexao(conexao);
                }
            }

        }

        private void PrimeiroLogin(string email, string senha)
        {
            conexao = clnConexao.getConexao();

            FuncionarioFazDAL dAL = new FuncionarioFazDAL();

            try
            {
                dAL.abrirConexao(conexao);

                Funcionario funcionario = dAL.LoginFuncionario(conexao, email, senha);
                LoginPrimeiroAcesso primeiroAcesso = new LoginPrimeiroAcesso(funcionario);
                this.Hide();
                primeiroAcesso.Show();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao realizar o login: " + ex.Message);
            }
            finally
            {
                dAL.fecharConexao(conexao);
            }
        }



    }
}
