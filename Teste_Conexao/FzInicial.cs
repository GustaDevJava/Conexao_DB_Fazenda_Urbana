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

namespace Teste_Conexao
{
    public partial class FzInicial : Form
    {
        private Funcionario _logado;
        public FzInicial(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
            lblTituloMenu.Text = _logado.Nome.ToString();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
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

        private void btnPromover_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnPlantarL_Click(object sender, EventArgs e)
        {
            FzPlantarSelect fz = new FzPlantarSelect(_logado);
            this.Hide();
            fz.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FzProdutos fz = new FzProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FzProdutos fz = new FzProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnAlterarProdutos_Click(object sender, EventArgs e)
        {
            FzAlterarSelecao fz = new FzAlterarSelecao(_logado);
            this.Hide();
            fz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FzPlantarSelect fz = new FzPlantarSelect(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnPlantar_Click(object sender, EventArgs e)
        {
            FzPlantarSelect fz = new FzPlantarSelect(_logado);
            this.Hide();
            fz.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FzCadastrarProdutos fz = new FzCadastrarProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            FzCadastrarProdutos fz = new FzCadastrarProdutos(_logado);
            this.Hide();
            fz.Show();
        }

        private void lblTituloMenu_Click(object sender, EventArgs e)
        {
            FuncionarioAtualizar fz = new FuncionarioAtualizar(_logado);
            this.Hide();
            fz.Show();
        }
    }
}
