
namespace VendaDeVeiculos.Telas
{
    partial class ConsultaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVenda));
            this.label6 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.venId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbNomeVcl = new System.Windows.Forms.TextBox();
            this.btPesqVcl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVclId = new System.Windows.Forms.TextBox();
            this.tbNomeVdr = new System.Windows.Forms.TextBox();
            this.btPesqVdr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVdrId = new System.Windows.Forms.TextBox();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.btPesqCli = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCliId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataAte = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Valor abaixo de";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudValor.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudValor.Location = new System.Drawing.Point(408, 84);
            this.nudValor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(133, 20);
            this.nudValor.TabIndex = 107;
            this.nudValor.ThousandsSeparator = true;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(41, 33);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Código";
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venId,
            this.marcaVeiculo,
            this.nomeCliente,
            this.nomeVendedor,
            this.venData});
            this.dgVendas.Location = new System.Drawing.Point(42, 194);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.ReadOnly = true;
            this.dgVendas.Size = new System.Drawing.Size(874, 201);
            this.dgVendas.TabIndex = 93;
            this.dgVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendas_CellDoubleClick);
            // 
            // venId
            // 
            this.venId.DataPropertyName = "venId";
            this.venId.HeaderText = "Código";
            this.venId.Name = "venId";
            this.venId.ReadOnly = true;
            this.venId.Width = 70;
            // 
            // marcaVeiculo
            // 
            this.marcaVeiculo.DataPropertyName = "marcaVeiculo";
            this.marcaVeiculo.HeaderText = "Veículo";
            this.marcaVeiculo.Name = "marcaVeiculo";
            this.marcaVeiculo.ReadOnly = true;
            this.marcaVeiculo.Width = 220;
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "nomeCliente";
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 220;
            // 
            // nomeVendedor
            // 
            this.nomeVendedor.DataPropertyName = "nomeVendedor";
            this.nomeVendedor.HeaderText = "Vendedor";
            this.nomeVendedor.Name = "nomeVendedor";
            this.nomeVendedor.ReadOnly = true;
            this.nomeVendedor.Width = 220;
            // 
            // venData
            // 
            this.venData.DataPropertyName = "venData";
            this.venData.HeaderText = "Data";
            this.venData.Name = "venData";
            this.venData.ReadOnly = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_vassoura_15;
            this.btLimpar.Location = new System.Drawing.Point(837, 165);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(79, 23);
            this.btLimpar.TabIndex = 102;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btTodos.Location = new System.Drawing.Point(752, 165);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(79, 23);
            this.btTodos.TabIndex = 101;
            this.btTodos.Text = "Todos";
            this.btTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btPesquisar.Location = new System.Drawing.Point(659, 165);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btPesquisar.TabIndex = 100;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbNomeVcl
            // 
            this.tbNomeVcl.Enabled = false;
            this.tbNomeVcl.Location = new System.Drawing.Point(104, 85);
            this.tbNomeVcl.Name = "tbNomeVcl";
            this.tbNomeVcl.ReadOnly = true;
            this.tbNomeVcl.Size = new System.Drawing.Size(275, 20);
            this.tbNomeVcl.TabIndex = 120;
            // 
            // btPesqVcl
            // 
            this.btPesqVcl.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVcl.Image")));
            this.btPesqVcl.Location = new System.Drawing.Point(79, 84);
            this.btPesqVcl.Name = "btPesqVcl";
            this.btPesqVcl.Size = new System.Drawing.Size(25, 22);
            this.btPesqVcl.TabIndex = 119;
            this.btPesqVcl.UseVisualStyleBackColor = true;
            this.btPesqVcl.Click += new System.EventHandler(this.btPesqVcl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 118;
            this.label4.Text = "Veículo";
            // 
            // tbVclId
            // 
            this.tbVclId.Location = new System.Drawing.Point(42, 85);
            this.tbVclId.MaxLength = 3;
            this.tbVclId.Name = "tbVclId";
            this.tbVclId.Size = new System.Drawing.Size(37, 20);
            this.tbVclId.TabIndex = 117;
            this.tbVclId.Leave += new System.EventHandler(this.tbVclId_Leave);
            // 
            // tbNomeVdr
            // 
            this.tbNomeVdr.Enabled = false;
            this.tbNomeVdr.Location = new System.Drawing.Point(647, 32);
            this.tbNomeVdr.Name = "tbNomeVdr";
            this.tbNomeVdr.ReadOnly = true;
            this.tbNomeVdr.Size = new System.Drawing.Size(269, 20);
            this.tbNomeVdr.TabIndex = 116;
            // 
            // btPesqVdr
            // 
            this.btPesqVdr.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVdr.Image")));
            this.btPesqVdr.Location = new System.Drawing.Point(622, 31);
            this.btPesqVdr.Name = "btPesqVdr";
            this.btPesqVdr.Size = new System.Drawing.Size(25, 22);
            this.btPesqVdr.TabIndex = 115;
            this.btPesqVdr.UseVisualStyleBackColor = true;
            this.btPesqVdr.Click += new System.EventHandler(this.btPesqVdr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 114;
            this.label3.Text = "Vendedor";
            // 
            // tbVdrId
            // 
            this.tbVdrId.Location = new System.Drawing.Point(585, 32);
            this.tbVdrId.MaxLength = 3;
            this.tbVdrId.Name = "tbVdrId";
            this.tbVdrId.Size = new System.Drawing.Size(37, 20);
            this.tbVdrId.TabIndex = 113;
            this.tbVdrId.Leave += new System.EventHandler(this.tbVdrId_Leave);
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Enabled = false;
            this.tbNomeCli.Location = new System.Drawing.Point(245, 33);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.ReadOnly = true;
            this.tbNomeCli.Size = new System.Drawing.Size(296, 20);
            this.tbNomeCli.TabIndex = 112;
            // 
            // btPesqCli
            // 
            this.btPesqCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesqCli.Image")));
            this.btPesqCli.Location = new System.Drawing.Point(220, 32);
            this.btPesqCli.Name = "btPesqCli";
            this.btPesqCli.Size = new System.Drawing.Size(25, 22);
            this.btPesqCli.TabIndex = 111;
            this.btPesqCli.UseVisualStyleBackColor = true;
            this.btPesqCli.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Cliente";
            // 
            // tbCliId
            // 
            this.tbCliId.Location = new System.Drawing.Point(183, 33);
            this.tbCliId.MaxLength = 3;
            this.tbCliId.Name = "tbCliId";
            this.tbCliId.Size = new System.Drawing.Size(37, 20);
            this.tbCliId.TabIndex = 109;
            this.tbCliId.Leave += new System.EventHandler(this.tbCliId_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataAte);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDataIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(585, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 92);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de emissão";
            // 
            // dtpDataAte
            // 
            this.dtpDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAte.Location = new System.Drawing.Point(189, 42);
            this.dtpDataAte.Name = "dtpDataAte";
            this.dtpDataAte.Size = new System.Drawing.Size(114, 20);
            this.dtpDataAte.TabIndex = 125;
            this.dtpDataAte.Leave += new System.EventHandler(this.dtpDataAte_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "Até:";
            // 
            // dtpDataIni
            // 
            this.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIni.Location = new System.Drawing.Point(25, 42);
            this.dtpDataIni.Name = "dtpDataIni";
            this.dtpDataIni.Size = new System.Drawing.Size(118, 20);
            this.dtpDataIni.TabIndex = 123;
            this.dtpDataIni.Leave += new System.EventHandler(this.dtpDataIni_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "De:";
            // 
            // ConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNomeVcl);
            this.Controls.Add(this.btPesqVcl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVclId);
            this.Controls.Add(this.tbNomeVdr);
            this.Controls.Add(this.btPesqVdr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVdrId);
            this.Controls.Add(this.tbNomeCli);
            this.Controls.Add(this.btPesqCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCliId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaVenda";
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.ConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.TextBox tbNomeVcl;
        private System.Windows.Forms.Button btPesqVcl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVclId;
        private System.Windows.Forms.TextBox tbNomeVdr;
        private System.Windows.Forms.Button btPesqVdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVdrId;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.Button btPesqCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataAte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn venId;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn venData;
    }
}