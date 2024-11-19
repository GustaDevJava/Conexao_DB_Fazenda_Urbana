namespace Teste_Conexao
{
    partial class FzProdutos
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
            this.BtnPlantar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.lbFrutas = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.flpProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.BtnPlantar);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btnAlterar);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Controls.Add(this.btnFuncionarios);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblTituloMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(142, 450);
            this.panelMenu.TabIndex = 6;
            // 
            // BtnPlantar
            // 
            this.BtnPlantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlantar.ForeColor = System.Drawing.Color.Black;
            this.BtnPlantar.Location = new System.Drawing.Point(9, 197);
            this.BtnPlantar.Name = "BtnPlantar";
            this.BtnPlantar.Size = new System.Drawing.Size(124, 23);
            this.BtnPlantar.TabIndex = 7;
            this.BtnPlantar.Text = "Plantar";
            this.BtnPlantar.UseVisualStyleBackColor = true;
            this.BtnPlantar.Click += new System.EventHandler(this.BtnPlantar_Click);
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
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(9, 168);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(124, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar Produtos";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar Produtos";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.btnFuncionarios.Location = new System.Drawing.Point(9, 110);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(124, 23);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Produtos";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
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
            // lbFrutas
            // 
            this.lbFrutas.AutoSize = true;
            this.lbFrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrutas.Location = new System.Drawing.Point(176, 17);
            this.lbFrutas.Name = "lbFrutas";
            this.lbFrutas.Size = new System.Drawing.Size(77, 18);
            this.lbFrutas.TabIndex = 10;
            this.lbFrutas.Text = "Produtos";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lbTitulo);
            this.panelHeader.Controls.Add(this.lblBemVindo);
            this.panelHeader.Location = new System.Drawing.Point(179, 84);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(590, 23);
            this.panelHeader.TabIndex = 11;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(245, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(136, 18);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Todas as Frutas ";
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
            // flpProdutos
            // 
            this.flpProdutos.Location = new System.Drawing.Point(179, 113);
            this.flpProdutos.Name = "flpProdutos";
            this.flpProdutos.Size = new System.Drawing.Size(590, 328);
            this.flpProdutos.TabIndex = 12;
            // 
            // FzProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpProdutos);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lbFrutas);
            this.Controls.Add(this.panelMenu);
            this.Name = "FzProdutos";
            this.Text = "FzProdutos";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnPlantar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Label lbFrutas;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.FlowLayoutPanel flpProdutos;
    }
}