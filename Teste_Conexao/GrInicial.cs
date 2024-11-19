using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Conexao
{
    public partial class GrInicial : Form
    {
        private Funcionario _logado;
        public GrInicial(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;
            lblTituloMenu.Text = _logado.Nome.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GrPromover gr = new GrPromover(_logado);
            this.Hide();
            gr.Show();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            GrPromover gr = new GrPromover(_logado);
            this.Hide();
            gr.Show();
        }

        private void btnPromoverFunc_Click(object sender, EventArgs e)
        {
            GrPromover gr = new GrPromover(_logado);
            this.Hide();
            gr.Show();
        }

        private void lblTituloMenu_Click(object sender, EventArgs e)
        {
            FuncionarioAtualizar fz = new FuncionarioAtualizar(_logado);
            this.Hide();
            fz.Show();
        }
    }
}
