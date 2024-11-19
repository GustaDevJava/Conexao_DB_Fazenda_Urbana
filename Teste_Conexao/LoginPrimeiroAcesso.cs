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
using Teste_Conexao.Rh;

namespace Teste_Conexao
{
    public partial class LoginPrimeiroAcesso : Form
    {
        private Funcionario _funcionario;
        private SqlConnection conexao;
        public LoginPrimeiroAcesso(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionario = funcionario;
            textEmail.Enter += textEmail_Enter;
            textEmail.Leave += textEmail_Leave;
            textSenha.Enter += textSenha_Enter;
            textSenha.Leave += textSenha_Leave;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            ckbSenha.CheckedChanged += ckbSenha_CheckedChanged;
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Digite sua senha")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                textEmail.Text = "Digite sua senha";
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

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            textSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void ckbSenha_CheckedChanged(object sender, EventArgs e)
        {
            textEmail.UseSystemPasswordChar = !ckbSenha.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textEmail.Text.Equals(textSenha.Text) && !textSenha.Text.Equals(_funcionario.Senha))
            {

                conexao = clnConexao.getConexao();

                FuncionarioFazDAL dAL = new FuncionarioFazDAL();

                try
                {
                    dAL.abrirConexao(conexao);

                    dAL.AlterarSenha(conexao, _funcionario, textSenha.Text);

                    MessageBox.Show("Senha Alterada com Sucesso!");

                    switch (_funcionario.Funcao)
                    {
                        case "RH":
                            RhInitial rh = new RhInitial(_funcionario);
                            this.Hide();
                            rh.Show();
                            break;
                        case "Fazendeiro":
                            FzInicial fz = new FzInicial(_funcionario);
                            this.Hide();
                            fz.Show();
                            break;
                        case "Gerente":
                            GrInicial gr = new GrInicial(_funcionario);
                            this.Hide();
                            gr.Show();
                            break;
                        default:
                            MessageBox.Show("Funcionario: " + _funcionario.Nome + " não tem função");
                            break;
                    }



                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao trocar senha!", ex.Message);
                }finally
                {
                    dAL.fecharConexao(conexao);
                }
                
            }else 
            {
                MessageBox.Show("Senhas não são iguais ou é igual a anterior");
            }
        }
    }
}
