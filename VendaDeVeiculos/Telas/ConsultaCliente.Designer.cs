
namespace VendaDeVeiculos.Telas
{
    partial class ConsultaCliente
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cliId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliId,
            this.cliNome,
            this.cliCpfCnpj,
            this.cliNascimento});
            this.dgClientes.Location = new System.Drawing.Point(39, 111);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(695, 231);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentDoubleClick);
            this.dgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellDoubleClick);
            // 
            // cliId
            // 
            this.cliId.DataPropertyName = "cliId";
            this.cliId.HeaderText = "Código";
            this.cliId.Name = "cliId";
            this.cliId.ReadOnly = true;
            // 
            // cliNome
            // 
            this.cliNome.DataPropertyName = "cliNome";
            this.cliNome.HeaderText = "Nome";
            this.cliNome.Name = "cliNome";
            this.cliNome.ReadOnly = true;
            this.cliNome.Width = 280;
            // 
            // cliCpfCnpj
            // 
            this.cliCpfCnpj.DataPropertyName = "cliCpfCnpj";
            this.cliCpfCnpj.HeaderText = "CPF/CNPJ";
            this.cliCpfCnpj.Name = "cliCpfCnpj";
            this.cliCpfCnpj.ReadOnly = true;
            this.cliCpfCnpj.Width = 170;
            // 
            // cliNascimento
            // 
            this.cliNascimento.DataPropertyName = "cliNascimento";
            this.cliNascimento.HeaderText = "Data Nascimento";
            this.cliNascimento.Name = "cliNascimento";
            this.cliNascimento.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(39, 44);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(186, 44);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(334, 20);
            this.tbNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF/CNPJ";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btPesquisar.Location = new System.Drawing.Point(477, 82);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btTodos.Location = new System.Drawing.Point(570, 82);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(79, 23);
            this.btTodos.TabIndex = 8;
            this.btTodos.Text = "Todos";
            this.btTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_vassoura_15;
            this.btLimpar.Location = new System.Drawing.Point(655, 82);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(79, 23);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(562, 44);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(172, 20);
            this.tbCpfCnpj.TabIndex = 6;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 376);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbCpfCnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgClientes);
            this.Name = "ConsultaCliente";
            this.Text = "Pesquisa de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNascimento;
        private System.Windows.Forms.TextBox tbCpfCnpj;
    }
}