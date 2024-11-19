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
    public partial class RhFuncionariosInfo : Form
    {
        Funcionario _funcionarioLogado;
        Funcionario _fcnEcluir;
        SqlConnection conexao;

        public RhFuncionariosInfo(Funcionario funcionarioLogado, Funcionario funcionario)
        {
            InitializeComponent();

            _funcionarioLogado = funcionarioLogado;
            _fcnEcluir = funcionario;

            lbNomeFuncInfo.Text = funcionario.Nome;
            tbNRF.Text = funcionario.Id.ToString();
            tbFuncao.Text = funcionario.Funcao;
            tbSupervisor.Text = funcionario.NomeGerente;
            tbDataAdmissao.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
            tbSalario.Text = funcionario.Salario.ToString("C2");
        }

        private void lbSairDetalhe_Click(object sender, EventArgs e)
        {
             RhFuncionarios rhFuncionarios = new RhFuncionarios(_funcionarioLogado);
             this.Hide();
             rhFuncionarios.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            RhInitial rhInitial = new RhInitial(_funcionarioLogado);
            this.Hide(); 
            rhInitial.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RhCadastroFuncionario rhCadastro = new RhCadastroFuncionario(_funcionarioLogado, null);
            this.Hide();
            rhCadastro.Show();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            RhPromover rhPromover = new RhPromover(_funcionarioLogado);
            this.Hide();
            rhPromover.Show();
        }

        private void btnDemitir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza de que deseja excluir este funcionário?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            conexao = clnConexao.getConexao();
            if (resultado == DialogResult.Yes)
            {
                FuncionarioFazDAL dAL = new FuncionarioFazDAL();

                try
                {
                    dAL.abrirConexao(conexao);
                    dAL.ExcluirFuncionario(conexao, _fcnEcluir.Id);

                    MessageBox.Show("Excluido com sucesso!");

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("A exclusão foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
