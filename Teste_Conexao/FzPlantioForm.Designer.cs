namespace Teste_Conexao
{
    partial class FzPlantioForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.lbPlantio2 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.lbMensagemPlantio = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.btnColher = new System.Windows.Forms.Button();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.dtColheita = new System.Windows.Forms.DateTimePicker();
            this.dtPlantacao = new System.Windows.Forms.DateTimePicker();
            this.lbDataColheita = new System.Windows.Forms.Label();
            this.lbDataPlantacao = new System.Windows.Forms.Label();
            this.tbPlantio = new System.Windows.Forms.TextBox();
            this.lbPlantioFz = new System.Windows.Forms.Label();
            this.btnCancelarFz = new System.Windows.Forms.Button();
            this.tbUnidade = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbAlterarProdutoFz = new System.Windows.Forms.Button();
            this.lbUnidadePlantio = new System.Windows.Forms.Label();
            this.tbStatusPlantio = new System.Windows.Forms.TextBox();
            this.lbStatusPlantio = new System.Windows.Forms.Label();
            this.lbProdutoPlantio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btnAlterar);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.button1.Location = new System.Drawing.Point(9, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Plantar";
            this.button1.UseVisualStyleBackColor = true;
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
            // lbPlantio2
            // 
            this.lbPlantio2.AutoSize = true;
            this.lbPlantio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantio2.Location = new System.Drawing.Point(173, 17);
            this.lbPlantio2.Name = "lbPlantio2";
            this.lbPlantio2.Size = new System.Drawing.Size(60, 18);
            this.lbPlantio2.TabIndex = 18;
            this.lbPlantio2.Text = "Plantio";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lbTitulo);
            this.panelHeader.Controls.Add(this.lblBemVindo);
            this.panelHeader.Location = new System.Drawing.Point(176, 84);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(590, 23);
            this.panelHeader.TabIndex = 19;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(124, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(312, 18);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Preencha o formulário do que irá plantar";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbProdutos);
            this.panel1.Controls.Add(this.btnColher);
            this.panel1.Controls.Add(this.lbQuantidade);
            this.panel1.Controls.Add(this.tbQuantidade);
            this.panel1.Controls.Add(this.dtColheita);
            this.panel1.Controls.Add(this.dtPlantacao);
            this.panel1.Controls.Add(this.lbDataColheita);
            this.panel1.Controls.Add(this.lbDataPlantacao);
            this.panel1.Controls.Add(this.tbPlantio);
            this.panel1.Controls.Add(this.lbPlantioFz);
            this.panel1.Controls.Add(this.btnCancelarFz);
            this.panel1.Controls.Add(this.tbUnidade);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.tbAlterarProdutoFz);
            this.panel1.Controls.Add(this.lbUnidadePlantio);
            this.panel1.Controls.Add(this.tbStatusPlantio);
            this.panel1.Controls.Add(this.lbStatusPlantio);
            this.panel1.Controls.Add(this.lbProdutoPlantio);
            this.panel1.Location = new System.Drawing.Point(176, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 311);
            this.panel1.TabIndex = 20;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.Location = new System.Drawing.Point(42, 8);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(104, 18);
            this.lbObservacao.TabIndex = 0;
            this.lbObservacao.Text = "Observação:";
            // 
            // lbMensagemPlantio
            // 
            this.lbMensagemPlantio.AutoSize = true;
            this.lbMensagemPlantio.Location = new System.Drawing.Point(30, 53);
            this.lbMensagemPlantio.Name = "lbMensagemPlantio";
            this.lbMensagemPlantio.Size = new System.Drawing.Size(145, 52);
            this.lbMensagemPlantio.TabIndex = 1;
            this.lbMensagemPlantio.Text = "Apos a confirmação da\r\nplantação a zona onde \r\nescolheu plantar ficará \r\nindispon" +
    "ível até sua colheita.";
            // 
            // cbProdutos
            // 
            this.cbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(25, 39);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(330, 21);
            this.cbProdutos.TabIndex = 31;
            // 
            // btnColher
            // 
            this.btnColher.BackColor = System.Drawing.Color.White;
            this.btnColher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnColher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.btnColher.Location = new System.Drawing.Point(479, 268);
            this.btnColher.Name = "btnColher";
            this.btnColher.Size = new System.Drawing.Size(99, 28);
            this.btnColher.TabIndex = 30;
            this.btnColher.Text = "Colher";
            this.btnColher.UseVisualStyleBackColor = false;
            this.btnColher.Click += new System.EventHandler(this.btnColher_Click);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbQuantidade.ForeColor = System.Drawing.Color.White;
            this.lbQuantidade.Location = new System.Drawing.Point(190, 130);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lbQuantidade.TabIndex = 29;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbQuantidade.Location = new System.Drawing.Point(193, 146);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(163, 20);
            this.tbQuantidade.TabIndex = 28;
            // 
            // dtColheita
            // 
            this.dtColheita.Location = new System.Drawing.Point(193, 203);
            this.dtColheita.Name = "dtColheita";
            this.dtColheita.Size = new System.Drawing.Size(162, 20);
            this.dtColheita.TabIndex = 27;
            // 
            // dtPlantacao
            // 
            this.dtPlantacao.Enabled = false;
            this.dtPlantacao.Location = new System.Drawing.Point(24, 203);
            this.dtPlantacao.Name = "dtPlantacao";
            this.dtPlantacao.Size = new System.Drawing.Size(163, 20);
            this.dtPlantacao.TabIndex = 26;
            // 
            // lbDataColheita
            // 
            this.lbDataColheita.AutoSize = true;
            this.lbDataColheita.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDataColheita.ForeColor = System.Drawing.Color.White;
            this.lbDataColheita.Location = new System.Drawing.Point(190, 187);
            this.lbDataColheita.Name = "lbDataColheita";
            this.lbDataColheita.Size = new System.Drawing.Size(77, 13);
            this.lbDataColheita.TabIndex = 25;
            this.lbDataColheita.Text = "Data Colheita";
            // 
            // lbDataPlantacao
            // 
            this.lbDataPlantacao.AutoSize = true;
            this.lbDataPlantacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDataPlantacao.ForeColor = System.Drawing.Color.White;
            this.lbDataPlantacao.Location = new System.Drawing.Point(21, 187);
            this.lbDataPlantacao.Name = "lbDataPlantacao";
            this.lbDataPlantacao.Size = new System.Drawing.Size(85, 13);
            this.lbDataPlantacao.TabIndex = 22;
            this.lbDataPlantacao.Text = "Data plantação";
            // 
            // tbPlantio
            // 
            this.tbPlantio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbPlantio.Location = new System.Drawing.Point(193, 96);
            this.tbPlantio.Name = "tbPlantio";
            this.tbPlantio.Size = new System.Drawing.Size(162, 20);
            this.tbPlantio.TabIndex = 21;
            // 
            // lbPlantioFz
            // 
            this.lbPlantioFz.AutoSize = true;
            this.lbPlantioFz.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantioFz.ForeColor = System.Drawing.Color.White;
            this.lbPlantioFz.Location = new System.Drawing.Point(190, 80);
            this.lbPlantioFz.Name = "lbPlantioFz";
            this.lbPlantioFz.Size = new System.Drawing.Size(44, 13);
            this.lbPlantioFz.TabIndex = 20;
            this.lbPlantioFz.Text = "Plantio";
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
            // tbUnidade
            // 
            this.tbUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbUnidade.Location = new System.Drawing.Point(24, 146);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.Size = new System.Drawing.Size(163, 20);
            this.tbUnidade.TabIndex = 18;
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
            this.tbAlterarProdutoFz.Location = new System.Drawing.Point(146, 268);
            this.tbAlterarProdutoFz.Name = "tbAlterarProdutoFz";
            this.tbAlterarProdutoFz.Size = new System.Drawing.Size(99, 28);
            this.tbAlterarProdutoFz.TabIndex = 15;
            this.tbAlterarProdutoFz.Text = "Plantar";
            this.tbAlterarProdutoFz.UseVisualStyleBackColor = false;
            this.tbAlterarProdutoFz.Click += new System.EventHandler(this.tbAlterarProdutoFz_Click);
            // 
            // lbUnidadePlantio
            // 
            this.lbUnidadePlantio.AutoSize = true;
            this.lbUnidadePlantio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbUnidadePlantio.ForeColor = System.Drawing.Color.White;
            this.lbUnidadePlantio.Location = new System.Drawing.Point(21, 130);
            this.lbUnidadePlantio.Name = "lbUnidadePlantio";
            this.lbUnidadePlantio.Size = new System.Drawing.Size(51, 13);
            this.lbUnidadePlantio.TabIndex = 6;
            this.lbUnidadePlantio.Text = "Unidade";
            // 
            // tbStatusPlantio
            // 
            this.tbStatusPlantio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(207)))), ((int)(((byte)(150)))));
            this.tbStatusPlantio.Enabled = false;
            this.tbStatusPlantio.Location = new System.Drawing.Point(25, 96);
            this.tbStatusPlantio.Name = "tbStatusPlantio";
            this.tbStatusPlantio.Size = new System.Drawing.Size(162, 20);
            this.tbStatusPlantio.TabIndex = 2;
            this.tbStatusPlantio.Text = "Em plantação";
            // 
            // lbStatusPlantio
            // 
            this.lbStatusPlantio.AutoSize = true;
            this.lbStatusPlantio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusPlantio.ForeColor = System.Drawing.Color.White;
            this.lbStatusPlantio.Location = new System.Drawing.Point(22, 80);
            this.lbStatusPlantio.Name = "lbStatusPlantio";
            this.lbStatusPlantio.Size = new System.Drawing.Size(39, 13);
            this.lbStatusPlantio.TabIndex = 1;
            this.lbStatusPlantio.Text = "Status";
            // 
            // lbProdutoPlantio
            // 
            this.lbProdutoPlantio.AutoSize = true;
            this.lbProdutoPlantio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbProdutoPlantio.ForeColor = System.Drawing.Color.White;
            this.lbProdutoPlantio.Location = new System.Drawing.Point(22, 22);
            this.lbProdutoPlantio.Name = "lbProdutoPlantio";
            this.lbProdutoPlantio.Size = new System.Drawing.Size(50, 13);
            this.lbProdutoPlantio.TabIndex = 0;
            this.lbProdutoPlantio.Text = "Produto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbObservacao);
            this.panel2.Controls.Add(this.lbMensagemPlantio);
            this.panel2.Location = new System.Drawing.Point(378, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 162);
            this.panel2.TabIndex = 32;
            // 
            // FzPlantioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lbPlantio2);
            this.Controls.Add(this.panelMenu);
            this.Name = "FzPlantioForm";
            this.Text = "plantioFz3";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Label lbPlantio2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarFz;
        private System.Windows.Forms.TextBox tbUnidade;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button tbAlterarProdutoFz;
        private System.Windows.Forms.Label lbUnidadePlantio;
        private System.Windows.Forms.Label lbStatusPlantio;
        private System.Windows.Forms.Label lbProdutoPlantio;
        private System.Windows.Forms.TextBox tbPlantio;
        private System.Windows.Forms.Label lbPlantioFz;
        private System.Windows.Forms.Label lbDataPlantacao;
        private System.Windows.Forms.Label lbDataColheita;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Label lbMensagemPlantio;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.DateTimePicker dtColheita;
        private System.Windows.Forms.DateTimePicker dtPlantacao;
        private System.Windows.Forms.Button btnColher;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.TextBox tbStatusPlantio;
        private System.Windows.Forms.Panel panel2;
    }
}