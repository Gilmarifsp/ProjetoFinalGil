using ProjetoGil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalGil
{
    public partial class ListarFuncionarios : Form
    {  
       // private int Id;
        public ListarFuncionarios()
        {
            InitializeComponent();
            AtualizarListView();
            Excluirbutton3.Visible = false;
        }

        private void AtualizarListView()
        {
            listView1.Items.Clear();

            Conexao Con = new Conexao();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM FUNCIONARIOS";

           try
            {
                SqlDataReader dr = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string nome = (string)dr["NOME"];
                    string sexo = (string)dr["SEXO"];
                    string cpf = (string)dr["CPF"];
                    DateTime admissao = (DateTime)dr["ADMISSAO"];
                    Double salario = (Double)dr["SALARIO"];
                    string cargo = (string)dr["CARGO"];
                    string departamento = (string)dr["DEPARTAMENTO"];

                    ListViewItem lista = new ListViewItem(id.ToString());
                    lista.SubItems.Add(nome);
                    lista.SubItems.Add(sexo);
                    lista.SubItems.Add(cpf);
                    lista.SubItems.Add(admissao.ToString());
                    lista.SubItems.Add(salario.ToString());
                    lista.SubItems.Add(cargo);
                    lista.SubItems.Add(departamento);
                    listView1.Items.Add(lista);


                }

                dr.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }



           /* FuncDao FuncionarioDao = new FuncDao();

            List<FUNCIONARIOS> funcionarios = FuncionarioDao.ListarTodosUsuarios();
            if (funcionarios.Count > 0)
            {
                foreach (FUNCIONARIOS FUNCIONARIO in funcionarios)*/
           /* {
                    ListViewItem lista = new ListViewItem(FUNCIONARIO.ToString());
                    lista.SubItems.Add(FUNCIONARIO.NOME_FUNC);
                    lista.SubItems.Add(FUNCIONARIO.SEXO);
                    lista.SubItems.Add(FUNCIONARIO.CPF);
                    lista.SubItems.Add(FUNCIONARIO.ADMISSAO.ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(FUNCIONARIO.SALARIO.ToString());
                    lista.SubItems.Add(FUNCIONARIO.CARGO);
                    lista.SubItems.Add(FUNCIONARIO.DEPTO);
                    listView1.Items.Add(lista);
                }
            }
        }*/

        private void ListaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrobutton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios();
            cadastrarFuncionarios.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void Atualizarbutton2_Click(object sender, EventArgs e)
        {
            Atualizarbutton2.Visible = false;
            Excluirbutton3.Visible = false;
        }

        private void Excluirbutton3_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            int id = int.Parse(listView1.Items[index].SubItems[0].Text);
            FuncDao usuariosFxcluir = new FuncDao();
            usuariosFxcluir.Excluir(id);
            AtualizarListView();
        }

        private void FuncionariosListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarFuncionarios_Load(object sender, EventArgs e)
        {
            Excluirbutton3.Visible = true;
        }

        private void Excluirbutton3_Click_1(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            FuncDao extra = new FuncDao();
            int id = int.Parse(listView1.Items[index].SubItems[0].Text);
            extra.Excluir(id);
            AtualizarListView();

        }

        private void Atualizarbutton2_Click_1(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            int ID = int.Parse(listView1.Items[index].SubItems[0].Text);
            string NOME_FUNC = listView1.Items[index].SubItems[1].Text;
            string SEXO = listView1.Items[index].SubItems[2].Text;
            string CPF = listView1.Items[index].SubItems[3].Text;
            DateTime ADMISSAO = Convert.ToDateTime(listView1.Items[index].SubItems[4].Text);
            Double SALARIO = Convert.ToDouble(listView1.Items[index].SubItems[5].Text);
            string CARGO = listView1.Items[index].SubItems[6].Text;
            string DEPTO = listView1.Items[index].SubItems[7].Text;
            int FK_ID_PROPRIETARIOS = int.Parse(listView1.Items[index].SubItems[8].Text);
            
           // CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios(NOME_FUNC, SEXO, CPF, ADMISSAO, SALARIO, CARGO, DEPTO, FK_ID_PROPRIETARIOS);
           // cadastrarFuncionarios.ShowDialog();
            AtualizarListView();
            

        }

        private void Cadastrobutton1_Click_1(object sender, EventArgs e)
        {
            CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios();
            cadastrarFuncionarios.ShowDialog();
            AtualizarListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}