namespace Teste_Conexao
{
    partial class RhCadastroFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGerente = new System.Windows.Forms.TextBox();
            this.lbGerente = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbContinuar = new System.Windows.Forms.Button();
            this.lbSalario = new System.Windows.Forms.Label();
            this.tbDataNasc = new System.Windows.Forms.DateTimePicker();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.tbUnidade = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNomeFuncInfo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
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
            this.panelMenu.TabIndex = 3;
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
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.btnCadastrar.Location = new System.Drawing.Point(9, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar Funcionário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionarios.Location = new System.Drawing.Point(9, 110);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(124, 23);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Funcionários";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.cbFuncao);
            this.panel1.Controls.Add(this.tbGerente);
            this.panel1.Controls.Add(this.lbGerente);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbContinuar);
            this.panel1.Controls.Add(this.lbSalario);
            this.panel1.Controls.Add(this.tbDataNasc);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tbSalario);
            this.panel1.Controls.Add(this.lbDataNasc);
            this.panel1.Controls.Add(this.lbUnidade);
            this.panel1.Controls.Add(this.lbFuncao);
            this.panel1.Controls.Add(this.lbTelefone);
            this.panel1.Controls.Add(this.tbUnidade);
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbCpf);
            this.panel1.Controls.Add(this.lbCpf);
            this.panel1.Controls.Add(this.lbNomeFuncInfo);
            this.panel1.Location = new System.Drawing.Point(178, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 311);
            this.panel1.TabIndex = 5;
            // 
            // tbGerente
            // 
            this.tbGerente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbGerente.Location = new System.Drawing.Point(141, 239);
            this.tbGerente.Name = "tbGerente";
            this.tbGerente.Size = new System.Drawing.Size(116, 20);
            this.tbGerente.TabIndex = 20;
            // 
            // lbGerente
            // 
            this.lbGerente.AutoSize = true;
            this.lbGerente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbGerente.ForeColor = System.Drawing.Color.White;
            this.lbGerente.Location = new System.Drawing.Point(138, 223);
            this.lbGerente.Name = "lbGerente";
            this.lbGerente.Size = new System.Drawing.Size(119, 13);
            this.lbGerente.TabIndex = 19;
            this.lbGerente.Text = "Gerente Responsável:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbEmail.Location = new System.Drawing.Point(25, 112);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 20);
            this.tbEmail.TabIndex = 18;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(22, 93);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste_Conexao.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(451, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tbContinuar
            // 
            this.tbContinuar.BackColor = System.Drawing.Color.White;
            this.tbContinuar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbContinuar.Location = new System.Drawing.Point(477, 269);
            this.tbContinuar.Name = "tbContinuar";
            this.tbContinuar.Size = new System.Drawing.Size(99, 28);
            this.tbContinuar.TabIndex = 15;
            this.tbContinuar.Text = "Continuar";
            this.tbContinuar.UseVisualStyleBackColor = false;
            this.tbContinuar.Click += new System.EventHandler(this.tbContinuar_Click);
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSalario.ForeColor = System.Drawing.Color.White;
            this.lbSalario.Location = new System.Drawing.Point(25, 262);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(45, 13);
            this.lbSalario.TabIndex = 14;
            this.lbSalario.Text = "Salário:";
            // 
            // tbDataNasc
            // 
            this.tbDataNasc.Location = new System.Drawing.Point(263, 71);
            this.tbDataNasc.Name = "tbDataNasc";
            this.tbDataNasc.Size = new System.Drawing.Size(138, 20);
            this.tbDataNasc.TabIndex = 13;
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbNome.Location = new System.Drawing.Point(25, 29);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(376, 20);
            this.tbNome.TabIndex = 12;
            // 
            // tbSalario
            // 
            this.tbSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbSalario.Location = new System.Drawing.Point(25, 278);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(232, 20);
            this.tbSalario.TabIndex = 10;
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDataNasc.ForeColor = System.Drawing.Color.White;
            this.lbDataNasc.Location = new System.Drawing.Point(260, 53);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(99, 13);
            this.lbDataNasc.TabIndex = 9;
            this.lbDataNasc.Text = "Data Nascimento:";
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUnidade.ForeColor = System.Drawing.Color.White;
            this.lbUnidade.Location = new System.Drawing.Point(22, 223);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(118, 13);
            this.lbUnidade.TabIndex = 8;
            this.lbUnidade.Text = "Unidade de Trabalho:";
            // 
            // lbFuncao
            // 
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbFuncao.ForeColor = System.Drawing.Color.White;
            this.lbFuncao.Location = new System.Drawing.Point(22, 180);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(48, 13);
            this.lbFuncao.TabIndex = 7;
            this.lbFuncao.Text = "Função:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(22, 142);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(54, 13);
            this.lbTelefone.TabIndex = 6;
            this.lbTelefone.Text = "Telefone:";
            // 
            // tbUnidade
            // 
            this.tbUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbUnidade.Location = new System.Drawing.Point(25, 239);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.Size = new System.Drawing.Size(110, 20);
            this.tbUnidade.TabIndex = 4;
            // 
            // tbTelefone
            // 
            this.tbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbTelefone.Location = new System.Drawing.Point(25, 157);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(232, 20);
            this.tbTelefone.TabIndex = 3;
            // 
            // tbCpf
            // 
            this.tbCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbCpf.Location = new System.Drawing.Point(25, 69);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(232, 20);
            this.tbCpf.TabIndex = 2;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.ForeColor = System.Drawing.Color.White;
            this.lbCpf.Location = new System.Drawing.Point(22, 53);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 1;
            this.lbCpf.Text = "CPF:";
            // 
            // lbNomeFuncInfo
            // 
            this.lbNomeFuncInfo.AutoSize = true;
            this.lbNomeFuncInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbNomeFuncInfo.ForeColor = System.Drawing.Color.White;
            this.lbNomeFuncInfo.Location = new System.Drawing.Point(22, 10);
            this.lbNomeFuncInfo.Name = "lbNomeFuncInfo";
            this.lbNomeFuncInfo.Size = new System.Drawing.Size(96, 13);
            this.lbNomeFuncInfo.TabIndex = 0;
            this.lbNomeFuncInfo.Text = "Nome Completo:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblBemVindo);
            this.panelHeader.Location = new System.Drawing.Point(178, 84);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(590, 23);
            this.panelHeader.TabIndex = 6;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo.Location = new System.Drawing.Point(158, 2);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(254, 18);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Cadastrar Funcionário - Formulário\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // cbFuncao
            // 
            this.cbFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.cbFuncao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(25, 199);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(232, 21);
            this.cbFuncao.TabIndex = 21;
            // 
            // RhCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "RhCadastroFuncionario";
            this.Text = "RhCadastroFuncionario";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDataNasc;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.Label lbFuncao;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox tbUnidade;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNomeFuncInfo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.DateTimePicker tbDataNasc;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Button tbContinuar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGerente;
        private System.Windows.Forms.Label lbGerente;
        private System.Windows.Forms.ComboBox cbFuncao;
    }
}