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
    public partial class ConsultaVenda : Form
    {

        private ClienteService cliService = new ClienteService();
        private VendedorService vdrService = new VendedorService();
        private VeiculoService vclService = new VeiculoService();
        private VendaService venService = new VendaService();

        public ConsultaVenda()
        {
            InitializeComponent();
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if(tbCodigo.Text.Trim().Length > 1)
            {
                filtros.Add("venId", tbCodigo.Text);
            } else
            {
                if(tbCliId.Text.Trim().Length > 1)
                {
                    filtros.Add("venCli", tbCliId.Text);
                }
                if (tbVdrId.Text.Trim().Length > 1)
                {
                    filtros.Add("venVdr", tbVdrId.Text);
                }
                if (tbVclId.Text.Trim().Length > 1)
                {
                    filtros.Add("venVcl", tbVclId.Text);
                }
                if (nudValor.Value > 0)
                {
                    filtros.Add("venTotal", nudValor.Value.ToString());
                }
                if (dtpDataIni.Value.Date.Equals(dtpDataAte.Value.Date))
                {
                    string data = dtpDataIni.Value.Year.ToString() + "-" + dtpDataIni.Value.Month + "-" + dtpDataIni.Value.Day;
                    filtros.Add("venDataIni", data);
                } else
                {
                    string data = dtpDataIni.Value.Year.ToString() + "-" + dtpDataIni.Value.Month + "-" + dtpDataIni.Value.Day;
                    filtros.Add("venDataIni", data);
                    data = dtpDataAte.Value.Year.ToString() + "-" + dtpDataAte.Value.Month + "-" + dtpDataAte.Value.Day;
                    filtros.Add("venDataFim", data);
                }
            }
            dgVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendas.AutoGenerateColumns = false;
            dgVendas.DataSource = venService.filtrarVendas(filtros);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbCliId.Text = "";
            tbNomeCli.Text = "";
            tbVdrId.Text = "";
            tbNomeVdr.Text = "";
            tbVclId.Text = "";
            tbNomeVcl.Text = "";
            nudValor.Value = 0;
            dtpDataIni.Value = DateTime.Now;
            dtpDataAte.Value = DateTime.Now;
            dgVendas.DataSource = new ArrayList();
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            dgVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendas.AutoGenerateColumns = false;
            dgVendas.DataSource = venService.pesquisarTodasVendas();
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
                Veiculo veiculo = (Veiculo) veiculosFiltrados[0];
                tbNomeVcl.Text = veiculo.VclModelo;
            }
            else
            {
                MessageBox.Show("Veículo com o código informado não encontrado.");
            }
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

        private void dgVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVendas.SelectedRows.Count > 1)
            {
                // Aviso
                return;
            }

            foreach (DataGridViewRow row in dgVendas.SelectedRows)
            {
                Venda vendaSelecionada = (Venda)row.DataBoundItem;
                if (this.Owner != null)
                {
                    CadastroVenda cadastro = (CadastroVenda)this.Owner;
                    cadastro.getDadosPesqVenda(vendaSelecionada);
                }
            }
            this.Close();
        }

        private void dtpDataIni_Leave(object sender, EventArgs e)
        {
            if(dtpDataIni.Value.Date > dtpDataAte.Value.Date)
            {
                MessageBox.Show("A data de início não pode ser menor do que a final.");
                dtpDataIni.Value = DateTime.Now;
                dtpDataAte.Value = DateTime.Now;
            }
        }

        private void dtpDataAte_Leave(object sender, EventArgs e)
        {
            if (dtpDataIni.Value.Date > dtpDataAte.Value.Date)
            {
                MessageBox.Show("A data de início não pode ser maior do que a final.");
                dtpDataIni.Value = DateTime.Now;
                dtpDataAte.Value = DateTime.Now;
            }
        }
    }
}
