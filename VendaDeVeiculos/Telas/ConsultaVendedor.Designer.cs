
namespace VendaDeVeiculos.Telas
{
    partial class ConsultaVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVendedor));
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVendedores = new System.Windows.Forms.DataGridView();
            this.vdrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdrNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdrCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdrNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(571, 57);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(172, 20);
            this.tbCpf.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPF";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(195, 57);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(334, 20);
            this.tbNome.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Completo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(48, 57);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // dgVendedores
            // 
            this.dgVendedores.AllowUserToAddRows = false;
            this.dgVendedores.AllowUserToDeleteRows = false;
            this.dgVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vdrId,
            this.vdrNome,
            this.vdrCpf,
            this.vdrNascimento});
            this.dgVendedores.Location = new System.Drawing.Point(48, 124);
            this.dgVendedores.Name = "dgVendedores";
            this.dgVendedores.ReadOnly = true;
            this.dgVendedores.Size = new System.Drawing.Size(695, 231);
            this.dgVendedores.TabIndex = 10;
            this.dgVendedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendedores_CellDoubleClick);
            // 
            // vdrId
            // 
            this.vdrId.DataPropertyName = "vdrId";
            this.vdrId.HeaderText = "Código";
            this.vdrId.Name = "vdrId";
            this.vdrId.ReadOnly = true;
            // 
            // vdrNome
            // 
            this.vdrNome.DataPropertyName = "vdrNome";
            this.vdrNome.HeaderText = "Nome";
            this.vdrNome.Name = "vdrNome";
            this.vdrNome.ReadOnly = true;
            this.vdrNome.Width = 280;
            // 
            // vdrCpf
            // 
            this.vdrCpf.DataPropertyName = "vdrCpf";
            this.vdrCpf.HeaderText = "CPF";
            this.vdrCpf.Name = "vdrCpf";
            this.vdrCpf.ReadOnly = true;
            this.vdrCpf.Width = 170;
            // 
            // vdrNascimento
            // 
            this.vdrNascimento.DataPropertyName = "vdrNascimento";
            this.vdrNascimento.HeaderText = "Data Nascimento";
            this.vdrNascimento.Name = "vdrNascimento";
            this.vdrNascimento.ReadOnly = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_vassoura_15;
            this.btLimpar.Location = new System.Drawing.Point(664, 95);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(79, 23);
            this.btLimpar.TabIndex = 19;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btTodos.Location = new System.Drawing.Point(579, 95);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(79, 23);
            this.btTodos.TabIndex = 18;
            this.btTodos.Text = "Todos";
            this.btTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btPesquisar.Location = new System.Drawing.Point(486, 95);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btPesquisar.TabIndex = 17;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // ConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVendedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaVendedor";
            this.Text = "Consulta de Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdrNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdrCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdrNascimento;
    }
}