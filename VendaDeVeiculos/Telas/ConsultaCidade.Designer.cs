
namespace VendaDeVeiculos.Telas
{
    partial class ConsultaCidade
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
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCidades = new System.Windows.Forms.DataGridView();
            this.cidId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbUf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(448, 46);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(219, 20);
            this.tbPais.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "UF";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(122, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(308, 20);
            this.tbNome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(41, 47);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(64, 20);
            this.tbCodigo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // dgCidades
            // 
            this.dgCidades.AllowUserToAddRows = false;
            this.dgCidades.AllowUserToDeleteRows = false;
            this.dgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidId,
            this.cidNome,
            this.cidPais,
            this.cidUf});
            this.dgCidades.Location = new System.Drawing.Point(41, 114);
            this.dgCidades.Name = "dgCidades";
            this.dgCidades.ReadOnly = true;
            this.dgCidades.Size = new System.Drawing.Size(695, 231);
            this.dgCidades.TabIndex = 13;
            this.dgCidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCidades_CellDoubleClick);
            // 
            // cidId
            // 
            this.cidId.DataPropertyName = "cidId";
            this.cidId.HeaderText = "Código";
            this.cidId.Name = "cidId";
            this.cidId.ReadOnly = true;
            // 
            // cidNome
            // 
            this.cidNome.DataPropertyName = "cidNome";
            this.cidNome.HeaderText = "Nome";
            this.cidNome.Name = "cidNome";
            this.cidNome.ReadOnly = true;
            this.cidNome.Width = 280;
            // 
            // cidPais
            // 
            this.cidPais.DataPropertyName = "cidPais";
            this.cidPais.HeaderText = "País";
            this.cidPais.Name = "cidPais";
            this.cidPais.ReadOnly = true;
            this.cidPais.Width = 170;
            // 
            // cidUf
            // 
            this.cidUf.DataPropertyName = "cidUf";
            this.cidUf.HeaderText = "UF";
            this.cidUf.Name = "cidUf";
            this.cidUf.ReadOnly = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_vassoura_15;
            this.btLimpar.Location = new System.Drawing.Point(657, 85);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(79, 23);
            this.btLimpar.TabIndex = 21;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btTodos.Location = new System.Drawing.Point(572, 85);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(79, 23);
            this.btTodos.TabIndex = 20;
            this.btTodos.Text = "Todos";
            this.btTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btPesquisar.Location = new System.Drawing.Point(479, 85);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btPesquisar.TabIndex = 19;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbUf
            // 
            this.tbUf.Location = new System.Drawing.Point(684, 47);
            this.tbUf.MaxLength = 2;
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(52, 20);
            this.tbUf.TabIndex = 25;
            this.tbUf.Leave += new System.EventHandler(this.tbUf_Leave);
            // 
            // ConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.tbUf);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCidades);
            this.Name = "ConsultaCidade";
            this.Text = "Consulta de Cidade";
            this.Load += new System.EventHandler(this.ConsultaCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidUf;
        private System.Windows.Forms.TextBox tbUf;
    }
}