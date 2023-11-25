namespace ProjetoFinalGil
{
    partial class CadastrarProprietario
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1ENDERECO = new System.Windows.Forms.Label();
            this.label1TELEFONE = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1EMAIL = new System.Windows.Forms.Label();
            this.label1CPF = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1Nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tableAdapterManager1 = new ProjetoFinalGil.PROJETOFINALGILDataSet1TableAdapters.TableAdapterManager();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 481);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(44, 387);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(146, 27);
            this.btnInserir.TabIndex = 30;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(204, 307);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(410, 20);
            this.textBox7.TabIndex = 29;
            // 
            // label1ENDERECO
            // 
            this.label1ENDERECO.AutoSize = true;
            this.label1ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ENDERECO.Location = new System.Drawing.Point(40, 307);
            this.label1ENDERECO.Name = "label1ENDERECO";
            this.label1ENDERECO.Size = new System.Drawing.Size(117, 24);
            this.label1ENDERECO.TabIndex = 28;
            this.label1ENDERECO.Text = "ENDERECO";
            // 
            // label1TELEFONE
            // 
            this.label1TELEFONE.AutoSize = true;
            this.label1TELEFONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1TELEFONE.Location = new System.Drawing.Point(40, 255);
            this.label1TELEFONE.Name = "label1TELEFONE";
            this.label1TELEFONE.Size = new System.Drawing.Size(112, 24);
            this.label1TELEFONE.TabIndex = 26;
            this.label1TELEFONE.Text = "TELEFONE";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(361, 20);
            this.textBox5.TabIndex = 25;
            // 
            // label1EMAIL
            // 
            this.label1EMAIL.AutoSize = true;
            this.label1EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1EMAIL.Location = new System.Drawing.Point(40, 209);
            this.label1EMAIL.Name = "label1EMAIL";
            this.label1EMAIL.Size = new System.Drawing.Size(66, 24);
            this.label1EMAIL.TabIndex = 24;
            this.label1EMAIL.Text = "EMAIL";
            // 
            // label1CPF
            // 
            this.label1CPF.AutoSize = true;
            this.label1CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CPF.Location = new System.Drawing.Point(40, 163);
            this.label1CPF.Name = "label1CPF";
            this.label1CPF.Size = new System.Drawing.Size(47, 24);
            this.label1CPF.TabIndex = 22;
            this.label1CPF.Text = "CPF";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1Nome
            // 
            this.label1Nome.AutoSize = true;
            this.label1Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Nome.Location = new System.Drawing.Point(40, 74);
            this.label1Nome.Name = "label1Nome";
            this.label1Nome.Size = new System.Drawing.Size(68, 24);
            this.label1Nome.TabIndex = 18;
            this.label1Nome.Text = "NOME";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(160, 171);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(160, 20);
            this.mtbCPF.TabIndex = 33;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.PROPRIETARIOTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProjetoFinalGil.PROJETOFINALGILDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(160, 259);
            this.mtbTelefone.Mask = "00 00000 - 0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(160, 20);
            this.mtbTelefone.TabIndex = 34;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(285, 387);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(160, 27);
            this.btnNovo.TabIndex = 36;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(44, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 36);
            this.panel1.TabIndex = 37;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(192, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(62, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(54, 107);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(54, 24);
            this.lbSexo.TabIndex = 38;
            this.lbSexo.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cadastrar de Proprietario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadastrarProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1032, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1ENDERECO);
            this.Controls.Add(this.label1TELEFONE);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1EMAIL);
            this.Controls.Add(this.label1CPF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1Nome);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CadastrarProprietario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1ENDERECO;
        private System.Windows.Forms.Label label1TELEFONE;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1EMAIL;
        private System.Windows.Forms.Label label1CPF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private PROJETOFINALGILDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label label1;
    }
}