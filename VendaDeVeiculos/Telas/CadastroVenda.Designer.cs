
namespace VendaDeVeiculos.Telas
{
    partial class CadastroVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVenda));
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCliId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btPesqCli = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbNomeVdr = new System.Windows.Forms.TextBox();
            this.btPesqVdr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVdrId = new System.Windows.Forms.TextBox();
            this.tbNomeVcl = new System.Windows.Forms.TextBox();
            this.btPesqVcl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVclId = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAdd = new System.Windows.Forms.NumericUpDown();
            this.nudDesc = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTrib = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPagamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbVlrTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrib)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Enabled = false;
            this.tbNomeCli.Location = new System.Drawing.Point(226, 157);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.ReadOnly = true;
            this.tbNomeCli.Size = new System.Drawing.Size(178, 20);
            this.tbNomeCli.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cliente";
            // 
            // tbCliId
            // 
            this.tbCliId.Location = new System.Drawing.Point(164, 157);
            this.tbCliId.MaxLength = 3;
            this.tbCliId.Name = "tbCliId";
            this.tbCliId.Size = new System.Drawing.Size(37, 20);
            this.tbCliId.TabIndex = 46;
            this.tbCliId.Leave += new System.EventHandler(this.tbCliId_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cadastro de Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(163, 105);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(84, 20);
            this.tbCodigo.TabIndex = 38;
            // 
            // btPesqCli
            // 
            this.btPesqCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesqCli.Image")));
            this.btPesqCli.Location = new System.Drawing.Point(201, 156);
            this.btPesqCli.Name = "btPesqCli";
            this.btPesqCli.Size = new System.Drawing.Size(25, 22);
            this.btPesqCli.TabIndex = 67;
            this.btPesqCli.UseVisualStyleBackColor = true;
            this.btPesqCli.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_lixo_25;
            this.btnDeletar.Location = new System.Drawing.Point(29, 313);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 51);
            this.btnDeletar.TabIndex = 65;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_excluir_25;
            this.btnCancelar.Location = new System.Drawing.Point(29, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 51);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_25;
            this.btnPesquisar.Location = new System.Drawing.Point(29, 199);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 51);
            this.btnPesquisar.TabIndex = 63;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_salvar_25;
            this.btnGravar.Location = new System.Drawing.Point(29, 141);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 51);
            this.btnGravar.TabIndex = 45;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::VendaDeVeiculos.Properties.Resources.icons8_soma_25;
            this.btnNovo.Location = new System.Drawing.Point(29, 84);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 51);
            this.btnNovo.TabIndex = 41;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tbNomeVdr
            // 
            this.tbNomeVdr.Enabled = false;
            this.tbNomeVdr.Location = new System.Drawing.Point(226, 207);
            this.tbNomeVdr.Name = "tbNomeVdr";
            this.tbNomeVdr.ReadOnly = true;
            this.tbNomeVdr.Size = new System.Drawing.Size(178, 20);
            this.tbNomeVdr.TabIndex = 72;
            // 
            // btPesqVdr
            // 
            this.btPesqVdr.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVdr.Image")));
            this.btPesqVdr.Location = new System.Drawing.Point(201, 206);
            this.btPesqVdr.Name = "btPesqVdr";
            this.btPesqVdr.Size = new System.Drawing.Size(25, 22);
            this.btPesqVdr.TabIndex = 71;
            this.btPesqVdr.UseVisualStyleBackColor = true;
            this.btPesqVdr.Click += new System.EventHandler(this.btPesqVdr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Vendedor";
            // 
            // tbVdrId
            // 
            this.tbVdrId.Location = new System.Drawing.Point(164, 207);
            this.tbVdrId.MaxLength = 3;
            this.tbVdrId.Name = "tbVdrId";
            this.tbVdrId.Size = new System.Drawing.Size(37, 20);
            this.tbVdrId.TabIndex = 69;
            this.tbVdrId.Leave += new System.EventHandler(this.tbVdrId_Leave);
            // 
            // tbNomeVcl
            // 
            this.tbNomeVcl.Enabled = false;
            this.tbNomeVcl.Location = new System.Drawing.Point(226, 258);
            this.tbNomeVcl.Name = "tbNomeVcl";
            this.tbNomeVcl.ReadOnly = true;
            this.tbNomeVcl.Size = new System.Drawing.Size(178, 20);
            this.tbNomeVcl.TabIndex = 76;
            // 
            // btPesqVcl
            // 
            this.btPesqVcl.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVcl.Image")));
            this.btPesqVcl.Location = new System.Drawing.Point(201, 257);
            this.btPesqVcl.Name = "btPesqVcl";
            this.btPesqVcl.Size = new System.Drawing.Size(25, 22);
            this.btPesqVcl.TabIndex = 75;
            this.btPesqVcl.UseVisualStyleBackColor = true;
            this.btPesqVcl.Click += new System.EventHandler(this.btPesqVcl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Veículo";
            // 
            // tbVclId
            // 
            this.tbVclId.Location = new System.Drawing.Point(164, 258);
            this.tbVclId.MaxLength = 3;
            this.tbVclId.Name = "tbVclId";
            this.tbVclId.Size = new System.Drawing.Size(37, 20);
            this.tbVclId.TabIndex = 73;
            this.tbVclId.Leave += new System.EventHandler(this.tbVclId_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(164, 308);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(102, 20);
            this.dtpData.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 80;
            this.label7.Text = "Adicionais";
            // 
            // nudAdd
            // 
            this.nudAdd.DecimalPlaces = 2;
            this.nudAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudAdd.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudAdd.Location = new System.Drawing.Point(453, 105);
            this.nudAdd.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAdd.Name = "nudAdd";
            this.nudAdd.Size = new System.Drawing.Size(133, 20);
            this.nudAdd.TabIndex = 81;
            this.nudAdd.ThousandsSeparator = true;
            this.nudAdd.Leave += new System.EventHandler(this.nudAdd_Leave);
            // 
            // nudDesc
            // 
            this.nudDesc.DecimalPlaces = 2;
            this.nudDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudDesc.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudDesc.Location = new System.Drawing.Point(453, 156);
            this.nudDesc.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDesc.Name = "nudDesc";
            this.nudDesc.Size = new System.Drawing.Size(133, 20);
            this.nudDesc.TabIndex = 83;
            this.nudDesc.ThousandsSeparator = true;
            this.nudDesc.Leave += new System.EventHandler(this.nudDesc_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Descontos";
            // 
            // nudTrib
            // 
            this.nudTrib.DecimalPlaces = 2;
            this.nudTrib.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudTrib.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudTrib.Location = new System.Drawing.Point(453, 206);
            this.nudTrib.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudTrib.Name = "nudTrib";
            this.nudTrib.Size = new System.Drawing.Size(133, 20);
            this.nudTrib.TabIndex = 85;
            this.nudTrib.ThousandsSeparator = true;
            this.nudTrib.Leave += new System.EventHandler(this.nudTrib_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Tributos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 15);
            this.label10.TabIndex = 87;
            this.label10.Text = "Forma de Pagamento";
            // 
            // tbPagamento
            // 
            this.tbPagamento.Location = new System.Drawing.Point(453, 258);
            this.tbPagamento.MaxLength = 20;
            this.tbPagamento.Name = "tbPagamento";
            this.tbPagamento.Size = new System.Drawing.Size(201, 20);
            this.tbPagamento.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(450, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 89;
            this.label11.Text = "Valor Total";
            // 
            // tbVlrTotal
            // 
            this.tbVlrTotal.Enabled = false;
            this.tbVlrTotal.Location = new System.Drawing.Point(453, 308);
            this.tbVlrTotal.MaxLength = 20;
            this.tbVlrTotal.Name = "tbVlrTotal";
            this.tbVlrTotal.ReadOnly = true;
            this.tbVlrTotal.Size = new System.Drawing.Size(133, 20);
            this.tbVlrTotal.TabIndex = 88;
            this.tbVlrTotal.Text = "R$ 00,00";
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbVlrTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPagamento);
            this.Controls.Add(this.nudTrib);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpData);
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
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCliId);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.Name = "CadastroVenda";
            this.Text = "CadastroVenda";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.Button btPesqCli;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliId;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNomeVdr;
        private System.Windows.Forms.Button btPesqVdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVdrId;
        private System.Windows.Forms.TextBox tbNomeVcl;
        private System.Windows.Forms.Button btPesqVcl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVclId;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAdd;
        private System.Windows.Forms.NumericUpDown nudDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTrib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbVlrTotal;
    }
}