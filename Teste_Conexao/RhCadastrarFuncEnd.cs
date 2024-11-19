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
    public partial class RhCadastrarFuncEnd : Form
    {
        private Funcionario _logado, contFuncCad;

        SqlConnection conexao;


        public RhCadastrarFuncEnd(Funcionario logado, Funcionario novoFunc)
        {
            InitializeComponent();

            _logado = logado;
            contFuncCad = novoFunc;
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            RhCadastroFuncionario rhVoltar = new RhCadastroFuncionario(_logado,  contFuncCad);
            this.Hide();
            rhVoltar.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            RhFuncionarios rhFuncionarios = new RhFuncionarios(_logado);
            this.Hide();
            rhFuncionarios.Show();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            RhPromover rhPromover = new RhPromover(_logado);
            this.Hide();
            rhPromover.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            RhInitial rhInitial = new RhInitial(_logado);
            this.Hide();
            rhInitial.Show();
        }

        private void tbCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario novoFunc = contFuncCad;

            Endereco endereco = new Endereco();
            endereco.Rua = tbEndereco.Text;
            endereco.Numero = tbNumero.Text;
            endereco.Complemento = tbComplemento.Text;
            endereco.Cep = tbCep.Text;
            endereco.Cidade = tbCidade.Text;
            endereco.Estado = tbEndereco.Text;

            novoFunc.Endereco = endereco;

            conexao = clnConexao.getConexao();

            FuncionarioFazDAL dAL = new FuncionarioFazDAL();

            try
            {
                dAL.abrirConexao(conexao);
                dAL.CadastrarFuncionario(conexao, novoFunc);

                RhCadastroFuncionario rhRetoraCad = new RhCadastroFuncionario(_logado, null);
                this.Hide();
                rhRetoraCad.Show();
                MessageBox.Show("Funcionário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario" + ex.Message);
            }
            finally
            {
                dAL.fecharConexao(conexao);
            }



        }

    }
}
