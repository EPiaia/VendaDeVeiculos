using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaDeVeiculos.Model;
using VendaDeVeiculos.Service;

namespace VendaDeVeiculos.Telas
{
    public partial class RelatorioDeVendas : Form
    {

        private VendaService venService = new VendaService();
        private VendedorService vdrService = new VendedorService();
        private ClienteService cliService = new ClienteService();
        private VeiculoService vclService = new VeiculoService();

        public RelatorioDeVendas()
        {
            InitializeComponent();
            cbData.Checked = false;
            gbData.Visible = false;
        }

        private void RelatorioDeVendas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btPesqCli_Click(object sender, EventArgs e)
        {
            ConsultaCliente pesquisa = new ConsultaCliente();
            pesquisa.ShowDialog(this);
        }

        private void btPesqVdr_Click(object sender, EventArgs e)
        {
            ConsultaVendedor pesquisa = new ConsultaVendedor();
            pesquisa.ShowDialog(this);
        }

        private void btPesqVcl_Click(object sender, EventArgs e)
        {
            ConsultaVeiculo pesquisa = new ConsultaVeiculo();
            pesquisa.ShowDialog(this);
        }

        public void getDadosPesqCli(Cliente cliente)
        {
            tbCliId.Text = cliente.CliId.ToString();
            tbNomeCli.Text = cliente.CliNome;
        }

        public void getDadosPesqVdr(Vendedor vendedor)
        {
            tbVdrId.Text = vendedor.VdrId.ToString();
            tbNomeVdr.Text = vendedor.VdrNome;
        }

        public void getDadosPesqVcl(Veiculo veiculo)
        {
            tbVclId.Text = veiculo.VclId.ToString();
            tbNomeVcl.Text = veiculo.VclModelo;
        }

        private void tbVdrId_Leave(object sender, EventArgs e)
        {
            if (tbVdrId.Text.Trim().Length < 1)
            {
                tbNomeVdr.Text = "";
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("vdrId", tbVdrId.Text);
            ArrayList vendedoresSelecionados = vdrService.filtrarVendedores(filtros);
            if (vendedoresSelecionados.Count > 0)
            {
                Vendedor vendedor = (Vendedor)vendedoresSelecionados[0];
                tbNomeVdr.Text = vendedor.VdrNome;
            }
            else
            {
                MessageBox.Show("Vendedor com o código informado não encontrado.");
            }
        }

        private void tbCliId_Leave(object sender, EventArgs e)
        {
            if (tbCliId.Text.Trim().Length < 1)
            {
                tbNomeCli.Text = "";
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("cliId", tbCliId.Text);
            ArrayList clientesFiltrados = cliService.filtrarClientes(filtros);
            if (clientesFiltrados.Count > 0)
            {
                Cliente cliente = (Cliente)clientesFiltrados[0];
                tbNomeCli.Text = cliente.CliNome;
            }
            else
            {
                MessageBox.Show("Cliente com o código informado não encontrado.");
            }
        }

        private void tbVclId_Leave(object sender, EventArgs e)
        {
            if (tbVclId.Text.Trim().Length < 1)
            {
                tbNomeVcl.Text = "";
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("vclId", tbVclId.Text);
            ArrayList veiculosFiltrados = vclService.filtrarVeiculos(filtros);
            if (veiculosFiltrados.Count > 0)
            {
                Veiculo veiculo = (Veiculo)veiculosFiltrados[0];
                tbNomeVcl.Text = veiculo.VclModelo;
            }
            else
            {
                MessageBox.Show("Veículo com o código informado não encontrado.");
            }
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            gbData.Visible = cbData.Checked;
        }

        private void btnGerarRelat_Click(object sender, EventArgs e)
        {
            if (!validarCampos()){
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if(tbCliId.Text.Trim().Length > 0)
            {
                filtros.Add("venCliente", tbCliId.Text.Trim());
            }
            if (tbVdrId.Text.Trim().Length > 0)
            {
                filtros.Add("venVendedor", tbVdrId.Text.Trim());
            }
            if (tbVclId.Text.Trim().Length > 0)
            {
                filtros.Add("venVeiculo", tbVclId.Text.Trim());
            }
            if (cbData.Checked)
            {
                string data = dtpIni.Value.Year.ToString() + "-" + dtpIni.Value.Month + "-" + dtpIni.Value.Day;
                filtros.Add("venDataIni", data);
                data = dtpFim.Value.Year.ToString() + "-" + dtpFim.Value.Month + "-" + dtpFim.Value.Day;
                filtros.Add("venDataFim", data);
            }
            VendaBindingSource.DataSource = venService.filtrarVendas(filtros);
            this.reportViewer1.RefreshReport();
        }

        private Boolean validarCampos()
        {
            if (cbData.Checked && dtpIni.Value.Date > dtpFim.Value.Date)
            {
                MessageBox.Show("A data de início não pode ser maior do que a final.");
                dtpIni.Value = DateTime.Now;
                dtpFim.Value = DateTime.Now;
                return false;
            }
            return true;
        }
    }
}
