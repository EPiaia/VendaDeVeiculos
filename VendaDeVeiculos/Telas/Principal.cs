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
        // Telas de cadastro
        private CadastroCidade cadastroCidade = new CadastroCidade();
        private CadastroCliente cadastroCliente = new CadastroCliente();
        private CadastroVendedor cadastroVendedor = new CadastroVendedor();
        private CadastroVeiculo cadastroVeiculo = new CadastroVeiculo();
        private CadastroVenda cadastroVenda = new CadastroVenda();
        // Telas de geração de relatório
        private RelatorioDeClientes relatorioCliente = new RelatorioDeClientes();
        private RelatorioDeVendedores relatorioVendedor = new RelatorioDeVendedores();
        private RelatorioDeVeiculos relatorioVeiculo = new RelatorioDeVeiculos();
        private RelatorioDeVendas relatorioVenda = new RelatorioDeVendas();


        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cadastroCliente.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCidade.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btCadCli_Click(object sender, EventArgs e)
        {
            cadastroCliente.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroVendedor.Show();
        }

        private void btCadVen_Click(object sender, EventArgs e)
        {
            cadastroVendedor.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroVeiculo.Show();
        }

        private void btCadVeic_Click(object sender, EventArgs e)
        {
            cadastroVeiculo.Show();
        }

        private void btCadVenda_Click(object sender, EventArgs e)
        {
            cadastroVenda.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioCliente.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioVendedor.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioVeiculo.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioVenda.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
