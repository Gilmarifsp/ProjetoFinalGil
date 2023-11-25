using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarCliente();

            menu.MdiParent = this;
            menu.Show();

        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new ListaCliente();
            menu.MdiParent = this;
            menu.Show();

           
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarFuncionarios();
            menu.MdiParent = this;
            menu.Show();

           
        }

        private void listarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new ListarFuncionarios();
            menu.MdiParent = this;
            menu.Show();

           
        }

        private void cadastrarProprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarProprietario();
            menu.MdiParent = this;
            menu.Show();
        }

        private void listarProprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new ListarProprietario();
            menu.MdiParent = this;
            menu.Show();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new frmConsultarEstoque();
            menu.MdiParent = this;
            menu.Show();
        }

        private void vendasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new VendasProdutos();
            menu.MdiParent = this;
            menu.Show();
        }

        private void pagarContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new Pagar_Contas();
            menu.MdiParent = this;
            menu.Show();
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new FaturamentoMensal();
            menu.MdiParent = this;
            menu.Show();
        }

        private void relatorioFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /*   var menu = new RelatorioFinanceiro();
            menu.ShowDialog();

            this.Visible = false;*/
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var menu = new Financeiro();
            menu.ShowDialog();

            this.Visible = false;*/
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* var menu = new Estoque();
            menu.ShowDialog();

            this.Visible = false;*/
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new CadastrarProdutos();
            menu.MdiParent = this;
            menu.Show();
        }
    }
}
