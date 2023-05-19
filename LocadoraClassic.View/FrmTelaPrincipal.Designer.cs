namespace LocadoraClassic.View
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.FILMES = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDePizzaDeClientePorIndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grárificoAtrasadosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FILMES
            // 
            this.FILMES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FILMES.AutoSize = true;
            this.FILMES.BackColor = System.Drawing.Color.Transparent;
            this.FILMES.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILMES.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FILMES.Location = new System.Drawing.Point(67, 566);
            this.FILMES.Name = "FILMES";
            this.FILMES.Size = new System.Drawing.Size(87, 39);
            this.FILMES.TabIndex = 1;
            this.FILMES.Text = "FILMES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LocadoraClassic.View.Properties.Resources.icons8_4k_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.toolStripSeparator4});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generoToolStripMenuItem.Text = "Gênero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click_1);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatórioDiárioToolStripMenuItem,
            this.toolStripSeparator3});
            this.locaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar Locação";
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaNegraToolStripMenuItem,
            this.faturamentoDoMêsToolStripMenuItem,
            this.faturamentoDoDiaToolStripMenuItem,
            this.toolStripSeparator2});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // listaNegraToolStripMenuItem
            // 
            this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
            this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listaNegraToolStripMenuItem.Text = "Pendentes";
            // 
            // faturamentoDoMêsToolStripMenuItem
            // 
            this.faturamentoDoMêsToolStripMenuItem.Name = "faturamentoDoMêsToolStripMenuItem";
            this.faturamentoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.faturamentoDoMêsToolStripMenuItem.Text = "Faturamento do Mês";
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoDePizzaDeClientePorIndereçoToolStripMenuItem,
            this.grárificoAtrasadosPorMêsToolStripMenuItem,
            this.toolStripSeparator1});
            this.gráficosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // gráficoDePizzaDeClientePorIndereçoToolStripMenuItem
            // 
            this.gráficoDePizzaDeClientePorIndereçoToolStripMenuItem.Name = "gráficoDePizzaDeClientePorIndereçoToolStripMenuItem";
            this.gráficoDePizzaDeClientePorIndereçoToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.gráficoDePizzaDeClientePorIndereçoToolStripMenuItem.Text = "Gráfico de Pizza de Cliente por indereço";
            // 
            // grárificoAtrasadosPorMêsToolStripMenuItem
            // 
            this.grárificoAtrasadosPorMêsToolStripMenuItem.Name = "grárificoAtrasadosPorMêsToolStripMenuItem";
            this.grárificoAtrasadosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.grárificoAtrasadosPorMêsToolStripMenuItem.Text = "Grárifico / Atrasados por mês";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LocadoraClassic.View.Properties.Resources._716813;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 614);
            this.Controls.Add(this.FILMES);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocadoraClassic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FILMES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDePizzaDeClientePorIndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grárificoAtrasadosPorMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

