
namespace VendaDeVeiculos.Telas
{
    partial class RelatorioDeVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioDeVeiculos));
            this.VeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGerarRelat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.cbUsado = new System.Windows.Forms.ComboBox();
            this.cbVendidos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VeiculoBindingSource
            // 
            this.VeiculoBindingSource.DataSource = typeof(VendaDeVeiculos.Model.Veiculo);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VeiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VendaDeVeiculos.Telas.RelatorioVeiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1228, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGerarRelat
            // 
            this.btnGerarRelat.Image = global::VendaDeVeiculos.Properties.Resources.icons8_documento_30;
            this.btnGerarRelat.Location = new System.Drawing.Point(1113, 85);
            this.btnGerarRelat.Name = "btnGerarRelat";
            this.btnGerarRelat.Size = new System.Drawing.Size(127, 39);
            this.btnGerarRelat.TabIndex = 2;
            this.btnGerarRelat.Text = "Gerar Relatório";
            this.btnGerarRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerarRelat.UseVisualStyleBackColor = true;
            this.btnGerarRelat.Click += new System.EventHandler(this.btnGerarRelat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(12, 31);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(263, 20);
            this.tbMarca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo/Ano";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(301, 30);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(289, 20);
            this.tbModelo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(612, 30);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(206, 20);
            this.tbTipo.TabIndex = 8;
            // 
            // cbUsado
            // 
            this.cbUsado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsado.FormattingEnabled = true;
            this.cbUsado.Items.AddRange(new object[] {
            "Todos",
            "Usados",
            "Novos"});
            this.cbUsado.Location = new System.Drawing.Point(853, 29);
            this.cbUsado.Name = "cbUsado";
            this.cbUsado.Size = new System.Drawing.Size(121, 21);
            this.cbUsado.TabIndex = 12;
            // 
            // cbVendidos
            // 
            this.cbVendidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendidos.FormattingEnabled = true;
            this.cbVendidos.Items.AddRange(new object[] {
            "Todos",
            "Vendidos",
            "Não Vendidos"});
            this.cbVendidos.Location = new System.Drawing.Point(1004, 29);
            this.cbVendidos.Name = "cbVendidos";
            this.cbVendidos.Size = new System.Drawing.Size(121, 21);
            this.cbVendidos.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1001, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vendidos";
            // 
            // RelatorioDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVendidos);
            this.Controls.Add(this.cbUsado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnGerarRelat);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioDeVeiculos";
            this.Text = "Relatorio De Veiculos";
            this.Load += new System.EventHandler(this.RelatorioDeVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGerarRelat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.ComboBox cbUsado;
        private System.Windows.Forms.ComboBox cbVendidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource VeiculoBindingSource;
    }
}