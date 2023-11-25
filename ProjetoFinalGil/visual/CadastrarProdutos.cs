using ProjetoGil;
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
    public partial class CadastrarProdutos : Form
    {
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        
            Produtos pdt = new Produtos(txtNome.Text, txtDescricao.Text, combotipodeitem.Text, combounidade.Text, Convert.ToDouble(txtPreco.Text), Convert.ToDouble(txtVendas.Text), combomarca.Text,txtModelo.Text,txtCodigodebalanca.Text);
            ProdutosDao produtosDao = new ProdutosDao();
            produtosDao.Inserir(pdt);
        }

        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}