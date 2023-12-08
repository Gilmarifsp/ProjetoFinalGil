namespace ProjetoFinalGil
{
    partial class ListaCliente
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
            this.ClientesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cadastrobutton1 = new System.Windows.Forms.Button();
            this.Atualizarbutton1 = new System.Windows.Forms.Button();
            this.excluirbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1Pesquisa = new System.Windows.Forms.TextBox();
            this.button2PesquisarCliente = new System.Windows.Forms.Button();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ClientesListView
            // 
            this.ClientesListView.BackColor = System.Drawing.Color.Azure;
            this.ClientesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader8});
            this.ClientesListView.FullRowSelect = true;
            this.ClientesListView.HideSelection = false;
            this.ClientesListView.Location = new System.Drawing.Point(39, 40);
            this.ClientesListView.Name = "ClientesListView";
            this.ClientesListView.Size = new System.Drawing.Size(767, 377);
            this.ClientesListView.TabIndex = 0;
            this.ClientesListView.UseCompatibleStateImageBehavior = false;
            this.ClientesListView.View = System.Windows.Forms.View.Details;
            this.ClientesListView.SelectedIndexChanged += new System.EventHandler(this.ClientesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NOME";
            this.columnHeader3.Width = 164;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EMAIL";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TELEFONE";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ENDEREÇO";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CPF";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 6;
            this.columnHeader2.Text = "CIDADE";
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 7;
            this.columnHeader8.Text = "UF";
            // 
            // cadastrobutton1
            // 
            this.cadastrobutton1.Location = new System.Drawing.Point(63, 367);
            this.cadastrobutton1.Name = "cadastrobutton1";
            this.cadastrobutton1.Size = new System.Drawing.Size(103, 23);
            this.cadastrobutton1.TabIndex = 1;
            this.cadastrobutton1.Text = "Cadastrar";
            this.cadastrobutton1.UseVisualStyleBackColor = true;
            this.cadastrobutton1.Click += new System.EventHandler(this.cadastrobutton1_Click);
            // 
            // Atualizarbutton1
            // 
            this.Atualizarbutton1.Location = new System.Drawing.Point(214, 367);
            this.Atualizarbutton1.Name = "Atualizarbutton1";
            this.Atualizarbutton1.Size = new System.Drawing.Size(103, 23);
            this.Atualizarbutton1.TabIndex = 2;
            this.Atualizarbutton1.Text = "AtualizarCliente";
            this.Atualizarbutton1.UseVisualStyleBackColor = true;
            this.Atualizarbutton1.Click += new System.EventHandler(this.Atualizarbutton1_Click);
            // 
            // excluirbutton1
            // 
            this.excluirbutton1.Location = new System.Drawing.Point(348, 367);
            this.excluirbutton1.Name = "excluirbutton1";
            this.excluirbutton1.Size = new System.Drawing.Size(105, 23);
            this.excluirbutton1.TabIndex = 3;
            this.excluirbutton1.Text = "Excluir";
            this.excluirbutton1.UseVisualStyleBackColor = true;
            this.excluirbutton1.Click += new System.EventHandler(this.excluirbutton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1Pesquisa
            // 
            this.textBox1Pesquisa.Location = new System.Drawing.Point(39, 14);
            this.textBox1Pesquisa.Name = "textBox1Pesquisa";
            this.textBox1Pesquisa.Size = new System.Drawing.Size(324, 20);
            this.textBox1Pesquisa.TabIndex = 5;
            this.textBox1Pesquisa.TextChanged += new System.EventHandler(this.textBox1Pesquisa_TextChanged);
            // 
            // button2PesquisarCliente
            // 
            this.button2PesquisarCliente.Location = new System.Drawing.Point(586, 14);
            this.button2PesquisarCliente.Name = "button2PesquisarCliente";
            this.button2PesquisarCliente.Size = new System.Drawing.Size(183, 23);
            this.button2PesquisarCliente.TabIndex = 6;
            this.button2PesquisarCliente.Text = "Pesquisar";
            this.button2PesquisarCliente.UseVisualStyleBackColor = true;
            this.button2PesquisarCliente.Click += new System.EventHandler(this.button2PesquisarCliente_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "NUM";
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1144, 605);
            this.Controls.Add(this.button2PesquisarCliente);
            this.Controls.Add(this.textBox1Pesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excluirbutton1);
            this.Controls.Add(this.Atualizarbutton1);
            this.Controls.Add(this.cadastrobutton1);
            this.Controls.Add(this.ClientesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListaCliente";
            this.Load += new System.EventHandler(this.ListaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClientesListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button cadastrobutton1;
        private System.Windows.Forms.Button Atualizarbutton1;
        private System.Windows.Forms.Button excluirbutton1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1Pesquisa;
        private System.Windows.Forms.Button button2PesquisarCliente;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}