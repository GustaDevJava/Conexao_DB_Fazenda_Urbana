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
    public partial class GrFuncionarioInfo : Form
    {
        private Funcionario _logado;
        private Funcionario _funcionarioAumento;
        private SqlConnection conexao;
        public GrFuncionarioInfo(Funcionario logado, Funcionario funcionario)
        {
            InitializeComponent();
            _logado = logado;
            _funcionarioAumento = funcionario;
            PopulaFunc(funcionario);
        }

        private void PopulaFunc(Funcionario funcionario) 
        {
            tbFuncionario.Text = funcionario.Nome.ToString();
            tbFuncao.Text = funcionario.Funcao.ToString();
            tbSalario.Text = funcionario.Salario.ToString();
            dtDataAdm.Text = funcionario.DataAdmissao.ToString();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            conexao = clnConexao.getConexao();
            PromocaoDAL dAL = new PromocaoDAL();

            Promocao promocao = new Promocao();
            promocao.NomeFuncionario = _funcionarioAumento.Nome;
            promocao.FuncaoAtual = _funcionarioAumento.Funcao;
            promocao.NovaFuncao = tbNovaFuncao.Text;
            promocao.SalarioAtual = (decimal)_funcionarioAumento.Salario;
            decimal novoSalario;
            if (decimal.TryParse(lbNovoSalario.Text, out novoSalario))
            {
                promocao.NovoSalario = novoSalario;
            }
            else
            {
                // Tratar erro, caso o valor não seja um número válido
                MessageBox.Show("O valor do novo salário não é válido.");
            }
            promocao.DataAdmissao = _funcionarioAumento.DataAdmissao;
            promocao.IdGerente = _logado.Id;
            promocao.Status = "Pendente";
            promocao.IdFuncionarioPromovido = _funcionarioAumento.Id;

            try
            {
                dAL.abrirConexao(conexao);
                dAL.InserirPromocao(conexao, promocao);

                 MessageBox.Show("Solicitação enviada com sucesso!");

                GrPromover gr = new GrPromover(_logado);
                this.Hide();
                gr.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco"+ex.Message);
            }finally
            {
                dAL.fecharConexao(conexao);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
