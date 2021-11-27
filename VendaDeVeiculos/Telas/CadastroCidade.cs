using System;
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
    public partial class CadastroCidade : Form
    {

        private Cidade cidade;
        private bool adicionar = true;
        private CidadeService cs = new CidadeService();

        public CadastroCidade()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            cidade = new Cidade();
            cidade.CidId = cs.getIdNovaCidade();
            tbCodigo.Text = cidade.CidId.ToString();
            adicionar = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validaCidade())
            {
                return;
            }
            cidade.CidNome = tbNome.Text;
            cidade.CidPais = tbPais.Text;
            cidade.CidUf = tbUf.Text;
            if (adicionar)
            {
                cs.gravarCidade(cidade);
                adicionar = false;
            } else
            {
                cs.atualizarCidade(cidade);
            }
        }

        private void tbUf_Leave(object sender, EventArgs e)
        {
            tbUf.Text = tbUf.Text.Trim().ToUpper();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaCidade cc = new ConsultaCidade();
            cc.ShowDialog(this);
            adicionar = false;
        }

        public void getDadosPesquisa(Cidade cidade)
        {
            this.cidade = cidade;
            tbCodigo.Text = cidade.CidId.ToString();
            tbNome.Text = cidade.CidNome;
            tbPais.Text = cidade.CidPais;
            tbUf.Text = cidade.CidUf;
        }

        private void limparCampos()
        {
            cidade = null;
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbPais.Text = "";
            tbUf.Text = "";
        }

        private Boolean validaCidade()
        {
            if (this.cidade == null)
            {
                MessageBox.Show("Selecione um cliente válido.");
                return false;
            }
            if (tbNome.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"Nome\" é obrigatório.");
                return false;
            }
            if (tbPais.Text.Trim().Length < 1)
            {
                MessageBox.Show("O campo \"País\" é obrigatório.");
                return false;
            }
            return true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if(cidade == null || adicionar)
            {
                MessageBox.Show("Selecione uma cidade válido.");
                return;
            }
            cs.deletarCidade(cidade);
            limparCampos();
            cidade = null;
        }
    }
}
