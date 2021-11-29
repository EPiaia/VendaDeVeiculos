using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaDeVeiculos.Telas;

namespace VendaDeVeiculos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCidade cc = new CadastroCidade();
            cc.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendedor cv = new CadastroVendedor();
            cv.Show();
        }

        private void btCadVen_Click(object sender, EventArgs e)
        {
            CadastroVendedor cv = new CadastroVendedor();
            cv.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeiculo cv = new CadastroVeiculo();
            cv.Show();
        }

        private void btCadVeic_Click(object sender, EventArgs e)
        {
            CadastroVeiculo cv = new CadastroVeiculo();
            cv.Show();
        }

        private void btCadVenda_Click(object sender, EventArgs e)
        {
            CadastroVenda cv = new CadastroVenda();
            cv.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioDeClientes rc = new RelatorioDeClientes();
            rc.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioDeVendedores rv = new RelatorioDeVendedores();
            rv.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioDeVeiculos rv = new RelatorioDeVeiculos();
            rv.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioDeVendas rv = new RelatorioDeVendas();
            rv.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVenda cv = new CadastroVenda();
            cv.Show();
        }
    }
}
