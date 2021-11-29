
namespace VendaDeVeiculos.Telas
{
    partial class RelatorioDeVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioDeVendas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNomeVdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVdrId = new System.Windows.Forms.TextBox();
            this.tbNomeCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCliId = new System.Windows.Forms.TextBox();
            this.tbNomeVcl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVclId = new System.Windows.Forms.TextBox();
            this.btPesqVcl = new System.Windows.Forms.Button();
            this.btPesqVdr = new System.Windows.Forms.Button();
            this.btPesqCli = new System.Windows.Forms.Button();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGerarRelat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataSource = typeof(VendaDeVeiculos.Model.Venda);
            // 
            // tbNomeVdr
            // 
            this.tbNomeVdr.Enabled = false;
            this.tbNomeVdr.Location = new System.Drawing.Point(480, 35);
            this.tbNomeVdr.Name = "tbNomeVdr";
            this.tbNomeVdr.ReadOnly = true;
            this.tbNomeVdr.Size = new System.Drawing.Size(269, 20);
            this.tbNomeVdr.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "Vendedor";
            // 
            // tbVdrId
            // 
            this.tbVdrId.Location = new System.Drawing.Point(418, 35);
            this.tbVdrId.MaxLength = 3;
            this.tbVdrId.Name = "tbVdrId";
            this.tbVdrId.Size = new System.Drawing.Size(37, 20);
            this.tbVdrId.TabIndex = 121;
            this.tbVdrId.Leave += new System.EventHandler(this.tbVdrId_Leave);
            // 
            // tbNomeCli
            // 
            this.tbNomeCli.Enabled = false;
            this.tbNomeCli.Location = new System.Drawing.Point(78, 36);
            this.tbNomeCli.Name = "tbNomeCli";
            this.tbNomeCli.ReadOnly = true;
            this.tbNomeCli.Size = new System.Drawing.Size(296, 20);
            this.tbNomeCli.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Cliente";
            // 
            // tbCliId
            // 
            this.tbCliId.Location = new System.Drawing.Point(16, 36);
            this.tbCliId.MaxLength = 3;
            this.tbCliId.Name = "tbCliId";
            this.tbCliId.Size = new System.Drawing.Size(37, 20);
            this.tbCliId.TabIndex = 117;
            this.tbCliId.Leave += new System.EventHandler(this.tbCliId_Leave);
            // 
            // tbNomeVcl
            // 
            this.tbNomeVcl.Enabled = false;
            this.tbNomeVcl.Location = new System.Drawing.Point(847, 35);
            this.tbNomeVcl.Name = "tbNomeVcl";
            this.tbNomeVcl.ReadOnly = true;
            this.tbNomeVcl.Size = new System.Drawing.Size(275, 20);
            this.tbNomeVcl.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 126;
            this.label4.Text = "Veículo";
            // 
            // tbVclId
            // 
            this.tbVclId.Location = new System.Drawing.Point(785, 35);
            this.tbVclId.MaxLength = 3;
            this.tbVclId.Name = "tbVclId";
            this.tbVclId.Size = new System.Drawing.Size(37, 20);
            this.tbVclId.TabIndex = 125;
            this.tbVclId.Leave += new System.EventHandler(this.tbVclId_Leave);
            // 
            // btPesqVcl
            // 
            this.btPesqVcl.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVcl.Image")));
            this.btPesqVcl.Location = new System.Drawing.Point(822, 34);
            this.btPesqVcl.Name = "btPesqVcl";
            this.btPesqVcl.Size = new System.Drawing.Size(25, 22);
            this.btPesqVcl.TabIndex = 127;
            this.btPesqVcl.UseVisualStyleBackColor = true;
            this.btPesqVcl.Click += new System.EventHandler(this.btPesqVcl_Click);
            // 
            // btPesqVdr
            // 
            this.btPesqVdr.Image = ((System.Drawing.Image)(resources.GetObject("btPesqVdr.Image")));
            this.btPesqVdr.Location = new System.Drawing.Point(455, 34);
            this.btPesqVdr.Name = "btPesqVdr";
            this.btPesqVdr.Size = new System.Drawing.Size(25, 22);
            this.btPesqVdr.TabIndex = 123;
            this.btPesqVdr.UseVisualStyleBackColor = true;
            this.btPesqVdr.Click += new System.EventHandler(this.btPesqVdr_Click);
            // 
            // btPesqCli
            // 
            this.btPesqCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesqCli.Image")));
            this.btPesqCli.Location = new System.Drawing.Point(53, 35);
            this.btPesqCli.Name = "btPesqCli";
            this.btPesqCli.Size = new System.Drawing.Size(25, 22);
            this.btPesqCli.TabIndex = 119;
            this.btPesqCli.UseVisualStyleBackColor = true;
            this.btPesqCli.Click += new System.EventHandler(this.btPesqCli_Click);
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(14, 86);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(93, 17);
            this.cbData.TabIndex = 130;
            this.cbData.Text = "Filtrar por data";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.dtpFim);
            this.gbData.Controls.Add(this.dtpIni);
            this.gbData.Location = new System.Drawing.Point(129, 73);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(308, 81);
            this.gbData.TabIndex = 129;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "De";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(180, 42);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(99, 20);
            this.dtpFim.TabIndex = 4;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(20, 42);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(99, 20);
            this.dtpIni.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VendaDeVeiculos.Telas.RelatorioVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 179);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1236, 333);
            this.reportViewer1.TabIndex = 131;
            // 
            // btnGerarRelat
            // 
            this.btnGerarRelat.Image = global::VendaDeVeiculos.Properties.Resources.icons8_documento_30;
            this.btnGerarRelat.Location = new System.Drawing.Point(1121, 134);
            this.btnGerarRelat.Name = "btnGerarRelat";
            this.btnGerarRelat.Size = new System.Drawing.Size(127, 39);
            this.btnGerarRelat.TabIndex = 132;
            this.btnGerarRelat.Text = "Gerar Relatório";
            this.btnGerarRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelat.UseVisualStyleBackColor = true;
            this.btnGerarRelat.Click += new System.EventHandler(this.btnGerarRelat_Click);
            // 
            // RelatorioDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 524);
            this.Controls.Add(this.btnGerarRelat);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.gbData);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioDeVendas";
            this.Text = "Relatorio De Vendas";
            this.Load += new System.EventHandler(this.RelatorioDeVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeVdr;
        private System.Windows.Forms.Button btPesqVdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVdrId;
        private System.Windows.Forms.TextBox tbNomeCli;
        private System.Windows.Forms.Button btPesqCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliId;
        private System.Windows.Forms.TextBox tbNomeVcl;
        private System.Windows.Forms.Button btPesqVcl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVclId;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGerarRelat;
        private System.Windows.Forms.BindingSource VendaBindingSource;
    }
}