namespace Teste_Conexao
{
    partial class FzAlterarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPlantar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lbAlterarProdutos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarFz = new System.Windows.Forms.Button();
            this.tbAlterarQuantidade = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbAlterarProdutoFz = new System.Windows.Forms.Button();
            this.tbAlterarNomeProduto = new System.Windows.Forms.TextBox();
            this.lbAlterarQuantidade = new System.Windows.Forms.Label();
            this.tbAlterarPreco = new System.Windows.Forms.TextBox();
            this.lbAlterarPreco = new System.Windows.Forms.Label();
            this.lbAlterarProdutoNome = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnPlantar);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btnPromover);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblTituloMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(142, 450);
            this.panelMenu.TabIndex = 8;
            // 
            // btnPlantar
            // 
            this.btnPlantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantar.ForeColor = System.Drawing.Color.Black;
            this.btnPlantar.Location = new System.Drawing.Point(9, 197);
            this.btnPlantar.Name = "btnPlantar";
            this.btnPlantar.Size = new System.Drawing.Size(124, 23);
            this.btnPlantar.TabIndex = 7;
            this.btnPlantar.Text = "Plantar";
            this.btnPlantar.UseVisualStyleBackColor = true;
            this.btnPlantar.Click += new System.EventHandler(this.btnPlantar_Click);
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(9, 418);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(124, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btnPromover
            // 
            this.btnPromover.BackColor = System.Drawing.SystemColors.Window;
            this.btnPromover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.btnPromover.Location = new System.Drawing.Point(9, 168);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(124, 23);
            this.btnPromover.TabIndex = 4;
            this.btnPromover.Text = "Alterar Produtos";
            this.btnPromover.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar Produtos";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.Location = new System.Drawing.Point(9, 110);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(124, 23);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(9, 84);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(124, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTituloMenu.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMenu.Location = new System.Drawing.Point(71, 21);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(62, 13);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Funcionario";
            this.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lbTitulo);
            this.panelHeader.Controls.Add(this.lblBemVindo);
            this.panelHeader.Location = new System.Drawing.Point(181, 84);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(590, 23);
            this.panelHeader.TabIndex = 13;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(156, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(213, 18);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Altere os dados do produto";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo.Location = new System.Drawing.Point(245, 5);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(0, 14);
            this.lblBemVindo.TabIndex = 0;
            // 
            // lbAlterarProdutos
            // 
            this.lbAlterarProdutos.AutoSize = true;
            this.lbAlterarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarProdutos.Location = new System.Drawing.Point(178, 21);
            this.lbAlterarProdutos.Name = "lbAlterarProdutos";
            this.lbAlterarProdutos.Size = new System.Drawing.Size(131, 18);
            this.lbAlterarProdutos.TabIndex = 15;
            this.lbAlterarProdutos.Text = "Alterar Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pbImagem);
            this.panel1.Controls.Add(this.btnCancelarFz);
            this.panel1.Controls.Add(this.tbAlterarQuantidade);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.tbAlterarProdutoFz);
            this.panel1.Controls.Add(this.tbAlterarNomeProduto);
            this.panel1.Controls.Add(this.lbAlterarQuantidade);
            this.panel1.Controls.Add(this.tbAlterarPreco);
            this.panel1.Controls.Add(this.lbAlterarPreco);
            this.panel1.Controls.Add(this.lbAlterarProdutoNome);
            this.panel1.Location = new System.Drawing.Point(181, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 311);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancelarFz
            // 
            this.btnCancelarFz.BackColor = System.Drawing.Color.White;
            this.btnCancelarFz.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarFz.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarFz.Location = new System.Drawing.Point(25, 268);
            this.btnCancelarFz.Name = "btnCancelarFz";
            this.btnCancelarFz.Size = new System.Drawing.Size(99, 28);
            this.btnCancelarFz.TabIndex = 19;
            this.btnCancelarFz.Text = "Cancelar";
            this.btnCancelarFz.UseVisualStyleBackColor = false;
            this.btnCancelarFz.Click += new System.EventHandler(this.btnCancelarFz_Click);
            // 
            // tbAlterarQuantidade
            // 
            this.tbAlterarQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbAlterarQuantidade.Location = new System.Drawing.Point(29, 160);
            this.tbAlterarQuantidade.Name = "tbAlterarQuantidade";
            this.tbAlterarQuantidade.Size = new System.Drawing.Size(232, 20);
            this.tbAlterarQuantidade.TabIndex = 18;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(25, 96);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 13);
            this.lbEmail.TabIndex = 17;
            // 
            // tbAlterarProdutoFz
            // 
            this.tbAlterarProdutoFz.BackColor = System.Drawing.Color.White;
            this.tbAlterarProdutoFz.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbAlterarProdutoFz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbAlterarProdutoFz.Location = new System.Drawing.Point(248, 268);
            this.tbAlterarProdutoFz.Name = "tbAlterarProdutoFz";
            this.tbAlterarProdutoFz.Size = new System.Drawing.Size(99, 28);
            this.tbAlterarProdutoFz.TabIndex = 15;
            this.tbAlterarProdutoFz.Text = "Alterar";
            this.tbAlterarProdutoFz.UseVisualStyleBackColor = false;
            this.tbAlterarProdutoFz.Click += new System.EventHandler(this.tbAlterarProdutoFz_Click);
            // 
            // tbAlterarNomeProduto
            // 
            this.tbAlterarNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbAlterarNomeProduto.Location = new System.Drawing.Point(29, 70);
            this.tbAlterarNomeProduto.Name = "tbAlterarNomeProduto";
            this.tbAlterarNomeProduto.Size = new System.Drawing.Size(330, 20);
            this.tbAlterarNomeProduto.TabIndex = 12;
            // 
            // lbAlterarQuantidade
            // 
            this.lbAlterarQuantidade.AutoSize = true;
            this.lbAlterarQuantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbAlterarQuantidade.ForeColor = System.Drawing.Color.White;
            this.lbAlterarQuantidade.Location = new System.Drawing.Point(25, 144);
            this.lbAlterarQuantidade.Name = "lbAlterarQuantidade";
            this.lbAlterarQuantidade.Size = new System.Drawing.Size(71, 13);
            this.lbAlterarQuantidade.TabIndex = 6;
            this.lbAlterarQuantidade.Text = "Quantidade:";
            // 
            // tbAlterarPreco
            // 
            this.tbAlterarPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbAlterarPreco.Location = new System.Drawing.Point(28, 112);
            this.tbAlterarPreco.Name = "tbAlterarPreco";
            this.tbAlterarPreco.Size = new System.Drawing.Size(232, 20);
            this.tbAlterarPreco.TabIndex = 2;
            // 
            // lbAlterarPreco
            // 
            this.lbAlterarPreco.AutoSize = true;
            this.lbAlterarPreco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlterarPreco.ForeColor = System.Drawing.Color.White;
            this.lbAlterarPreco.Location = new System.Drawing.Point(25, 96);
            this.lbAlterarPreco.Name = "lbAlterarPreco";
            this.lbAlterarPreco.Size = new System.Drawing.Size(39, 13);
            this.lbAlterarPreco.TabIndex = 1;
            this.lbAlterarPreco.Text = "Preço:";
            // 
            // lbAlterarProdutoNome
            // 
            this.lbAlterarProdutoNome.AutoSize = true;
            this.lbAlterarProdutoNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbAlterarProdutoNome.ForeColor = System.Drawing.Color.White;
            this.lbAlterarProdutoNome.Location = new System.Drawing.Point(26, 54);
            this.lbAlterarProdutoNome.Name = "lbAlterarProdutoNome";
            this.lbAlterarProdutoNome.Size = new System.Drawing.Size(105, 13);
            this.lbAlterarProdutoNome.TabIndex = 0;
            this.lbAlterarProdutoNome.Text = "Nome do Produto:";
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(386, 54);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(175, 178);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 20;
            this.pbImagem.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::Teste_Conexao.Properties.Resources.Captura_de_tela_2024_10_21_204048;
            this.picLogo.Location = new System.Drawing.Point(12, 300);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(111, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.button1.Location = new System.Drawing.Point(386, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Alterar imagem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FzAlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAlterarProdutos);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "FzAlterarProduto";
            this.Text = "AlterarProduto";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPlantar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lbAlterarProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAlterarQuantidade;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button tbAlterarProdutoFz;
        private System.Windows.Forms.TextBox tbAlterarNomeProduto;
        private System.Windows.Forms.Label lbAlterarQuantidade;
        private System.Windows.Forms.TextBox tbAlterarPreco;
        private System.Windows.Forms.Label lbAlterarPreco;
        private System.Windows.Forms.Label lbAlterarProdutoNome;
        private System.Windows.Forms.Button btnCancelarFz;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button button1;
    }
}