namespace ProjetoFinalGil
{
    partial class ListarFuncionarios
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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOME_FUNC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SEXO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADMISSAO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SALARIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CARGO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DEPTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cadastrobutton1 = new System.Windows.Forms.Button();
            this.Atualizarbutton2 = new System.Windows.Forms.Button();
            this.Excluirbutton3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NOME_FUNC,
            this.SEXO,
            this.CPF,
            this.ADMISSAO,
            this.SALARIO,
            this.CARGO,
            this.DEPTO});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NOME_FUNC
            // 
            this.NOME_FUNC.Text = "NOME_FUNC";
            this.NOME_FUNC.Width = 129;
            // 
            // SEXO
            // 
            this.SEXO.Text = "SEXO";
            this.SEXO.Width = 107;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 129;
            // 
            // ADMISSAO
            // 
            this.ADMISSAO.Text = "ADMISSAO";
            this.ADMISSAO.Width = 111;
            // 
            // SALARIO
            // 
            this.SALARIO.Text = "SALARIO";
            this.SALARIO.Width = 89;
            // 
            // CARGO
            // 
            this.CARGO.Text = "CARGO";
            this.CARGO.Width = 97;
            // 
            // DEPTO
            // 
            this.DEPTO.Text = "DEPTO";
            // 
            // Cadastrobutton1
            // 
            this.Cadastrobutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrobutton1.Location = new System.Drawing.Point(27, 372);
            this.Cadastrobutton1.Name = "Cadastrobutton1";
            this.Cadastrobutton1.Size = new System.Drawing.Size(138, 35);
            this.Cadastrobutton1.TabIndex = 1;
            this.Cadastrobutton1.Text = "CADASTRAR";
            this.Cadastrobutton1.UseVisualStyleBackColor = true;
            // 
            // Atualizarbutton2
            // 
            this.Atualizarbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizarbutton2.Location = new System.Drawing.Point(226, 372);
            this.Atualizarbutton2.Name = "Atualizarbutton2";
            this.Atualizarbutton2.Size = new System.Drawing.Size(284, 35);
            this.Atualizarbutton2.TabIndex = 2;
            this.Atualizarbutton2.Text = "ATUALIZAR FUNCIONARIOS";
            this.Atualizarbutton2.UseVisualStyleBackColor = true;
            // 
            // Excluirbutton3
            // 
            this.Excluirbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluirbutton3.Location = new System.Drawing.Point(574, 372);
            this.Excluirbutton3.Name = "Excluirbutton3";
            this.Excluirbutton3.Size = new System.Drawing.Size(165, 35);
            this.Excluirbutton3.TabIndex = 3;
            this.Excluirbutton3.Text = "EXCLUIR";
            this.Excluirbutton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(806, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Excluirbutton3);
            this.Controls.Add(this.Atualizarbutton2);
            this.Controls.Add(this.Cadastrobutton1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListarFuncionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NOME_FUNC;
        private System.Windows.Forms.ColumnHeader SEXO;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader ADMISSAO;
        private System.Windows.Forms.ColumnHeader SALARIO;
        private System.Windows.Forms.ColumnHeader CARGO;
        private System.Windows.Forms.Button Cadastrobutton1;
        private System.Windows.Forms.Button Atualizarbutton2;
        private System.Windows.Forms.Button Excluirbutton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader DEPTO;
    }
}