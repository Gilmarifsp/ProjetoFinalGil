namespace ProjetoFinalGil
{
    partial class CadastrarFuncionarios
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1NOME_FUNC = new System.Windows.Forms.Label();
            this.label1CPF = new System.Windows.Forms.Label();
            this.label1ADMISSAO = new System.Windows.Forms.Label();
            this.label1SALARIO = new System.Windows.Forms.Label();
            this.label1CARGO = new System.Windows.Forms.Label();
            this.textBox7Cargo = new System.Windows.Forms.TextBox();
            this.label1DEPTO = new System.Windows.Forms.Label();
            this.textBox8Depto = new System.Windows.Forms.TextBox();
            this.CadastrarBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6Salario = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pROPRIETARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PROJETOFINALGILDataSet1 = new ProjetoFinalGil.PROJETOFINALGILDataSet1();
            this.pROJETOFINALGILDataSet = new ProjetoFinalGil.PROJETOFINALGILDataSet();
            this.pROPRIETARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPRIETARIOTableAdapter = new ProjetoFinalGil.PROJETOFINALGILDataSetTableAdapters.PROPRIETARIOTableAdapter();
            this.pROPRIETARIOTableAdapter1 = new ProjetoFinalGil.PROJETOFINALGILDataSet1TableAdapters.PROPRIETARIOTableAdapter();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBox2CPF = new System.Windows.Forms.TextBox();
            this.lbFuncionarios = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSexo = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROJETOFINALGILDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOFINALGILDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETARIOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1NOME_FUNC
            // 
            this.label1NOME_FUNC.AutoSize = true;
            this.label1NOME_FUNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1NOME_FUNC.Location = new System.Drawing.Point(30, 84);
            this.label1NOME_FUNC.Name = "label1NOME_FUNC";
            this.label1NOME_FUNC.Size = new System.Drawing.Size(68, 24);
            this.label1NOME_FUNC.TabIndex = 3;
            this.label1NOME_FUNC.Text = "NOME";
            // 
            // label1CPF
            // 
            this.label1CPF.AutoSize = true;
            this.label1CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CPF.Location = new System.Drawing.Point(30, 174);
            this.label1CPF.Name = "label1CPF";
            this.label1CPF.Size = new System.Drawing.Size(47, 24);
            this.label1CPF.TabIndex = 7;
            this.label1CPF.Text = "CPF";
            // 
            // label1ADMISSAO
            // 
            this.label1ADMISSAO.AutoSize = true;
            this.label1ADMISSAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ADMISSAO.Location = new System.Drawing.Point(29, 232);
            this.label1ADMISSAO.Name = "label1ADMISSAO";
            this.label1ADMISSAO.Size = new System.Drawing.Size(108, 24);
            this.label1ADMISSAO.TabIndex = 9;
            this.label1ADMISSAO.Text = "ADMISSAO";
            // 
            // label1SALARIO
            // 
            this.label1SALARIO.AutoSize = true;
            this.label1SALARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SALARIO.Location = new System.Drawing.Point(403, 232);
            this.label1SALARIO.Name = "label1SALARIO";
            this.label1SALARIO.Size = new System.Drawing.Size(90, 24);
            this.label1SALARIO.TabIndex = 11;
            this.label1SALARIO.Text = "SALARIO";
            // 
            // label1CARGO
            // 
            this.label1CARGO.AutoSize = true;
            this.label1CARGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CARGO.Location = new System.Drawing.Point(29, 288);
            this.label1CARGO.Name = "label1CARGO";
            this.label1CARGO.Size = new System.Drawing.Size(78, 24);
            this.label1CARGO.TabIndex = 13;
            this.label1CARGO.Text = "CARGO";
            // 
            // textBox7Cargo
            // 
            this.textBox7Cargo.Location = new System.Drawing.Point(194, 292);
            this.textBox7Cargo.Name = "textBox7Cargo";
            this.textBox7Cargo.Size = new System.Drawing.Size(161, 20);
            this.textBox7Cargo.TabIndex = 14;
            // 
            // label1DEPTO
            // 
            this.label1DEPTO.AutoSize = true;
            this.label1DEPTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1DEPTO.Location = new System.Drawing.Point(403, 292);
            this.label1DEPTO.Name = "label1DEPTO";
            this.label1DEPTO.Size = new System.Drawing.Size(75, 24);
            this.label1DEPTO.TabIndex = 15;
            this.label1DEPTO.Text = "DEPTO";
            // 
            // textBox8Depto
            // 
            this.textBox8Depto.Location = new System.Drawing.Point(521, 293);
            this.textBox8Depto.Name = "textBox8Depto";
            this.textBox8Depto.Size = new System.Drawing.Size(158, 20);
            this.textBox8Depto.TabIndex = 16;
            // 
            // CadastrarBtn
            // 
            this.CadastrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarBtn.Location = new System.Drawing.Point(34, 365);
            this.CadastrarBtn.Name = "CadastrarBtn";
            this.CadastrarBtn.Size = new System.Drawing.Size(160, 33);
            this.CadastrarBtn.TabIndex = 17;
            this.CadastrarBtn.Text = "Inserir";
            this.CadastrarBtn.UseVisualStyleBackColor = true;
            this.CadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // textBox6Salario
            // 
            this.textBox6Salario.Location = new System.Drawing.Point(534, 236);
            this.textBox6Salario.Name = "textBox6Salario";
            this.textBox6Salario.Size = new System.Drawing.Size(138, 20);
            this.textBox6Salario.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(492, 365);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(163, 33);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pROPRIETARIOBindingSource1
            // 
            this.pROPRIETARIOBindingSource1.DataMember = "PROPRIETARIO";
            this.pROPRIETARIOBindingSource1.DataSource = this.PROJETOFINALGILDataSet1;
            // 
            // PROJETOFINALGILDataSet1
            // 
            this.PROJETOFINALGILDataSet1.DataSetName = "PROJETOFINALGILDataSet1";
            this.PROJETOFINALGILDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJETOFINALGILDataSet
            // 
            this.pROJETOFINALGILDataSet.DataSetName = "PROJETOFINALGILDataSet";
            this.pROJETOFINALGILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROPRIETARIOBindingSource
            // 
            this.pROPRIETARIOBindingSource.DataMember = "PROPRIETARIO";
            this.pROPRIETARIOBindingSource.DataSource = this.pROJETOFINALGILDataSet;
            // 
            // pROPRIETARIOTableAdapter
            // 
            this.pROPRIETARIOTableAdapter.ClearBeforeFill = true;
            // 
            // pROPRIETARIOTableAdapter1
            // 
            this.pROPRIETARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(178, 88);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(252, 20);
            this.textBoxNome.TabIndex = 22;
            // 
            // textBox2CPF
            // 
            this.textBox2CPF.Location = new System.Drawing.Point(178, 174);
            this.textBox2CPF.Name = "textBox2CPF";
            this.textBox2CPF.Size = new System.Drawing.Size(200, 20);
            this.textBox2CPF.TabIndex = 25;
            this.textBox2CPF.TextChanged += new System.EventHandler(this.textBox2CPF_TextChanged);
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.AutoSize = true;
            this.lbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncionarios.Location = new System.Drawing.Point(12, 42);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(218, 24);
            this.lbFuncionarios.TabIndex = 26;
            this.lbFuncionarios.Text = "Cadastro de funcionarios";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(249, 365);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(167, 33);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSexo);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(34, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 40);
            this.panel1.TabIndex = 31;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(-5, 5);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(54, 24);
            this.lbSexo.TabIndex = 32;
            this.lbSexo.Text = "Sexo";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(187, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(63, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // CadastrarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1016, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbFuncionarios);
            this.Controls.Add(this.textBox2CPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CadastrarBtn);
            this.Controls.Add(this.textBox8Depto);
            this.Controls.Add(this.label1DEPTO);
            this.Controls.Add(this.textBox7Cargo);
            this.Controls.Add(this.label1CARGO);
            this.Controls.Add(this.textBox6Salario);
            this.Controls.Add(this.label1SALARIO);
            this.Controls.Add(this.label1ADMISSAO);
            this.Controls.Add(this.label1CPF);
            this.Controls.Add(this.label1NOME_FUNC);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CadastrarFuncionarios";
            //this.Load += new System.EventHandler(this.CadastrarFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROJETOFINALGILDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOFINALGILDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPRIETARIOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1NOME_FUNC;
        private System.Windows.Forms.Label label1CPF;
        private System.Windows.Forms.Label label1ADMISSAO;
        private System.Windows.Forms.Label label1SALARIO;
        private System.Windows.Forms.Label label1CARGO;
        private System.Windows.Forms.TextBox textBox7Cargo;
        private System.Windows.Forms.Label label1DEPTO;
        private System.Windows.Forms.TextBox textBox8Depto;
        private System.Windows.Forms.Button CadastrarBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6Salario;
        private System.Windows.Forms.Button btnSair;
        private PROJETOFINALGILDataSet pROJETOFINALGILDataSet;
        private System.Windows.Forms.BindingSource pROPRIETARIOBindingSource;
        private PROJETOFINALGILDataSetTableAdapters.PROPRIETARIOTableAdapter pROPRIETARIOTableAdapter;
        private PROJETOFINALGILDataSet1 PROJETOFINALGILDataSet1;
        private System.Windows.Forms.BindingSource pROPRIETARIOBindingSource1;
        private PROJETOFINALGILDataSet1TableAdapters.PROPRIETARIOTableAdapter pROPRIETARIOTableAdapter1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBox2CPF;
        private System.Windows.Forms.Label lbFuncionarios;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}