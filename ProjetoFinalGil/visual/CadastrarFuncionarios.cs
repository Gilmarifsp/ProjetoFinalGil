using ProjetoGil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoFinalGil
{
    public partial class CadastrarFuncionarios : Form
    {
        static string Sexo;
        public CadastrarFuncionarios()
        {
            InitializeComponent();

        }
        public CadastrarFuncionarios(int ID, string NOME, string SexoParam, string CPF, DateTime ADMISSAO, Double SALARIO, string CARGO, string DEPARTAMENTO, int FK_ID_PROPRIETARIOS)
        {
            InitializeComponent();

            textBoxNome.Text = NOME;
            textBox2CPF.Text = CPF;
            dateTimePicker1.Value = ADMISSAO;
            textBox6Salario.Text = Convert.ToString(SALARIO);
            textBox7Cargo.Text = CARGO;
            textBox8Depto.Text = DEPARTAMENTO;
            //comboBox1.Text = FK_ID_PROPRIETARIOS.ToString();

            if (SexoParam == "Feminino")
                radioButton1.Checked = true;

            else radioButton2.Checked = true;

        }





        private void textBox2CPF_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            Conexao Con = new Conexao();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO FUNCIONARIOS VALUES (@nome, @sexo, @cpf, @admissao, @salario, @cargo, @depto, @fk_id_func)";

            Cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
            Cmd.Parameters.AddWithValue("@sexo", Sexo);
            Cmd.Parameters.AddWithValue("@cpf", textBox2CPF.Text);
            Cmd.Parameters.AddWithValue("@admissao", dateTimePicker1.Value);
           // Cmd.Parameters.AddWithValue("@salario", textBox6Salario.Text);
            Cmd.Parameters.AddWithValue("@cargo", textBox7Cargo.Text);
            Cmd.Parameters.AddWithValue("@depto", textBox8Depto.Text);
            Cmd.Parameters.AddWithValue("@fk_id_func", 1);

            if (double.TryParse(textBox6Salario.Text, out double salario))
            {
                Cmd.Parameters.AddWithValue("@salario", salario);
            }
            else
            {
                // Exiba uma mensagem de erro ou tome alguma ação apropriada.
                MessageBox.Show("Por favor, insira um valor válido para o salário.", "Erro de Validação",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception(/*"Erro: Problemas ao inserir usuario no banco.\n" +*/ err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            //limparDados();
           //UpdateListView();

            MessageBox.Show(
                "Cadastrado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBox2CPF.Clear();
           // dateTimePicker1.Clear();
            textBox6Salario.Clear();
            Sexo = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox7Cargo.Clear();
            textBox8Depto.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1NOME_FUNC_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Sexo = "Feminino";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Sexo = "Masculino";
        }
    }
}


