using ProjetoGil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoFinalGil
{
    public partial class ListarProprietario : Form
    {
        public ListarProprietario()
        {
            InitializeComponent();
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            ProprietariolistView1.Items.Clear();
            ProprietarioDao proprietarioDao = new ProprietarioDao();

            List<Proprietario> proprietarios = proprietarioDao.ListarTodosUsuarios();
           if (proprietarios.Count > 0)
            {
                foreach (Proprietario Proprietario in proprietarios)
                {
                    ListViewItem lista = new ListViewItem(Proprietario.Id.ToString());
                    lista.SubItems.Add(Proprietario.Nome);
                    lista.SubItems.Add(Proprietario.SEXO);
                    lista.SubItems.Add(Proprietario.CPF);
                    lista.SubItems.Add(Proprietario.EMAIL);
                    lista.SubItems.Add(Proprietario.TELEFONE);
                    lista.SubItems.Add(Proprietario.ENDERECO);
                    ProprietariolistView1.Items.Add(lista);
                }
            }
        }

        private void ListaProprietario_Load(object sender, EventArgs e)
        {
           
        }

        private void Cadastrarbutton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarProprietario cadastrarProprietario = new CadastrarProprietario();
            cadastrarProprietario.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void Atualizarbutton1_Click(object sender, EventArgs e)
        {
            Atualizarbutton1.Visible = false;
            Excluirbutton1.Visible = false;
        }

        private void excluirbutton1_Click(object sender, EventArgs e)
        {
            int index = ProprietariolistView1.FocusedItem.Index;
            int id = int.Parse(ProprietariolistView1.Items[index].SubItems[0].Text);
            ProprietarioDao usuariosFxcluir = new ProprietarioDao();
            usuariosFxcluir.Excluir(id);
            AtualizarListView();
        }

        private void ProprietarioListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListarProprietario_Load(object sender, EventArgs e)
        {

        }

        private void ProprietariolistView1_Click(object sender, EventArgs e)
        {
           
        }

        private void Atualizarbutton1_Click_1(object sender, EventArgs e)
        {
            int index = ProprietariolistView1.FocusedItem.Index;
            int id = int.Parse(ProprietariolistView1.Items[index].SubItems[0].Text);
            string nome = ProprietariolistView1.Items[index].SubItems[2].Text;
            string Sexo = ProprietariolistView1.Items[index].SubItems[3].Text;
            string CPF = ProprietariolistView1.Items[index].SubItems[4].Text;
            string EMAIL = ProprietariolistView1.Items[index].SubItems[5].Text;
            string TELEF = ProprietariolistView1.Items[index].SubItems[6].Text;
            string ENDER = ProprietariolistView1.Items[index].SubItems[7].Text;

            CadastrarProprietario cadastrarProprietario = new CadastrarProprietario(id,nome,Sexo,CPF,EMAIL,TELEF,ENDER);

        }

        private void Excluirbutton1_Click_1(object sender, EventArgs e)
        {
            int index = ProprietariolistView1.FocusedItem.Index;
            int id = int.Parse(ProprietariolistView1.Items[index].SubItems[0].Text);
            ProprietarioDao usuariosFxcluir = new ProprietarioDao();
            usuariosFxcluir.Excluir(id);
            AtualizarListView();
        }
    }
}
  