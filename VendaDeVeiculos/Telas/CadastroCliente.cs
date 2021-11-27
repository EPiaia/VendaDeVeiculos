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
    public partial class CadastroCliente : Form
    {

        private Cliente cliente;
        private bool adicionar = false;
        private ClienteService cs = new ClienteService();
        private CidadeService cidServ = new CidadeService();

        public CadastroCliente()
        {
            InitializeComponent();
            tipoFisica.Checked = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            int? codigoCli = cs.getIdNovoCliente();
            cliente.CliId = codigoCli;
            tbCodigo.Text = codigoCli.ToString();
            adicionar = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validaCliente())
            {
                return;
            }
            cliente.CliId = Convert.ToInt32(tbCodigo.Text);
            cliente.CliNome = tbNome.Text;
            string cpfCnpj = mtbCpfCnpj.Text;
            cpfCnpj = cpfCnpj.Replace(",", "");
            cpfCnpj = cpfCnpj.Replace(".", "");
            cpfCnpj = cpfCnpj.Replace("-", "");
            cpfCnpj = cpfCnpj.Replace("/", "");
            cliente.CliCpfCnpj = cpfCnpj;
            // cliente.CliCidade = Convert.ToInt32(tbCidade.Text)
            cliente.CliBairro = tbBairro.Text;
            cliente.CliLogradouro = tbLogradouro.Text;
            cliente.CliNum = Convert.ToInt32(mtbNum.Text);
            cliente.CliCompl = tbCompl.Text;
            cliente.CliEmail = tbEmail.Text;
            string fone = mtbFone.Text;
            fone = fone.Replace("(", "");
            fone = fone.Replace(")", "");
            fone = fone.Replace("-", "");
            cliente.CliFone = fone;
            cliente.CliNascimento = dtpNasc.Value.Date;
            if (adicionar)
            {
                cs.gravarCliente(cliente);
                adicionar = false;
            } else
            {
                cs.atualizarCliente(cliente);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Text = "";
            mtbCpfCnpj.Mask = "999.999.999-99";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Text = "";
            mtbCpfCnpj.Mask = "99.999.999/9999-99";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaCliente pesquisa = new ConsultaCliente();
            adicionar = false;
            pesquisa.ShowDialog(this);
        }

        public void getDadosPesquisa(Cliente clientePesquisado)
        {
            cliente = clientePesquisado;
            tbCodigo.Text = cliente.CliId.ToString();
            tbNome.Text = cliente.CliNome.ToString();
            if(cliente.CliCpfCnpj.Length > 11)
            {
                tipoJuridica.Checked = true;
            } else
            {
                tipoFisica.Checked = true;
            }
            mtbCpfCnpj.Text = cliente.CliCpfCnpj.ToString();
            tbEmail.Text = cliente.CliEmail.ToString();
            mtbFone.Text = cliente.CliFone.ToString();
            dtpNasc.Value = cliente.CliNascimento;
            tbBairro.Text = cliente.CliBairro.ToString();
            tbLogradouro.Text = cliente.CliLogradouro.ToString();
            mtbNum.Text = cliente.CliNum.ToString();
            tbCompl.Text = cliente.CliCompl.ToString();
            tbCidade.Text = cliente.CliCidade.CidId.ToString();
            tbNomeCidade.Text = cliente.CliCidade.CidNome;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (cliente.Equals(null) || adicionar)
            {
                MessageBox.Show("Selecione um cliente válido.");
                return;
            }
            cs.deletarCliente(cliente);
            limparCampos();
            this.cliente = null;
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void tbCidade_Leave(object sender, EventArgs e)
        {
            if(cliente == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }
            if(tbCidade.Text.Trim().Length > 0) {
                Dictionary<string, string> filtrosCid = new Dictionary<string, string>();
                filtrosCid.Add("cidId", tbCidade.Text.Trim());
                ArrayList cidades = cidServ.filtrarCidades(filtrosCid);
                if (cidades != null && cidades.Count > 0)
                {
                    cliente.CliCidade = (Cidade)cidades[0];
                    tbNomeCidade.Text = this.cliente.CliCidade.CidNome;
                } else
                {
                    cliente.CliCidade = null;
                    tbNomeCidade.Text = "";
                    tbCidade.Text = "";
                    MessageBox.Show("Nenhuma cidade encontrada com o código informado.");
                    return;
                }
            } else
            {
                cliente.CliCidade = null;
                tbNomeCidade.Text = "";
                tbCidade.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaCidade pesquisaCidade = new ConsultaCidade();
            pesquisaCidade.ShowDialog(this);
        }

        public void getCidadePesquisa(Cidade cidade)
        {
            this.cliente.CliCidade = cidade;
            tbCidade.Text = this.cliente.CliCidade.CidId.ToString();
            tbNomeCidade.Text = this.cliente.CliCidade.CidNome;
        }
        private void limparCampos()
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            mtbCpfCnpj.Text = "";
            tbEmail.Text = "";
            mtbFone.Text = "";
            dtpNasc.Value = DateTime.Now;
            tbBairro.Text = "";
            tbLogradouro.Text = "";
            mtbNum.Text = "";
            tbCompl.Text = "";
            tbCidade.Text = "";
            tbNomeCidade.Text = "";
            cliente = new Cliente();
        }

        public Boolean validaCliente()
        {
            if (cliente == null)
            {
                MessageBox.Show("Selecione um cliente válido.");
                return false;
            }
            if (tbNome.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo ''Nome Completo'' é obrigatório.");
                return false;
            }
            string cpfCnpj = mtbCpfCnpj.Text.Trim();
            cpfCnpj = cpfCnpj.Replace(".", "");
            cpfCnpj = cpfCnpj.Replace("-", "");
            cpfCnpj = cpfCnpj.Replace("/", "");
            cpfCnpj = cpfCnpj.Replace(",", "");
            if (cpfCnpj.Length != 11 || cpfCnpj.Length != 11)
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
                MessageBox.Show("O campo ''Telefone'' é obrigatório.");
                return false;
            }
            if (naoPossui18Anos(dtpNasc.Value))
            {
                MessageBox.Show("O cliente deve ter no mínimo 18 anos.");
                return false;
            }
            if (this.cliente.CliCidade == null)
            {
                MessageBox.Show("Insira uma cidade válida.");
                return false;
            }
            if (tbBairro.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo ''Bairro'' é obrigatório.");
                return false;
            }
            if (tbLogradouro.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo ''Logradouro'' é obrigatório.");
                return false;
            }
            if (mtbNum.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo ''Número'' é obrigatório.");
                return false;
            }
            return true;
        }

        public Boolean naoPossui18Anos(DateTime data)
        {
            return DateTime.Today.Year - data.Year < 18;
        }
    }
}
