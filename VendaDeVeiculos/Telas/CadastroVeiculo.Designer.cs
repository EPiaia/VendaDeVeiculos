
namespace VendaDeVeiculos.Telas
{
    partial class CadastroVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVeiculo));
            this.btDeletar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChassi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.cbUsado = new System.Windows.Forms.CheckBox();
            this.cbVendido = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbComplemento = new System.Windows.Forms.RichTextBox();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudKm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).BeginInit();
            this.SuspendLayout();
            // 
            // btDeletar
            // 
            this.btDeletar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_lixo_25;
            this.btDeletar.Location = new System.Drawing.Point(12, 297);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 51);
            this.btDeletar.TabIndex = 39;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_excluir_25;
            this.btCancelar.Location = new System.Drawing.Point(12, 240);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 51);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_25;
            this.btPesquisar.Location = new System.Drawing.Point(12, 183);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 51);
            this.btPesquisar.TabIndex = 37;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_salvar_25;
            this.btnGravar.Location = new System.Drawing.Point(12, 125);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 51);
            this.btnGravar.TabIndex = 36;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::VendaDeVeiculos.Properties.Resources.icons8_soma_25;
            this.btnNovo.Location = new System.Drawing.Point(12, 68);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 51);
            this.btnNovo.TabIndex = 35;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cadastro de Veículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(152, 84);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(84, 20);
            this.tbCodigo.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Número do Chassi";
            // 
            // tbChassi
            // 
            this.tbChassi.Location = new System.Drawing.Point(152, 133);
            this.tbChassi.MaxLength = 30;
            this.tbChassi.Name = "tbChassi";
            this.tbChassi.Size = new System.Drawing.Size(195, 20);
            this.tbChassi.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Número do Motor";
            // 
            // tbMotor
            // 
            this.tbMotor.Location = new System.Drawing.Point(152, 182);
            this.tbMotor.MaxLength = 30;
            this.tbMotor.Name = "tbMotor";
            this.tbMotor.Size = new System.Drawing.Size(195, 20);
            this.tbMotor.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Modelo/Ano";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(152, 230);
            this.tbModelo.MaxLength = 50;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(195, 20);
            this.tbModelo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(152, 278);
            this.tbMarca.MaxLength = 50;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(195, 20);
            this.tbMarca.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(412, 84);
            this.tbTipo.MaxLength = 50;
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(195, 20);
            this.tbTipo.TabIndex = 51;
            // 
            // cbUsado
            // 
            this.cbUsado.AutoSize = true;
            this.cbUsado.Location = new System.Drawing.Point(152, 317);
            this.cbUsado.Name = "cbUsado";
            this.cbUsado.Size = new System.Drawing.Size(57, 17);
            this.cbUsado.TabIndex = 53;
            this.cbUsado.Text = "Usado";
            this.cbUsado.UseVisualStyleBackColor = true;
            // 
            // cbVendido
            // 
            this.cbVendido.AutoSize = true;
            this.cbVendido.Location = new System.Drawing.Point(226, 317);
            this.cbVendido.Name = "cbVendido";
            this.cbVendido.Size = new System.Drawing.Size(65, 17);
            this.cbVendido.TabIndex = 54;
            this.cbVendido.Text = "Vendido";
            this.cbVendido.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Quilometragem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 59;
            this.label10.Text = "Complemento";
            // 
            // rtbComplemento
            // 
            this.rtbComplemento.Location = new System.Drawing.Point(411, 230);
            this.rtbComplemento.Name = "rtbComplemento";
            this.rtbComplemento.Size = new System.Drawing.Size(196, 104);
            this.rtbComplemento.TabIndex = 60;
            this.rtbComplemento.Text = "";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudValor.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValor.Location = new System.Drawing.Point(412, 182);
            this.nudValor.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(133, 20);
            this.nudValor.TabIndex = 61;
            this.nudValor.ThousandsSeparator = true;
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
            this.nudKm.Location = new System.Drawing.Point(412, 133);
            this.nudKm.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKm.Name = "nudKm";
            this.nudKm.Size = new System.Drawing.Size(133, 20);
            this.nudKm.TabIndex = 62;
            this.nudKm.ThousandsSeparator = true;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 415);
            this.Controls.Add(this.nudKm);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.rtbComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbVendido);
            this.Controls.Add(this.cbUsado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChassi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroVeiculo";
            this.Text = "Cadastro de Veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChassi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.CheckBox cbUsado;
        private System.Windows.Forms.CheckBox cbVendido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbComplemento;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.NumericUpDown nudKm;
    }
}