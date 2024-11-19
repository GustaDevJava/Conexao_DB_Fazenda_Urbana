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
    public partial class FzPlantarSelect : Form
    {
        private Funcionario _logado;
        public FzPlantarSelect(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
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

        private void btnPlantioFrutas_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Frutas");
            this.Hide();
            fz.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Frutas");
            this.Hide();
            fz.Show();
        }

        private void btnVerdurasPlantio_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Verduras");
            this.Hide();
            fz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Verduras");
            this.Hide();
            fz.Show();
        }

        private void btnLegumesPlantio_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Legumes");
            this.Hide();
            fz.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Legumes");
            this.Hide();
            fz.Show();
        }

        private void btnVegetaisPlantio_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Vegetais");
            this.Hide();
            fz.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FzPlantar fz = new FzPlantar(_logado, "Vegetais");
            this.Hide();
            fz.Show();
        }
    }
}
