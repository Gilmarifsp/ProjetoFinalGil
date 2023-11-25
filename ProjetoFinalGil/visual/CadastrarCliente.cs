using ProjetoGil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoFinalGil
{
    public partial class CadastrarCliente : Form
    {
        static string Sexo;
         static string EnderecoTotal;
        private string opcao;
        private int Id;
        public CadastrarCliente()
        {
            InitializeComponent();
            opcao = "inserir";
        }
        public CadastrarCliente(int ID, string NOME, string EMAIL, string TELEFONE, string ENDERECO, string Sexo,string CIDADE,string UF)
        {

            InitializeComponent();
            opcao = "alterar";
            Id = ID;
            txtN.Text = 0.ToString();
            textBox2.Text = NOME;
            textBox3.Text = EMAIL;
            textBox4.Text = TELEFONE;
            txtEndereco.Text = ENDERECO;
            txtCidade.Text = CIDADE;
            comboBox2.Text = UF;


            if(Sexo == "Feminino")
                radioButton1.Checked = true;

            else radioButton2.Checked = true;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Feminino";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Masculino";
        }

        private void CadastrarButton_Click_1(object sender, EventArgs e)
        {
            EnderecoTotal = txtEndereco.Text + " " + txtN.Text + " " + txtCidade.Text + " " + comboBox2.Text;
            Clientes cli = new Clientes(Id, textBox2.Text, textBox3.Text, textBox4.Text, EnderecoTotal, int.Parse(txtN.Text), txtCidade.Text, comboBox2.Text, Sexo); ;
            UsuariosDAO clidao = new UsuariosDAO();
            if(opcao=="inserir")
                clidao.Inserir(cli);
            else
                clidao.Alterar(cli);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txtEndereco.Clear();
            Sexo = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtN.Clear();
            txtCidade.Clear();
            comboBox2.Text = " ";



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
