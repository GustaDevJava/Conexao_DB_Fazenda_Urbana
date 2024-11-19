namespace Teste_Conexao
{
    partial class RhFuncionariosInfo
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btnPromover = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSairDetalhe = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbDataAdmissao = new System.Windows.Forms.Label();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.lbSupervisor = new System.Windows.Forms.Label();
            this.tbFuncao = new System.Windows.Forms.TextBox();
            this.tbDataAdmissao = new System.Windows.Forms.TextBox();
            this.tbSupervisor = new System.Windows.Forms.TextBox();
            this.tbNRF = new System.Windows.Forms.TextBox();
            this.lbNRFFuncInfo = new System.Windows.Forms.Label();
            this.lbNomeFuncInfo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnDemitir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btnPromover);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Controls.Add(this.btnFuncionarios);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblTituloMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(142, 450);
            this.panelMenu.TabIndex = 2;
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
            // btnPromover
            // 
            this.btnPromover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromover.ForeColor = System.Drawing.Color.Black;
            this.btnPromover.Location = new System.Drawing.Point(9, 168);
            this.btnPromover.Name = "btnPromover";
            this.btnPromover.Size = new System.Drawing.Size(124, 23);
            this.btnPromover.TabIndex = 4;
            this.btnPromover.Text = "Promover Funcionário";
            this.btnPromover.UseVisualStyleBackColor = true;
            this.btnPromover.Click += new System.EventHandler(this.btnPromover_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar Funcionário";
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
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
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
            this.panelHeader.Controls.Add(this.lblBemVindo);
            this.panelHeader.Location = new System.Drawing.Point(179, 84);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(590, 23);
            this.panelHeader.TabIndex = 3;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo.Location = new System.Drawing.Point(217, 5);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(122, 14);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Detalhes Funcionario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.btnDemitir);
            this.panel1.Controls.Add(this.lbSairDetalhe);
            this.panel1.Controls.Add(this.tbSalario);
            this.panel1.Controls.Add(this.lbSalario);
            this.panel1.Controls.Add(this.lbDataAdmissao);
            this.panel1.Controls.Add(this.lbFuncao);
            this.panel1.Controls.Add(this.lbSupervisor);
            this.panel1.Controls.Add(this.tbFuncao);
            this.panel1.Controls.Add(this.tbDataAdmissao);
            this.panel1.Controls.Add(this.tbSupervisor);
            this.panel1.Controls.Add(this.tbNRF);
            this.panel1.Controls.Add(this.lbNRFFuncInfo);
            this.panel1.Controls.Add(this.lbNomeFuncInfo);
            this.panel1.Location = new System.Drawing.Point(179, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 311);
            this.panel1.TabIndex = 4;
            // 
            // lbSairDetalhe
            // 
            this.lbSairDetalhe.AutoSize = true;
            this.lbSairDetalhe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSairDetalhe.Location = new System.Drawing.Point(570, 3);
            this.lbSairDetalhe.Name = "lbSairDetalhe";
            this.lbSairDetalhe.Size = new System.Drawing.Size(17, 17);
            this.lbSairDetalhe.TabIndex = 11;
            this.lbSairDetalhe.Text = "X";
            this.lbSairDetalhe.Click += new System.EventHandler(this.lbSairDetalhe_Click);
            // 
            // tbSalario
            // 
            this.tbSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbSalario.Location = new System.Drawing.Point(331, 120);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(232, 20);
            this.tbSalario.TabIndex = 10;
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSalario.ForeColor = System.Drawing.Color.White;
            this.lbSalario.Location = new System.Drawing.Point(328, 104);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(45, 13);
            this.lbSalario.TabIndex = 9;
            this.lbSalario.Text = "Salário:";
            // 
            // lbDataAdmissao
            // 
            this.lbDataAdmissao.AutoSize = true;
            this.lbDataAdmissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDataAdmissao.ForeColor = System.Drawing.Color.White;
            this.lbDataAdmissao.Location = new System.Drawing.Point(30, 252);
            this.lbDataAdmissao.Name = "lbDataAdmissao";
            this.lbDataAdmissao.Size = new System.Drawing.Size(88, 13);
            this.lbDataAdmissao.TabIndex = 8;
            this.lbDataAdmissao.Text = "Data Admissão:";
            // 
            // lbFuncao
            // 
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbFuncao.ForeColor = System.Drawing.Color.White;
            this.lbFuncao.Location = new System.Drawing.Point(30, 207);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(48, 13);
            this.lbFuncao.TabIndex = 7;
            this.lbFuncao.Text = "Função:";
            // 
            // lbSupervisor
            // 
            this.lbSupervisor.AutoSize = true;
            this.lbSupervisor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSupervisor.ForeColor = System.Drawing.Color.White;
            this.lbSupervisor.Location = new System.Drawing.Point(30, 157);
            this.lbSupervisor.Name = "lbSupervisor";
            this.lbSupervisor.Size = new System.Drawing.Size(65, 13);
            this.lbSupervisor.TabIndex = 6;
            this.lbSupervisor.Text = "Supervisor:";
            // 
            // tbFuncao
            // 
            this.tbFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbFuncao.Location = new System.Drawing.Point(33, 223);
            this.tbFuncao.Name = "tbFuncao";
            this.tbFuncao.Size = new System.Drawing.Size(232, 20);
            this.tbFuncao.TabIndex = 5;
            // 
            // tbDataAdmissao
            // 
            this.tbDataAdmissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbDataAdmissao.Location = new System.Drawing.Point(33, 268);
            this.tbDataAdmissao.Name = "tbDataAdmissao";
            this.tbDataAdmissao.Size = new System.Drawing.Size(232, 20);
            this.tbDataAdmissao.TabIndex = 4;
            // 
            // tbSupervisor
            // 
            this.tbSupervisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbSupervisor.Location = new System.Drawing.Point(33, 173);
            this.tbSupervisor.Name = "tbSupervisor";
            this.tbSupervisor.Size = new System.Drawing.Size(232, 20);
            this.tbSupervisor.TabIndex = 3;
            // 
            // tbNRF
            // 
            this.tbNRF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbNRF.Location = new System.Drawing.Point(33, 120);
            this.tbNRF.Name = "tbNRF";
            this.tbNRF.Size = new System.Drawing.Size(232, 20);
            this.tbNRF.TabIndex = 2;
            // 
            // lbNRFFuncInfo
            // 
            this.lbNRFFuncInfo.AutoSize = true;
            this.lbNRFFuncInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNRFFuncInfo.ForeColor = System.Drawing.Color.White;
            this.lbNRFFuncInfo.Location = new System.Drawing.Point(30, 104);
            this.lbNRFFuncInfo.Name = "lbNRFFuncInfo";
            this.lbNRFFuncInfo.Size = new System.Drawing.Size(112, 13);
            this.lbNRFFuncInfo.TabIndex = 1;
            this.lbNRFFuncInfo.Text = "Número de registro:";
            // 
            // lbNomeFuncInfo
            // 
            this.lbNomeFuncInfo.AutoSize = true;
            this.lbNomeFuncInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncInfo.ForeColor = System.Drawing.Color.White;
            this.lbNomeFuncInfo.Location = new System.Drawing.Point(221, 12);
            this.lbNomeFuncInfo.Name = "lbNomeFuncInfo";
            this.lbNomeFuncInfo.Size = new System.Drawing.Size(152, 21);
            this.lbNomeFuncInfo.TabIndex = 0;
            this.lbNomeFuncInfo.Text = "Nome Funcionario";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(179, 20);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(98, 20);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "Funcionários";
            // 
            // btnDemitir
            // 
            this.btnDemitir.BackColor = System.Drawing.Color.White;
            this.btnDemitir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemitir.ForeColor = System.Drawing.Color.Red;
            this.btnDemitir.Location = new System.Drawing.Point(470, 268);
            this.btnDemitir.Name = "btnDemitir";
            this.btnDemitir.Size = new System.Drawing.Size(93, 30);
            this.btnDemitir.TabIndex = 12;
            this.btnDemitir.Text = "Demitir";
            this.btnDemitir.UseVisualStyleBackColor = false;
            this.btnDemitir.Click += new System.EventHandler(this.btnDemitir_Click);
            // 
            // RhFuncionariosInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "RhFuncionariosInfo";
            this.Text = "RhFuncionariosInfo";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btnPromover;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNRFFuncInfo;
        private System.Windows.Forms.Label lbNomeFuncInfo;
        private System.Windows.Forms.TextBox tbNRF;
        private System.Windows.Forms.TextBox tbFuncao;
        private System.Windows.Forms.TextBox tbDataAdmissao;
        private System.Windows.Forms.TextBox tbSupervisor;
        private System.Windows.Forms.Label lbSupervisor;
        private System.Windows.Forms.Label lbFuncao;
        private System.Windows.Forms.Label lbDataAdmissao;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbSairDetalhe;
        private System.Windows.Forms.Button btnDemitir;
    }
}