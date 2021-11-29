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
    public partial class CadastroVenda : Form
    {

        private Venda venda;
        private VendaService venService = new VendaService();
        private ClienteService cliService = new ClienteService();
        private VendedorService vdrService = new VendedorService();
        private VeiculoService vclService = new VeiculoService();
        private bool adicionar = true;

        public CadastroVenda()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            venda = new Venda();
            venda.VenId = venService.getIdNovaVenda();
            tbCodigo.Text = venda.VenId.ToString();
            adicionar = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            venda.VenData = dtpData.Value;
            venda.VenAdicionais = Convert.ToDouble(nudAdd.Value);
            venda.VenDescontos = Convert.ToDouble(nudDesc.Value);
            venda.VenTributos = Convert.ToDouble(nudTrib.Value);
            venda.VenPagamento = tbPagamento.Text;
            venda.VenTotal = calcularTotalVenda();
            if (adicionar)
            {
                venService.gravarVenda(venda);
                venda.VenVeiculo.VclVendido = true;
                vclService.atualizarVeiculo(venda.VenVeiculo);
            } else
            {
                venService.atualizarVenda(venda);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaVenda pesquisa = new ConsultaVenda();
            pesquisa.ShowDialog(this);
            adicionar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            venda = null;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(venda == null || adicionar)
            {
                MessageBox.Show("Selecione uma venda válido.");
                return;
            }
            venService.deletarVenda(venda);
            venda.VenVeiculo.VclVendido = false;
            vclService.atualizarVeiculo(venda.VenVeiculo);
            limparCampos();
        }

        private void btPesqCli_Click(object sender, EventArgs e)
        {
            if (venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
            ConsultaCliente pesquisa = new ConsultaCliente();
            pesquisa.ShowDialog(this);
        }

        private void btPesqVdr_Click(object sender, EventArgs e)
        {
            if (venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
            ConsultaVendedor pesquisa = new ConsultaVendedor();
            pesquisa.ShowDialog(this);
        }

        private void btPesqVcl_Click(object sender, EventArgs e)
        {
            if(venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
            ConsultaVeiculo pesquisa = new ConsultaVeiculo();
            pesquisa.ShowDialog(this);
        }

        private void tbCliId_Leave(object sender, EventArgs e)
        {
            if (venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
            if(tbCliId.Text.Trim().Length < 1)
            {
                tbNomeCli.Text = "";
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("cliId", tbCliId.Text);
            ArrayList clientesFiltrados = cliService.filtrarClientes(filtros);
            if (clientesFiltrados.Count > 0)
            {
                venda.VenCliente = (Cliente) clientesFiltrados[0];
                tbNomeCli.Text = venda.VenCliente.CliNome;
            } else
            {
                MessageBox.Show("Cliente com o código informado não encontrado.");
            }
        }

        private void tbVdrId_Leave(object sender, EventArgs e)
        {
            if (venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
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
                venda.VenVendedor = (Vendedor) vendedoresSelecionados[0];
                tbNomeVdr.Text = venda.VenVendedor.VdrNome;
            }
            else
            {
                MessageBox.Show("Vendedor com o código informado não encontrado.");
            }
        }

        private void tbVclId_Leave(object sender, EventArgs e)
        {
            if (venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return;
            }
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
                if (veiculo.VclVendido)
                {
                    MessageBox.Show("O veículo com o código informado já foi vendido.");
                    tbVclId.Text = "";
                    return;
                }
                venda.VenVeiculo = veiculo;
                tbNomeVcl.Text = venda.VenVeiculo.VclModelo;
                venda.VenTotal = calcularTotalVenda();
                tbVlrTotal.Text = "R$ " + calcularTotalVenda().ToString();
            }
            else
            {
                MessageBox.Show("Veículo com o código informado não encontrado.");
            }
        }

        private void nudAdd_Leave(object sender, EventArgs e)
        {
            venda.VenTotal = calcularTotalVenda();
            tbVlrTotal.Text = "R$ " + calcularTotalVenda().ToString();
        }

        private void nudDesc_Leave(object sender, EventArgs e)
        {
            venda.VenTotal = calcularTotalVenda();
            tbVlrTotal.Text = "R$ " + calcularTotalVenda().ToString();
        }

        private void nudTrib_Leave(object sender, EventArgs e)
        {
            venda.VenTotal = calcularTotalVenda();
            tbVlrTotal.Text = "R$ " + calcularTotalVenda().ToString();
        }

        public void getDadosPesqCliente(Cliente cliente)
        {
            this.venda.VenCliente = cliente;
            tbCliId.Text = cliente.CliId.ToString();
            tbNomeCli.Text = cliente.CliNome;
        }

        public void getDadosPesqVendedor(Vendedor vendedor)
        {
            this.venda.VenVendedor = vendedor;
            tbVdrId.Text = vendedor.VdrId.ToString();
            tbNomeVdr.Text = vendedor.VdrNome;
        }

        public void getDadosPesqVeiculo(Veiculo veiculo)
        {
            this.venda.VenVeiculo = veiculo;
            tbVclId.Text = veiculo.VclId.ToString();
            tbNomeVcl.Text = veiculo.VclModelo;
            venda.VenTotal = calcularTotalVenda();
            tbVlrTotal.Text = "R$ " + calcularTotalVenda().ToString();
        }

        public void getDadosPesqVenda(Venda venda)
        {
            this.venda = venda;
            tbCodigo.Text = venda.VenId.ToString();
            tbCliId.Text = venda.VenCliente.CliId.ToString();
            tbNomeCli.Text = venda.VenCliente.CliNome;
            tbVdrId.Text = venda.VenVendedor.VdrId.ToString();
            tbNomeVdr.Text = venda.VenVendedor.VdrNome;
            tbVclId.Text = venda.VenVeiculo.VclId.ToString();
            tbNomeVcl.Text = venda.VenVeiculo.VclModelo;
            dtpData.Value = venda.VenData;
            nudAdd.Value = Convert.ToDecimal(venda.VenAdicionais);
            nudDesc.Value = Convert.ToDecimal(venda.VenDescontos);
            nudTrib.Value = Convert.ToDecimal(venda.VenTributos);
            tbPagamento.Text = venda.VenPagamento;
            tbVlrTotal.Text = "R$ " + venda.VenTotal;
        }

        private double calcularTotalVenda()
        {
            if(venda.VenVeiculo == null)
            {
                return 0;
            }
            double vlrVeiculo = (double)venda.VenVeiculo.VclValor;
            double vlrAdd = Convert.ToDouble(nudAdd.Value);
            double vlrDesc = Convert.ToDouble(nudDesc.Value);
            double vlrTrib = Convert.ToDouble(nudTrib.Value);

            return (vlrVeiculo + vlrAdd) - vlrDesc + vlrTrib;
        }

        private void limparCampos()
        {
            venda = null;
            tbCodigo.Text = "";
            tbCliId.Text = "";
            tbNomeCli.Text = "";
            tbVdrId.Text = "";
            tbNomeVdr.Text = "";
            tbVclId.Text = "";
            tbNomeVcl.Text = "";
            dtpData.Value = DateTime.Now;
            nudAdd.Value = 0;
            nudDesc.Value = 0;
            nudTrib.Value = 0;
            tbPagamento.Text = "";
            tbVlrTotal.Text = "R$ 00,00";
        }

        private Boolean validarCampos()
        {
            if(venda == null)
            {
                MessageBox.Show("Selecione uma venda válida.");
                return false;
            }
            if(venda.VenCliente == null)
            {
                MessageBox.Show("Selecione um cliente válido.");
                return false;
            }
            if (venda.VenVendedor == null)
            {
                MessageBox.Show("Selecione um vendedor válido.");
                return false;
            }
            if (venda.VenVeiculo == null)
            {
                MessageBox.Show("Selecione um veículo válido.");
                return false;
            }
            if (tbPagamento.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Condição de Pagamento\" é obrigatório.");
                return false;
            }
            return true;
        }
    }
}
