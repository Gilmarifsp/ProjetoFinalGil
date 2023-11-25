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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoFinalGil
{
    public partial class CadastrarProprietario : Form
    {
        static string Sexo;

        public CadastrarProprietario()
        {
            InitializeComponent();
        }

        public CadastrarProprietario(int ID, string NOME, string Sexo, string CPF, string EMAIL,string TELEF,string ENDER)
        {
            
            InitializeComponent();


            //Sexo = ID.ToString();
            textBox2.Text = NOME.ToString();
            mtbCPF.Text = CPF.ToString();
            textBox5.Text = EMAIL.ToString();
            mtbTelefone.Text = TELEF.ToString();
            textBox7.Text = ENDER.ToString();

            if (Sexo == "Feminino")
                radioButton1.Checked = true;

            else radioButton2.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProprietario_load(object sender, EventArgs e)
        {

        }


        /*private void button1CADSTRAR_Click(object sender, EventArgs e)
        {
           // Proprietario Pro = new Proprietario(textBox2.Text, lbSexo.Text, mtbCPF.Text, textBox5.Text, mtbTelefone.Text, btnNovo.Text);
            //ProprietarioDao Prodao = new ProprietarioDao();

            if (button1.Text == "CADASTRAR")
            {
                Proprietario Pro = new Proprietario(textBox2.Text, lbSexo.Text, mtbCPF.Text, textBox5.Text, mtbTelefone.Text, btnNovo.Text);
                ProprietarioDao Prodao = new ProprietarioDao();
                Prodao.Inserir(Pro);
            }
        }*/



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
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


        private void btnInserir_Click(object sender, EventArgs e)

        {

            Proprietario pro = new Proprietario(textBox2.Text, Sexo, mtbCPF.Text, textBox5.Text, mtbTelefone.Text, btnNovo.Text);
            ProprietarioDao propdao = new ProprietarioDao();
            propdao.Inserir(pro);
        }   

        private void btnNovo_Click(object sender, EventArgs e)
            
        {
            textBox2.Clear();
            Sexo = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            mtbCPF.Clear();
            textBox7.Clear();
            textBox5.Clear();
            mtbTelefone.Clear();
            textBox7.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
