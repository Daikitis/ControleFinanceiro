namespace WindowsFormsApplication1
{
    partial class Master
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeRendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirRenda = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoSemestralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendasToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rendasToolStripMenuItem
            // 
            this.rendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeRendaToolStripMenuItem,
            this.ExibirRenda});
            this.rendasToolStripMenuItem.Name = "rendasToolStripMenuItem";
            this.rendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rendasToolStripMenuItem.Text = "Rendas";
            // 
            // cadastroDeRendaToolStripMenuItem
            // 
            this.cadastroDeRendaToolStripMenuItem.Name = "cadastroDeRendaToolStripMenuItem";
            this.cadastroDeRendaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cadastroDeRendaToolStripMenuItem.Text = "Cadastro de Renda";
            this.cadastroDeRendaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeRendaToolStripMenuItem_Click);
            // 
            // ExibirRenda
            // 
            this.ExibirRenda.Name = "ExibirRenda";
            this.ExibirRenda.Size = new System.Drawing.Size(173, 22);
            this.ExibirRenda.Text = "Exibir Renda";
            this.ExibirRenda.Click += new System.EventHandler(this.mostrarRendasToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeDespesasToolStripMenuItem,
            this.ExibirDespesas});
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.despesasToolStripMenuItem.Text = "Despesas";
            // 
            // cadastroDeDespesasToolStripMenuItem
            // 
            this.cadastroDeDespesasToolStripMenuItem.Name = "cadastroDeDespesasToolStripMenuItem";
            this.cadastroDeDespesasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeDespesasToolStripMenuItem.Text = "Cadastro de Despesas";
            this.cadastroDeDespesasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeDespesasToolStripMenuItem_Click);
            // 
            // ExibirDespesas
            // 
            this.ExibirDespesas.Name = "ExibirDespesas";
            this.ExibirDespesas.Size = new System.Drawing.Size(188, 22);
            this.ExibirDespesas.Text = "Exibir Despesas";
            this.ExibirDespesas.Click += new System.EventHandler(this.exibirDespesasToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balançoMensalToolStripMenuItem,
            this.balançoAnualToolStripMenuItem,
            this.balançoSemestralToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // balançoMensalToolStripMenuItem
            // 
            this.balançoMensalToolStripMenuItem.Name = "balançoMensalToolStripMenuItem";
            this.balançoMensalToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.balançoMensalToolStripMenuItem.Text = "Balanço Mensal";
            this.balançoMensalToolStripMenuItem.Click += new System.EventHandler(this.balançoMensalToolStripMenuItem_Click);
            // 
            // balançoAnualToolStripMenuItem
            // 
            this.balançoAnualToolStripMenuItem.Name = "balançoAnualToolStripMenuItem";
            this.balançoAnualToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.balançoAnualToolStripMenuItem.Text = "Balanço Anual";
            this.balançoAnualToolStripMenuItem.Click += new System.EventHandler(this.balançoAnualToolStripMenuItem_Click);
            // 
            // balançoSemestralToolStripMenuItem
            // 
            this.balançoSemestralToolStripMenuItem.Name = "balançoSemestralToolStripMenuItem";
            this.balançoSemestralToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.balançoSemestralToolStripMenuItem.Text = "Balanço Semestral";
            this.balançoSemestralToolStripMenuItem.Click += new System.EventHandler(this.balançoSemestralToolStripMenuItem_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 490);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Master";
            this.Text = "Controle de Finanças Domésticas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeRendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExibirRenda;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExibirDespesas;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoAnualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoSemestralToolStripMenuItem;

    }
}

