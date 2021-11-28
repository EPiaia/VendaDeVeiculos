
namespace VendaDeVeiculos.Telas
{
    partial class ConsultaVeiculo
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
            this.cbVendido = new System.Windows.Forms.ComboBox();
            this.cbUsado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVeiculos = new System.Windows.Forms.DataGridView();
            this.vclId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vclMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vclModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vclValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVendido
            // 
            this.cbVendido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendido.FormattingEnabled = true;
            this.cbVendido.Items.AddRange(new object[] {
            "Todos",
            "Vendidos",
            "Não Vendidos"});
            this.cbVendido.Location = new System.Drawing.Point(561, 88);
            this.cbVendido.Name = "cbVendido";
            this.cbVendido.Size = new System.Drawing.Size(188, 21);
            this.cbVendido.TabIndex = 92;
            // 
            // cbUsado
            // 
            this.cbUsado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsado.FormattingEnabled = true;
            this.cbUsado.Items.AddRange(new object[] {
            "Todos",
            "Usados",
            "Não Usados"});
            this.cbUsado.Location = new System.Drawing.Point(351, 88);
            this.cbUsado.Name = "cbUsado";
            this.cbUsado.Size = new System.Drawing.Size(188, 21);
            this.cbUsado.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Vendido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Usado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 88;
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
            this.nudValor.Location = new System.Drawing.Point(212, 148);
            this.nudValor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(133, 20);
            this.nudValor.TabIndex = 87;
            this.nudValor.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Km abaixo de";
            // 
            // nudKm
            // 
            this.nudKm.DecimalPlaces = 2;
            this.nudKm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudKm.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudKm.Location = new System.Drawing.Point(55, 148);
            this.nudKm.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(133, 20);
            this.nudKm.TabIndex = 85;
            this.nudKm.ThousandsSeparator = true;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(54, 89);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(271, 20);
            this.tbTipo.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Tipo";
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_vassoura_15;
            this.btLimpar.Location = new System.Drawing.Point(671, 182);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(79, 23);
            this.btLimpar.TabIndex = 82;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btTodos.Location = new System.Drawing.Point(586, 182);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(79, 23);
            this.btTodos.TabIndex = 81;
            this.btTodos.Text = "Todos";
            this.btTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_15;
            this.btPesquisar.Location = new System.Drawing.Point(493, 182);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btPesquisar.TabIndex = 80;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(480, 26);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(269, 20);
            this.tbMarca.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Marca";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(179, 26);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(279, 20);
            this.tbModelo.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Modelo/Ano";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(54, 26);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Código";
            // 
            // dgVeiculos
            // 
            this.dgVeiculos.AllowUserToAddRows = false;
            this.dgVeiculos.AllowUserToDeleteRows = false;
            this.dgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vclId,
            this.vclMarca,
            this.vclModelo,
            this.vclValor});
            this.dgVeiculos.Location = new System.Drawing.Point(55, 211);
            this.dgVeiculos.Name = "dgVeiculos";
            this.dgVeiculos.ReadOnly = true;
            this.dgVeiculos.Size = new System.Drawing.Size(695, 231);
            this.dgVeiculos.TabIndex = 73;
            this.dgVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculos_CellDoubleClick);
            // 
            // vclId
            // 
            this.vclId.DataPropertyName = "vclId";
            this.vclId.HeaderText = "Código";
            this.vclId.Name = "vclId";
            this.vclId.ReadOnly = true;
            this.vclId.Width = 70;
            // 
            // vclMarca
            // 
            this.vclMarca.DataPropertyName = "vclMarca";
            this.vclMarca.HeaderText = "Marca";
            this.vclMarca.Name = "vclMarca";
            this.vclMarca.ReadOnly = true;
            this.vclMarca.Width = 200;
            // 
            // vclModelo
            // 
            this.vclModelo.DataPropertyName = "vclModelo";
            this.vclModelo.HeaderText = "Modelo/Ano";
            this.vclModelo.Name = "vclModelo";
            this.vclModelo.ReadOnly = true;
            this.vclModelo.Width = 270;
            // 
            // vclValor
            // 
            this.vclValor.DataPropertyName = "vclValor";
            this.vclValor.HeaderText = "Valor (R$)";
            this.vclValor.Name = "vclValor";
            this.vclValor.ReadOnly = true;
            this.vclValor.Width = 110;
            // 
            // ConsultaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbVendido);
            this.Controls.Add(this.cbUsado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudKm);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVeiculos);
            this.Name = "ConsultaVeiculo";
            this.Text = "Consulta de Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVendido;
        private System.Windows.Forms.ComboBox cbUsado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudKm;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vclId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vclMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn vclModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vclValor;
    }
}