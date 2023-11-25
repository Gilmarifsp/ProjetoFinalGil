namespace ProjetoFinalGil
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMerceariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.proprietarioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.menuMerceariaToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente ";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionarioToolStripMenuItem,
            this.listarFuncionarioToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // cadastrarFuncionarioToolStripMenuItem
            // 
            this.cadastrarFuncionarioToolStripMenuItem.Name = "cadastrarFuncionarioToolStripMenuItem";
            this.cadastrarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFuncionarioToolStripMenuItem.Text = "Cadastrar Funcionario";
            this.cadastrarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionarioToolStripMenuItem_Click);
            // 
            // listarFuncionarioToolStripMenuItem
            // 
            this.listarFuncionarioToolStripMenuItem.Name = "listarFuncionarioToolStripMenuItem";
            this.listarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listarFuncionarioToolStripMenuItem.Text = "Listar Funcionario";
            this.listarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.listarFuncionarioToolStripMenuItem_Click);
            // 
            // proprietarioToolStripMenuItem
            // 
            this.proprietarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProprietarioToolStripMenuItem,
            this.listarProprietarioToolStripMenuItem});
            this.proprietarioToolStripMenuItem.Name = "proprietarioToolStripMenuItem";
            this.proprietarioToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.proprietarioToolStripMenuItem.Text = "Proprietario";
            // 
            // cadastrarProprietarioToolStripMenuItem
            // 
            this.cadastrarProprietarioToolStripMenuItem.Name = "cadastrarProprietarioToolStripMenuItem";
            this.cadastrarProprietarioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastrarProprietarioToolStripMenuItem.Text = "Cadastrar Proprietario";
            this.cadastrarProprietarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProprietarioToolStripMenuItem_Click);
            // 
            // listarProprietarioToolStripMenuItem
            // 
            this.listarProprietarioToolStripMenuItem.Name = "listarProprietarioToolStripMenuItem";
            this.listarProprietarioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listarProprietarioToolStripMenuItem.Text = "Listar Proprietario";
            this.listarProprietarioToolStripMenuItem.Click += new System.EventHandler(this.listarProprietarioToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProdutosToolStripMenuItem,
            this.vendasDeProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Consultar Produtos";
            this.consultarProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutosToolStripMenuItem_Click);
            // 
            // vendasDeProdutosToolStripMenuItem
            // 
            this.vendasDeProdutosToolStripMenuItem.Name = "vendasDeProdutosToolStripMenuItem";
            this.vendasDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.vendasDeProdutosToolStripMenuItem.Text = "Vendas de Produtos";
            this.vendasDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.vendasDeProdutosToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarContasToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // pagarContasToolStripMenuItem
            // 
            this.pagarContasToolStripMenuItem.Name = "pagarContasToolStripMenuItem";
            this.pagarContasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pagarContasToolStripMenuItem.Text = "Pagar Contas";
            this.pagarContasToolStripMenuItem.Click += new System.EventHandler(this.pagarContasToolStripMenuItem_Click);
            // 
            // menuMerceariaToolStripMenuItem
            // 
            this.menuMerceariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturamentoToolStripMenuItem,
            this.relatorioFinanceiroToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuMerceariaToolStripMenuItem.Name = "menuMerceariaToolStripMenuItem";
            this.menuMerceariaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.menuMerceariaToolStripMenuItem.Text = "Menu Mercearia";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            this.faturamentoToolStripMenuItem.Click += new System.EventHandler(this.faturamentoToolStripMenuItem_Click);
            // 
            // relatorioFinanceiroToolStripMenuItem
            // 
            this.relatorioFinanceiroToolStripMenuItem.Name = "relatorioFinanceiroToolStripMenuItem";
            this.relatorioFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.relatorioFinanceiroToolStripMenuItem.Text = "Relatorio Financeiro";
            this.relatorioFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.relatorioFinanceiroToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            this.financeiroToolStripMenuItem.Click += new System.EventHandler(this.financeiroToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1246, 700);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProprietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProprietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarContasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMerceariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}