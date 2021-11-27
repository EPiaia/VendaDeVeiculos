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
            CadastroCliente formCC = new CadastroCliente();
            formCC.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCidade formCC = new CadastroCidade();
            formCC.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente formCC = new CadastroCliente();
            formCC.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendedor formCV = new CadastroVendedor();
            formCV.Show();
        }

        private void btCadVen_Click(object sender, EventArgs e)
        {
            CadastroVendedor formCV = new CadastroVendedor();
            formCV.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeiculo formCV = new CadastroVeiculo();
            formCV.Show();
        }

        private void btCadVeic_Click(object sender, EventArgs e)
        {
            CadastroVeiculo formCV = new CadastroVeiculo();
            formCV.Show();
        }
    }
}
