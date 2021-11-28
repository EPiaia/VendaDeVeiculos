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
    public partial class ConsultaVeiculo : Form
    {

        VeiculoService vs = new VeiculoService();

        public ConsultaVeiculo()
        {
            InitializeComponent();
            cbUsado.SelectedIndex = 0;
            cbVendido.SelectedIndex = 0;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (camposNaoPreenchidos())
            {
                MessageBox.Show("Preencha ao menos um dos campos.");
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if(tbCodigo.Text.Trim().Length > 0)
            {
                filtros.Add("vclId", tbCodigo.Text.Trim());
            }else
            {
                if(tbModelo.Text.Trim().Length > 0)
                {
                    filtros.Add("vclModelo", tbModelo.Text.Trim());
                }
                if (tbMarca.Text.Trim().Length > 0)
                {
                    filtros.Add("vclMarca", tbMarca.Text.Trim());
                }
                if (tbTipo.Text.Trim().Length > 0)
                {
                    filtros.Add("vclTipo", tbTipo.Text.Trim());
                }
                if (cbUsado.SelectedIndex != 0)
                {
                    if(cbUsado.SelectedIndex == 1)
                    {
                        filtros.Add("vclUsado", "1");
                    } else
                    {
                        filtros.Add("vclUsado", "0");
                    }
                }
                if (cbVendido.SelectedIndex != 0)
                {
                    if (cbVendido.SelectedIndex == 1)
                    {
                        filtros.Add("vclVendido", "1");
                    }
                    else
                    {
                        filtros.Add("vclVendido", "0");
                    }
                }
                if (nudKm.Value > 0)
                {
                    filtros.Add("vclKm", nudKm.Value.ToString());
                }
                if (nudValor.Value > 0)
                {
                    filtros.Add("vclValor", nudValor.Value.ToString());
                }
            }
            dgVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVeiculos.AutoGenerateColumns = false;
            dgVeiculos.DataSource = vs.filtrarVeiculos(filtros);
        }

        private Boolean camposNaoPreenchidos()
        {
            return (tbCodigo.Text.Trim().Length < 1 && tbModelo.Text.Trim().Length < 1
                && tbMarca.Text.Trim().Length < 1 && cbUsado.SelectedIndex == 0
                && cbVendido.SelectedIndex == 0 && nudKm.Value == 0 && nudValor.Value == 0) ;
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            dgVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVeiculos.AutoGenerateColumns = false;
            dgVeiculos.DataSource = vs.pesquisarTodosVeiculos();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbModelo.Text = "";
            tbMarca.Text = "";
            cbUsado.SelectedIndex = 0;
            cbVendido.SelectedIndex = 0;
            nudKm.Value = 0;
            nudValor.Value = 0;
            dgVeiculos.DataSource = new ArrayList();
        }

        private void dgVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVeiculos.SelectedRows.Count > 1)
            {
                return;
            }

            foreach (DataGridViewRow row in dgVeiculos.SelectedRows)
            {
                Veiculo veiculoSelecionado = (Veiculo)row.DataBoundItem;
                if (this.Owner != null)
                {
                    if (typeof(CadastroVeiculo).IsInstanceOfType(this.Owner))
                    {
                        CadastroVeiculo cadastro = (CadastroVeiculo)this.Owner;
                        cadastro.getDadosPesquisa(veiculoSelecionado);
                    } else if (typeof(CadastroVenda).IsInstanceOfType(this.Owner))
                    {
                        CadastroVenda cadastro = (CadastroVenda)this.Owner;
                        cadastro.getDadosPesqVeiculo(veiculoSelecionado);
                    }
                    else if (typeof(ConsultaVenda).IsInstanceOfType(this.Owner))
                    {
                        ConsultaVenda cadastro = (ConsultaVenda)this.Owner;
                        cadastro.getDadosPesqVcl(veiculoSelecionado);
                    }
                }
            }
            this.Close();
        }
    }
}
