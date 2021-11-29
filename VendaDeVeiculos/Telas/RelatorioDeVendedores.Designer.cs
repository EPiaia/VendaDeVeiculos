
namespace VendaDeVeiculos.Telas
{
    partial class RelatorioDeVendedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioDeVendedores));
            this.VendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGerarRelat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // VendedorBindingSource
            // 
            this.VendedorBindingSource.DataSource = typeof(VendaDeVeiculos.Model.Vendedor);
            // 
            // btnGerarRelat
            // 
            this.btnGerarRelat.Image = global::VendaDeVeiculos.Properties.Resources.icons8_documento_30;
            this.btnGerarRelat.Location = new System.Drawing.Point(1102, 67);
            this.btnGerarRelat.Name = "btnGerarRelat";
            this.btnGerarRelat.Size = new System.Drawing.Size(127, 39);
            this.btnGerarRelat.TabIndex = 1;
            this.btnGerarRelat.Text = "Gerar Relatório";
            this.btnGerarRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelat.UseVisualStyleBackColor = true;
            this.btnGerarRelat.Click += new System.EventHandler(this.btnGerarRelat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbData);
            this.panel1.Controls.Add(this.gbData);
            this.panel1.Controls.Add(this.mtbCpfCnpj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.btnGerarRelat);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 109);
            this.panel1.TabIndex = 5;
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(616, 25);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(93, 17);
            this.cbData.TabIndex = 8;
            this.cbData.Text = "Filtrar por data";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.dtpFim);
            this.gbData.Controls.Add(this.dtpIni);
            this.gbData.Location = new System.Drawing.Point(731, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(308, 81);
            this.gbData.TabIndex = 7;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "De";
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
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(409, 25);
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(181, 20);
            this.mtbCpfCnpj.TabIndex = 6;
            this.mtbCpfCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbCpfCnpj_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(13, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(377, 20);
            this.tbNome.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VendaDeVeiculos.Telas.RelatorioVendedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1231, 391);
            this.reportViewer1.TabIndex = 6;
            // 
            // RelatorioDeVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 524);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioDeVendedores";
            this.Text = "Relatorio De Vendedores";
            this.Load += new System.EventHandler(this.RelatorioDeVendedores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGerarRelat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendedorBindingSource;
    }
}