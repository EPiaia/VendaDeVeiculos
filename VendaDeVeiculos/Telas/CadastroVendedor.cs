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
    public partial class CadastroVendedor : Form
    {

        private bool adicionar = true;
        private Vendedor vendedor;
        private VendedorService vs = new VendedorService();
        private CidadeService cs = new CidadeService();
        private VendaService venS = new VendaService();

        public CadastroVendedor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            adicionar = true;
            vendedor = new Vendedor();
            vendedor.VdrId = vs.getIdNovoVendedor();
            tbCodigo.Text = vendedor.VdrId.ToString();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validaVendedor())
            {
                return;
            }
            vendedor.VdrId = Convert.ToInt32(tbCodigo.Text);
            vendedor.VdrNome = tbNome.Text;
            string cpfCnpj = mtbCpf.Text;
            cpfCnpj = cpfCnpj.Replace(",", "");
            cpfCnpj = cpfCnpj.Replace(".", "");
            cpfCnpj = cpfCnpj.Replace("-", "");
            cpfCnpj = cpfCnpj.Replace("/", "");
            vendedor.VdrCpf = cpfCnpj;
            // vendedor.VdrCidade = Convert.ToInt32(tbCidade.Text)
            vendedor.VdrBairro = tbBairro.Text;
            vendedor.VdrLogradouro = tbLogradouro.Text;
            vendedor.VdrNum = Convert.ToInt32(mtbNum.Text);
            vendedor.VdrCompl = tbCompl.Text;
            vendedor.VdrEmail = tbEmail.Text;
            string fone = mtbFone.Text;
            fone = fone.Replace("(", "");
            fone = fone.Replace(")", "");
            fone = fone.Replace("-", "");
            vendedor.VdrFone = fone;
            vendedor.VdrNascimento = dtpNasc.Value.Date;
            if (adicionar)
            {
                vs.gravarVendedor(vendedor);
                adicionar = false;
            }
            else
            {
                vs.atualizarVendedor(vendedor);
            }
        }

        private void tbCidade_Leave(object sender, EventArgs e)
        {
            if (vendedor == null)
            {
                MessageBox.Show("Selecione um vendedor.");
                return;
            }
            if (tbCidade.Text.Trim().Length > 0)
            {
                Dictionary<string, string> filtrosCid = new Dictionary<string, string>();
                filtrosCid.Add("cidId", tbCidade.Text.Trim());
                ArrayList cidades = cs.filtrarCidades(filtrosCid);
                if (cidades != null && cidades.Count > 0)
                {
                    vendedor.VdrCidade = (Cidade)cidades[0];
                    tbNomeCidade.Text = this.vendedor.VdrCidade.CidNome;
                }
                else
                {
                    vendedor.VdrCidade = null;
                    tbNomeCidade.Text = "";
                    tbCidade.Text = "";
                    MessageBox.Show("Nenhuma cidade encontrada com o código informado.");
                    return;
                }
            }
            else
            {
                vendedor.VdrCidade = null;
                tbNomeCidade.Text = "";
                tbCidade.Text = "";
            }
        }

        private bool validaVendedor()
        {
            if(vendedor == null)
            {
                MessageBox.Show("Selecione um vendedor válido.");
                return false;
            }
            if (tbNome.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Nome Completo\" é obrigatório.");
                return false;
            }
            string cpf = mtbCpf.Text.Trim();
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            cpf = cpf.Replace(",", "");
            if (cpf.Length != 11)
            {
                MessageBox.Show("Insira um CPF/CNPJ válido.");
                return false;
            }
            string telefone = mtbFone.Text;
            telefone = telefone.Replace("(", "");
            telefone = telefone.Replace(")", "");
            telefone = telefone.Replace("-", "").Trim();
            if (telefone.Length < 1)
            {
                MessageBox.Show("O campo \"Telefone\" é obrigatório.");
                return false;
            }
            if (naoPossui16Anos(dtpNasc.Value))
            {
                MessageBox.Show("O vendedor deve ter no mínimo 16 anos.");
                return false;
            }
            if (this.vendedor.VdrCidade == null)
            {
                MessageBox.Show("Insira uma cidade válida.");
                return false;
            }
            if (tbBairro.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Bairro\" é obrigatório.");
                return false;
            }
            if (tbLogradouro.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Logradouro\" é obrigatório.");
                return false;
            }
            if (mtbNum.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Número\" é obrigatório.");
                return false;
            }
            return true;
        }

        private Boolean naoPossui16Anos(DateTime data)
        {
            return DateTime.Today.Year - data.Year < 16;
        }

        private void btPesquisaCidade_Click(object sender, EventArgs e)
        {
            ConsultaCidade pesquisaCidade = new ConsultaCidade();
            pesquisaCidade.ShowDialog(this);
        }

        public void getCidadePesquisa(Cidade cidade)
        {
            this.vendedor.VdrCidade = cidade;
            tbCidade.Text = this.vendedor.VdrCidade.CidId.ToString();
            tbNomeCidade.Text = this.vendedor.VdrCidade.CidNome;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            vendedor = null;
            limparCampos();
        }
        private void limparCampos()
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            mtbCpf.Text = "";
            tbEmail.Text = "";
            mtbFone.Text = "";
            dtpNasc.Value = DateTime.Now;
            tbBairro.Text = "";
            tbLogradouro.Text = "";
            mtbNum.Text = "";
            tbCompl.Text = "";
            tbCidade.Text = "";
            tbNomeCidade.Text = "";
            vendedor = null;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaVendedor pesquisa = new ConsultaVendedor();
            adicionar = false;
            pesquisa.ShowDialog(this);
        }

        public void getDadosPesquisa(Vendedor vendedor)
        {
            this.vendedor = vendedor;
            tbCodigo.Text = vendedor.VdrId.ToString();
            tbNome.Text = vendedor.VdrNome.ToString();
            mtbCpf.Text = vendedor.VdrCpf.ToString();
            tbEmail.Text = vendedor.VdrEmail.ToString();
            mtbFone.Text = vendedor.VdrFone.ToString();
            dtpNasc.Value = vendedor.VdrNascimento;
            tbBairro.Text = vendedor.VdrBairro.ToString();
            tbLogradouro.Text = vendedor.VdrLogradouro.ToString();
            mtbNum.Text = vendedor.VdrNum.ToString();
            tbCompl.Text = vendedor.VdrCompl.ToString();
            tbCidade.Text = vendedor.VdrCidade.CidId.ToString();
            tbNomeCidade.Text = vendedor.VdrCidade.CidNome;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (vendedor == null || adicionar)
            {
                MessageBox.Show("Selecione um vendedor válido.");
                return;
            }
            if (estaEmAlgumaVenda(vendedor))
            {
                MessageBox.Show("O vendedor não pode ser deletado porque está em uma venda.");
                return;
            }
            vs.deletarVendedor(vendedor);
            limparCampos();
            this.vendedor = null;
        }

        private Boolean estaEmAlgumaVenda(Vendedor vendedor)
        {
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("venVendedor", vendedor.VdrId.ToString());
            ArrayList fVendas = venS.filtrarVendas(filtros);
            return fVendas.Count > 0;
        }
    }
}
