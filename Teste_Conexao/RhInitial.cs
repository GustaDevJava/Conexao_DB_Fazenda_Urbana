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

namespace Teste_Conexao.Rh
{
    public partial class RhInitial : Form
    {
        private  Funcionario funcionarioLogado;
        public RhInitial(Funcionario funcionario)
        {
            InitializeComponent();

            funcionarioLogado = funcionario;

            lblBemVindo.Text = $"Bem-vindo, {funcionarioLogado.Nome}!";
            lblTituloMenu.Text = funcionario.Nome.ToString();


        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            RhFuncionarios rhFuncionarios = new RhFuncionarios(funcionarioLogado);
            this.Hide();
            rhFuncionarios.Show();
        }
        private void btnFuncionariosCentral_Click(object sender, EventArgs e)
        {
            RhFuncionarios rhFuncionarios = new RhFuncionarios(funcionarioLogado);
            this.Hide();
            rhFuncionarios.Show();
        }

        private void btnCadastrarCentral_Click(object sender, EventArgs e)
        {
            RhCadastroFuncionario rhCadastro = new RhCadastroFuncionario(funcionarioLogado, null);
            this.Hide();
            rhCadastro.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RhCadastroFuncionario rhCadastro = new RhCadastroFuncionario(funcionarioLogado, null);
            this.Hide();
            rhCadastro.Show();
        }

        private void btnPromover_Click(object sender, EventArgs e)
        {
            RhPromover rhPromover = new RhPromover(funcionarioLogado);
            this.Hide();
            rhPromover.Show();
        }

        private void btnPromoverCentral_Click(object sender, EventArgs e)
        {
            RhPromover rhPromover = new RhPromover(funcionarioLogado);
            this.Hide();
            rhPromover.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();   
        }

        private void lblTituloMenu_Click(object sender, EventArgs e)
        {
            FuncionarioAtualizar fz = new FuncionarioAtualizar(funcionarioLogado);
            this.Hide();
            fz.Show();
        }
    }
}
