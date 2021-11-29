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
    public partial class CadastroVeiculo : Form
    {

        private Veiculo veiculo;
        private bool adicionar = true;
        private bool estadoVclBD;
        private VeiculoService vs = new VeiculoService();
        private VendaService venService = new VendaService();

        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            veiculo = new Veiculo();
            veiculo.VclId = vs.getIdNovoVeiculo();
            tbCodigo.Text = veiculo.VclId.ToString();
            adicionar = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validarVeiculo())
            {
                return;
            }
            veiculo.VclChassi = tbChassi.Text;
            veiculo.VclMotor = tbMotor.Text;
            veiculo.VclModelo = tbModelo.Text;
            veiculo.VclMarca = tbMarca.Text;
            veiculo.VclUsado = cbUsado.Checked;
            veiculo.VclVendido = cbVendido.Checked;
            veiculo.VclTipo = tbTipo.Text;
            veiculo.VclKm = Convert.ToDouble(nudKm.Value);
            veiculo.VclValor = Convert.ToDouble(nudValor.Value);
            veiculo.VclComplemento = rtbComplemento.Text;
            if (adicionar)
            {
                vs.gravarVeiculo(veiculo);
            } else
            {
                if (estaEmAlgumaVenda(veiculo) && veiculo.VclVendido != estadoVclBD)
                {
                    MessageBox.Show("O veículo está em uma venda, portanto não é permitido alterar seu estado.");
                    veiculo.VclVendido = estadoVclBD;
                    cbVendido.Checked = estadoVclBD;
                    return;
                }
                vs.atualizarVeiculo(veiculo);
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaVeiculo pesquisa = new ConsultaVeiculo();
            adicionar = false;
            pesquisa.ShowDialog(this);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            veiculo = null;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if(veiculo == null || adicionar)
            {
                MessageBox.Show("Selecione um veículo válido.");
                return;
            }
            if (estaEmAlgumaVenda(veiculo))
            {
                MessageBox.Show("O veículo não pode ser deletado porque está em uma venda.");
                return;
            }
            vs.deletarVeiculo(veiculo);
            limparCampos();
            this.veiculo = null;
        }

        public void getDadosPesquisa(Veiculo veiculo)
        {
            this.veiculo = veiculo;
            tbCodigo.Text = veiculo.VclId.ToString();
            tbChassi.Text = veiculo.VclChassi;
            tbMotor.Text = veiculo.VclMotor;
            tbModelo.Text = veiculo.VclModelo;
            tbMarca.Text = veiculo.VclMarca;
            cbUsado.Checked = veiculo.VclUsado;
            cbVendido.Checked = veiculo.VclVendido;
            tbTipo.Text = veiculo.VclTipo;
            nudKm.Value = Convert.ToDecimal(veiculo.VclKm);
            nudValor.Value = Convert.ToDecimal(veiculo.VclValor);
            rtbComplemento.Text = veiculo.VclComplemento;
            estadoVclBD = veiculo.VclVendido;
        }

        private void limparCampos()
        {
            tbCodigo.Text = "";
            tbChassi.Text = "";
            tbMotor.Text = "";
            tbModelo.Text = "";
            tbMarca.Text = "";
            cbUsado.Checked = false;
            cbVendido.Checked = false;
            tbTipo.Text = "";
            nudKm.Value = 0;
            nudValor.Value = 0;
            rtbComplemento.Text = "";
        }

        private Boolean validarVeiculo()
        {
            if(veiculo == null)
            {
                MessageBox.Show("Selecione um veículo válido.");
                return false;
            }
            if(tbModelo.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Modelo/Ano\" é obrigatório.");
                return false;
            }
            if(tbMarca.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Marca\" é obrigatório.");
                return false;
            }
            if (tbTipo.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Tipo\" é obrigatório.");
                return false;
            }
            if (nudValor.Value == 0)
            {
                MessageBox.Show("O Valor deve ser superior a R$ 0,00.");
                return false;
            }
            return true;
        }

        private Boolean estaEmAlgumaVenda(Veiculo veiculo)
        {
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("venVeiculo", veiculo.VclId.ToString());
            ArrayList fVendas = venService.filtrarVendas(filtros);
            return fVendas.Count > 0;
        }

    }
}
