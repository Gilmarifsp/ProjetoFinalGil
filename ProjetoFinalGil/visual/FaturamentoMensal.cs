﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class FaturamentoMensal : Form
    {
        public FaturamentoMensal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((int.Parse(textBox1.Text)>= progressBar1.Minimum ) & (int.Parse(textBox1.Text) <= progressBar1.Maximum))
                progressBar1.Value = int.Parse(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            {
               label1.Text = i.ToString();
                progressBar1.Value = i;
                //Thread.Sleep(200);
            } 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
