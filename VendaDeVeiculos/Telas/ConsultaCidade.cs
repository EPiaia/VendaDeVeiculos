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
    public partial class ConsultaCidade : Form
    {

        private CidadeService cs = new CidadeService();

        public ConsultaCidade()
        {
            InitializeComponent();
        }

        private void ConsultaCidade_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Trim().Length < 1 && tbNome.Text.Trim().Length < 1
                && tbPais.Text.Trim().Length < 1 && mtbUF.Text.Trim().Length < 1)
            {
                MessageBox.Show("Preencha ao menos um dos campos.");
                return;
            }

            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if (tbCodigo.Text.Trim().Length > 0)
            {
                filtros.Add("cidId", tbCodigo.Text);
            }
            else
            {
                if (tbNome.Text.Trim().Length > 0)
                {
                    filtros.Add("cidNome", tbNome.Text);
                }
                if (tbPais.Text.Trim().Length > 0)
                {
                    filtros.Add("cidPais", tbPais.Text);
                }
                if (mtbUF.Text.Trim().Length > 0)
                {
                    filtros.Add("cidUf", mtbUF.Text);
                }
                dgCidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgCidades.AutoGenerateColumns = false;
                dgCidades.DataSource = cs.filtrarCidades(filtros);

            }
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            dgCidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCidades.AutoGenerateColumns = false;
            dgCidades.DataSource = cs.pesquisarTodasCidades();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbPais.Text = "";
            mtbUF.Text = "";
            dgCidades.DataSource = new ArrayList();
        }

        private void dgCidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCidades.SelectedRows.Count > 1)
            {
                // Aviso
                return;
            }

            foreach (DataGridViewRow row in dgCidades.SelectedRows)
            {
                Cidade cidadeSelecionada = (Cidade)row.DataBoundItem;
                if (this.Owner != null)
                {
                    if (typeof(CadastroCliente).IsInstanceOfType(this.Owner))
                    {
                        CadastroCliente cadastro = (CadastroCliente)this.Owner;
                        cadastro.getCidadePesquisa(cidadeSelecionada);
                    } else if (typeof(CadastroCidade).IsInstanceOfType(this.Owner))
                    {

                    }
                }
            }
            this.Close();
        }
    }
}
