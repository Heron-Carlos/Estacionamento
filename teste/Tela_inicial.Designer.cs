namespace teste
{
    partial class inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarEntradaDoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMensalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarSaídaDeMensalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeVagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeMensalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarEntradaDoVeículoToolStripMenuItem,
            this.saídaDoVeículoToolStripMenuItem,
            this.controleDeVagasToolStripMenuItem,
            this.mensalidadesToolStripMenuItem,
            this.cadastroLoginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adicionarEntradaDoVeículoToolStripMenuItem
            // 
            this.adicionarEntradaDoVeículoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.adicionarEntradaDoVeículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.adicionarMensalidadeToolStripMenuItem});
            this.adicionarEntradaDoVeículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarEntradaDoVeículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.adicionarEntradaDoVeículoToolStripMenuItem.Name = "adicionarEntradaDoVeículoToolStripMenuItem";
            this.adicionarEntradaDoVeículoToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.adicionarEntradaDoVeículoToolStripMenuItem.Text = "Entrada do veículo";
            this.adicionarEntradaDoVeículoToolStripMenuItem.Click += new System.EventHandler(this.adicionarEntradaDoVeículoToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.adicionarToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.adicionarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adicionarToolStripMenuItem.Image = global::teste.Properties.Resources.add_one_button_insert_plus_icon_155856;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.entrada);
            // 
            // adicionarMensalidadeToolStripMenuItem
            // 
            this.adicionarMensalidadeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.adicionarMensalidadeToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.adicionarMensalidadeToolStripMenuItem.Image = global::teste.Properties.Resources.Mensalidade;
            this.adicionarMensalidadeToolStripMenuItem.Name = "adicionarMensalidadeToolStripMenuItem";
            this.adicionarMensalidadeToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.adicionarMensalidadeToolStripMenuItem.Text = "Adicionar Mensalidade";
            this.adicionarMensalidadeToolStripMenuItem.Click += new System.EventHandler(this.adicionarMensalidadeToolStripMenuItem_Click);
            // 
            // saídaDoVeículoToolStripMenuItem
            // 
            this.saídaDoVeículoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.saídaDoVeículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.adicionarSaídaDeMensalidadeToolStripMenuItem});
            this.saídaDoVeículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saídaDoVeículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.saídaDoVeículoToolStripMenuItem.Name = "saídaDoVeículoToolStripMenuItem";
            this.saídaDoVeículoToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.saídaDoVeículoToolStripMenuItem.Text = "Saída do veículo";
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.adicionarToolStripMenuItem1.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.adicionarToolStripMenuItem1.Image = global::teste.Properties.Resources.add_one_button_insert_plus_icon_155856;
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(400, 34);
            this.adicionarToolStripMenuItem1.Text = "Adicionar Saída";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // adicionarSaídaDeMensalidadeToolStripMenuItem
            // 
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.Image = global::teste.Properties.Resources.Mensalidade;
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.Name = "adicionarSaídaDeMensalidadeToolStripMenuItem";
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.Size = new System.Drawing.Size(400, 34);
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.Text = "Adicionar Saída de Mensalidade";
            this.adicionarSaídaDeMensalidadeToolStripMenuItem.Click += new System.EventHandler(this.adicionarSaídaDeMensalidadeToolStripMenuItem_Click);
            // 
            // controleDeVagasToolStripMenuItem
            // 
            this.controleDeVagasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.controleDeVagasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarToolStripMenuItem,
            this.fluxoDeCaixaToolStripMenuItem,
            this.controleDeRegistrosToolStripMenuItem,
            this.controleDeMensalidadeToolStripMenuItem});
            this.controleDeVagasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleDeVagasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.controleDeVagasToolStripMenuItem.Name = "controleDeVagasToolStripMenuItem";
            this.controleDeVagasToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.controleDeVagasToolStripMenuItem.Text = "Controles ";
            // 
            // acessarToolStripMenuItem
            // 
            this.acessarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.acessarToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.acessarToolStripMenuItem.Image = global::teste.Properties.Resources.carro_vermelho;
            this.acessarToolStripMenuItem.Name = "acessarToolStripMenuItem";
            this.acessarToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.acessarToolStripMenuItem.Text = "Controle de Vaga";
            this.acessarToolStripMenuItem.Click += new System.EventHandler(this.acessarToolStripMenuItem_Click);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fluxoDeCaixaToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.fluxoDeCaixaToolStripMenuItem.Image = global::teste.Properties.Resources._2486497_icone_do_fluxo_de_caixa_vetor_essa_aqui;
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem_Click);
            // 
            // controleDeRegistrosToolStripMenuItem
            // 
            this.controleDeRegistrosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.controleDeRegistrosToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.controleDeRegistrosToolStripMenuItem.Image = global::teste.Properties.Resources._753399;
            this.controleDeRegistrosToolStripMenuItem.Name = "controleDeRegistrosToolStripMenuItem";
            this.controleDeRegistrosToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.controleDeRegistrosToolStripMenuItem.Text = "Controle de Registros ";
            this.controleDeRegistrosToolStripMenuItem.Click += new System.EventHandler(this.controleDeRegistrosToolStripMenuItem_Click);
            // 
            // controleDeMensalidadeToolStripMenuItem
            // 
            this.controleDeMensalidadeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.controleDeMensalidadeToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.controleDeMensalidadeToolStripMenuItem.Image = global::teste.Properties.Resources.Mensalidade;
            this.controleDeMensalidadeToolStripMenuItem.Name = "controleDeMensalidadeToolStripMenuItem";
            this.controleDeMensalidadeToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.controleDeMensalidadeToolStripMenuItem.Text = "Controle de Mensalidade";
            this.controleDeMensalidadeToolStripMenuItem.Click += new System.EventHandler(this.controleDeMensalidadeToolStripMenuItem_Click);
            // 
            // mensalidadesToolStripMenuItem
            // 
            this.mensalidadesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.mensalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem,
            this.confirmarPagamentoToolStripMenuItem,
            this.excluirCadastroToolStripMenuItem});
            this.mensalidadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensalidadesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.mensalidadesToolStripMenuItem.Name = "mensalidadesToolStripMenuItem";
            this.mensalidadesToolStripMenuItem.Size = new System.Drawing.Size(151, 32);
            this.mensalidadesToolStripMenuItem.Text = "Mensalidades";
            // 
            // acessarToolStripMenuItem1
            // 
            this.acessarToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.acessarToolStripMenuItem1.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.acessarToolStripMenuItem1.Image = global::teste.Properties.Resources.incomes_azul;
            this.acessarToolStripMenuItem1.Name = "acessarToolStripMenuItem1";
            this.acessarToolStripMenuItem1.Size = new System.Drawing.Size(310, 34);
            this.acessarToolStripMenuItem1.Text = "Acessar Status";
            this.acessarToolStripMenuItem1.Click += new System.EventHandler(this.acessarToolStripMenuItem1_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastrarToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.cadastrarToolStripMenuItem.Image = global::teste.Properties.Resources.registro;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // confirmarPagamentoToolStripMenuItem
            // 
            this.confirmarPagamentoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.confirmarPagamentoToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.confirmarPagamentoToolStripMenuItem.Image = global::teste.Properties.Resources.Ilustração_Dinheiro_PNG_1024x757;
            this.confirmarPagamentoToolStripMenuItem.Name = "confirmarPagamentoToolStripMenuItem";
            this.confirmarPagamentoToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.confirmarPagamentoToolStripMenuItem.Text = "Confirmar Pagamento";
            this.confirmarPagamentoToolStripMenuItem.Click += new System.EventHandler(this.confirmarPagamentoToolStripMenuItem_Click);
            // 
            // excluirCadastroToolStripMenuItem
            // 
            this.excluirCadastroToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.excluirCadastroToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.excluirCadastroToolStripMenuItem.Image = global::teste.Properties.Resources.cancelar;
            this.excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            this.excluirCadastroToolStripMenuItem.Size = new System.Drawing.Size(310, 34);
            this.excluirCadastroToolStripMenuItem.Text = "Excluir Cadastro";
            // 
            // cadastroLoginToolStripMenuItem
            // 
            this.cadastroLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarToolStripMenuItem2,
            this.deletarToolStripMenuItem});
            this.cadastroLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroLoginToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.cadastroLoginToolStripMenuItem.Name = "cadastroLoginToolStripMenuItem";
            this.cadastroLoginToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.cadastroLoginToolStripMenuItem.Text = "Cadastro Login";
            // 
            // acessarToolStripMenuItem2
            // 
            this.acessarToolStripMenuItem2.BackColor = System.Drawing.Color.White;
            this.acessarToolStripMenuItem2.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.acessarToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.acessarToolStripMenuItem2.Image = global::teste.Properties.Resources._753399;
            this.acessarToolStripMenuItem2.Name = "acessarToolStripMenuItem2";
            this.acessarToolStripMenuItem2.Size = new System.Drawing.Size(200, 34);
            this.acessarToolStripMenuItem2.Text = "Cadastrar";
            this.acessarToolStripMenuItem2.Click += new System.EventHandler(this.acessarToolStripMenuItem2_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.BackgroundImage = global::teste.Properties.Resources._189404_ico;
            this.deletarToolStripMenuItem.Image = global::teste.Properties.Resources.cancelar;
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "HH:MM:ss";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teste.Properties.Resources._7547694_valet_parking_com_bilhete_imagem_e_varios_carros_em_estacionamento_publico_em_fundo_plano_cartoon_ilustracao_vetor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "HD Softwares® 2022- Todos os direitos reservados.";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inicio";
            this.Text = "Controle de Estacionamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarEntradaDoVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDoVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controleDeVagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem mensalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeMensalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMensalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarSaídaDeMensalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

