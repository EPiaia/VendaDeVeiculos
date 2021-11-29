
namespace VendaDeVeiculos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadVenda = new System.Windows.Forms.Button();
            this.btCadVeic = new System.Windows.Forms.Button();
            this.btCadVen = new System.Windows.Forms.Button();
            this.btCadCli = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.gerarRelatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.cidadeToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click_1);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            this.veículoToolStripMenuItem.Click += new System.EventHandler(this.veículoToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.veículosToolStripMenuItem});
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btCadVenda);
            this.panel1.Controls.Add(this.btCadVeic);
            this.panel1.Controls.Add(this.btCadVen);
            this.panel1.Controls.Add(this.btCadCli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 41);
            this.panel1.TabIndex = 2;
            // 
            // btSair
            // 
            this.btSair.Image = global::VendaDeVeiculos.Properties.Resources.icons8_porta_30;
            this.btSair.Location = new System.Drawing.Point(246, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(53, 34);
            this.btSair.TabIndex = 4;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadVenda
            // 
            this.btCadVenda.Image = global::VendaDeVeiculos.Properties.Resources.icons8_car_sale_30;
            this.btCadVenda.Location = new System.Drawing.Point(187, 4);
            this.btCadVenda.Name = "btCadVenda";
            this.btCadVenda.Size = new System.Drawing.Size(53, 34);
            this.btCadVenda.TabIndex = 4;
            this.btCadVenda.UseVisualStyleBackColor = true;
            this.btCadVenda.Click += new System.EventHandler(this.btCadVenda_Click);
            // 
            // btCadVeic
            // 
            this.btCadVeic.Image = global::VendaDeVeiculos.Properties.Resources.icons8_fiat_500_30;
            this.btCadVeic.Location = new System.Drawing.Point(128, 4);
            this.btCadVeic.Name = "btCadVeic";
            this.btCadVeic.Size = new System.Drawing.Size(53, 34);
            this.btCadVeic.TabIndex = 4;
            this.btCadVeic.UseVisualStyleBackColor = true;
            this.btCadVeic.Click += new System.EventHandler(this.btCadVeic_Click);
            // 
            // btCadVen
            // 
            this.btCadVen.Image = global::VendaDeVeiculos.Properties.Resources.icons8_salesman_skin_type_1_30;
            this.btCadVen.Location = new System.Drawing.Point(69, 4);
            this.btCadVen.Name = "btCadVen";
            this.btCadVen.Size = new System.Drawing.Size(53, 34);
            this.btCadVen.TabIndex = 3;
            this.btCadVen.UseVisualStyleBackColor = true;
            this.btCadVen.Click += new System.EventHandler(this.btCadVen_Click);
            // 
            // btCadCli
            // 
            this.btCadCli.Image = global::VendaDeVeiculos.Properties.Resources.icons8_gestão_de_cliente_30;
            this.btCadCli.Location = new System.Drawing.Point(10, 4);
            this.btCadCli.Name = "btCadCli";
            this.btCadCli.Size = new System.Drawing.Size(53, 34);
            this.btCadCli.TabIndex = 0;
            this.btCadCli.UseVisualStyleBackColor = true;
            this.btCadCli.Click += new System.EventHandler(this.btCadCli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestão de Venda de Veículos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadVenda;
        private System.Windows.Forms.Button btCadVeic;
        private System.Windows.Forms.Button btCadVen;
        private System.Windows.Forms.Button btCadCli;
    }
}

