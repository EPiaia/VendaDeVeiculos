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
    public partial class ConsultaVendedor : Form
    {

        private VendedorService vs = new VendedorService();

        public ConsultaVendedor()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Trim().Length == 0 && tbNome.Text.Trim().Length == 0 && tbCpf.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha ao menos um dos campos.");
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if (tbCodigo.Text.Trim().Length > 0)
            {
                filtros.Add("vdrId", tbCodigo.Text);
            }
            else
            {
                if (tbNome.Text.Trim().Length > 0)
                {
                    filtros.Add("vdrNome", tbNome.Text);
                }
                if (tbCpf.Text.Trim().Length > 0)
                {
                    filtros.Add("vdrCpf", tbCpf.Text);
                }
            }

            dgVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendedores.AutoGenerateColumns = false;
            dgVendedores.DataSource = vs.filtrarVendedores(filtros);
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            dgVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendedores.AutoGenerateColumns = false;
            dgVendedores.DataSource = vs.pesquisarTodosVendedores();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbCpf.Text = "";
            dgVendedores.DataSource = new ArrayList();
        }

        private void dgVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVendedores.SelectedRows.Count > 1)
            {
                // Aviso
                return;
            }

            foreach (DataGridViewRow row in dgVendedores.SelectedRows)
            {
                Vendedor vendedorSelecionado = (Vendedor)row.DataBoundItem;
                if (this.Owner != null)
                {
                    if (typeof(CadastroVendedor).IsInstanceOfType(this.Owner))
                    {
                        CadastroVendedor cadastro = (CadastroVendedor)this.Owner;
                        cadastro.getDadosPesquisa(vendedorSelecionado);
                    } else if (typeof(CadastroVenda).IsInstanceOfType(this.Owner))
                    {
                        CadastroVenda cadastro = (CadastroVenda)this.Owner;
                        cadastro.getDadosPesqVendedor(vendedorSelecionado);
                    }
                    else if (typeof(ConsultaVenda).IsInstanceOfType(this.Owner))
                    {
                        ConsultaVenda cadastro = (ConsultaVenda)this.Owner;
                        cadastro.getDadosPesqVdr(vendedorSelecionado);
                    }
                    else if (typeof(RelatorioDeVendas).IsInstanceOfType(this.Owner))
                    {
                        RelatorioDeVendas cadastro = (RelatorioDeVendas)this.Owner;
                        cadastro.getDadosPesqVdr(vendedorSelecionado);
                    }
                }
            }
            this.Close();
        }
    }
}
