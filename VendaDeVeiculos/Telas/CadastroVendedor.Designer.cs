
namespace VendaDeVeiculos.Telas
{
    partial class CadastroVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVendedor));
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.mtbFone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.tbCompl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btPesquisaCidade = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Enabled = false;
            this.tbNomeCidade.Location = new System.Drawing.Point(486, 93);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.ReadOnly = true;
            this.tbNomeCidade.Size = new System.Drawing.Size(178, 20);
            this.tbNomeCidade.TabIndex = 68;
            // 
            // mtbNum
            // 
            this.mtbNum.Location = new System.Drawing.Point(424, 241);
            this.mtbNum.Mask = "0000";
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(195, 20);
            this.mtbNum.TabIndex = 66;
            this.mtbNum.ValidatingType = typeof(int);
            // 
            // mtbFone
            // 
            this.mtbFone.Location = new System.Drawing.Point(176, 291);
            this.mtbFone.Mask = "(99)99999-9999";
            this.mtbFone.Name = "mtbFone";
            this.mtbFone.Size = new System.Drawing.Size(195, 20);
            this.mtbFone.TabIndex = 62;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(176, 191);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(195, 20);
            this.mtbCpf.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(173, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "Data de Nascimento";
            // 
            // dtpNasc
            // 
            this.dtpNasc.Location = new System.Drawing.Point(176, 342);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(227, 20);
            this.dtpNasc.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(176, 241);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 55;
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complemento.Location = new System.Drawing.Point(421, 273);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(85, 15);
            this.Complemento.TabIndex = 54;
            this.Complemento.Text = "Complemento";
            // 
            // tbCompl
            // 
            this.tbCompl.Location = new System.Drawing.Point(424, 291);
            this.tbCompl.MaxLength = 50;
            this.tbCompl.Name = "tbCompl";
            this.tbCompl.Size = new System.Drawing.Size(195, 20);
            this.tbCompl.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Logradouro";
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(424, 191);
            this.tbLogradouro.MaxLength = 100;
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(195, 20);
            this.tbLogradouro.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Bairro";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(424, 140);
            this.tbBairro.MaxLength = 100;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(195, 20);
            this.tbBairro.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(424, 93);
            this.tbCidade.MaxLength = 3;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(37, 20);
            this.tbCidade.TabIndex = 46;
            this.tbCidade.Leave += new System.EventHandler(this.tbCidade_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nome Completo";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(176, 144);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(195, 20);
            this.tbNome.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cadastro de Vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(176, 97);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(84, 20);
            this.tbCodigo.TabIndex = 38;
            // 
            // btPesquisaCidade
            // 
            this.btPesquisaCidade.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisaCidade.Image")));
            this.btPesquisaCidade.Location = new System.Drawing.Point(461, 92);
            this.btPesquisaCidade.Name = "btPesquisaCidade";
            this.btPesquisaCidade.Size = new System.Drawing.Size(25, 22);
            this.btPesquisaCidade.TabIndex = 67;
            this.btPesquisaCidade.UseVisualStyleBackColor = true;
            this.btPesquisaCidade.Click += new System.EventHandler(this.btPesquisaCidade_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_lixo_25;
            this.btDeletar.Location = new System.Drawing.Point(42, 305);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 51);
            this.btDeletar.TabIndex = 65;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_excluir_25;
            this.btCancelar.Location = new System.Drawing.Point(42, 248);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 51);
            this.btCancelar.TabIndex = 64;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_pesquisar_25;
            this.btPesquisar.Location = new System.Drawing.Point(42, 191);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 51);
            this.btPesquisar.TabIndex = 63;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::VendaDeVeiculos.Properties.Resources.icons8_salvar_25;
            this.btnGravar.Location = new System.Drawing.Point(42, 133);
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
            this.btnNovo.Location = new System.Drawing.Point(42, 76);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 51);
            this.btnNovo.TabIndex = 41;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CadastroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNomeCidade);
            this.Controls.Add(this.btPesquisaCidade);
            this.Controls.Add(this.mtbNum);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.mtbFone);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.tbCompl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLogradouro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.Name = "CadastroVendedor";
            this.Text = "Cadastro de Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeCidade;
        private System.Windows.Forms.Button btPesquisaCidade;
        private System.Windows.Forms.MaskedTextBox mtbNum;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.MaskedTextBox mtbFone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.TextBox tbCompl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}