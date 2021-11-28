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
    public partial class ConsultaCliente : Form
    {

        private ClienteService cs = new ClienteService();

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if(tbCodigo.Text.Trim().Length == 0 && tbNome.Text.Trim().Length == 0 && tbCpfCnpj.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha ao menos um dos campos.");
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if (tbCodigo.Text.Trim().Length > 0)
            {
                filtros.Add("cliId", tbCodigo.Text);
            }
            else
            {
                if (tbNome.Text.Trim().Length > 0)
                {
                    filtros.Add("cliNome", tbNome.Text);
                }
                if (tbCpfCnpj.Text.Trim().Length > 0)
                {
                    filtros.Add("cliCpfCnpj", tbCpfCnpj.Text);
                }
            }

            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = cs.filtrarClientes(filtros);
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = cs.pesquisarTodosClientes();
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgClientes.SelectedRows.Count > 1)
            {
                // Aviso
                return;
            }

            foreach (DataGridViewRow row in dgClientes.SelectedRows)
            {
                Cliente clienteSelecionado = (Cliente) row.DataBoundItem;
                if (this.Owner != null)
                {
                    if (typeof(CadastroCliente).IsInstanceOfType(this.Owner))
                    {
                        CadastroCliente cadastro = (CadastroCliente)this.Owner;
                        cadastro.getDadosPesquisa(clienteSelecionado);
                    } else if (typeof(CadastroVenda).IsInstanceOfType(this.Owner))
                    {
                        CadastroVenda cadastro = (CadastroVenda)this.Owner;
                        cadastro.getDadosPesqCliente(clienteSelecionado);
                    }
                    else if (typeof(ConsultaVenda).IsInstanceOfType(this.Owner))
                    {
                        ConsultaVenda cadastro = (ConsultaVenda)this.Owner;
                        cadastro.getDadosPesqCli(clienteSelecionado);
                    }
                }
            }
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbCpfCnpj.Text = "";
            dgClientes.DataSource = new ArrayList();
        }

        private void dgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
