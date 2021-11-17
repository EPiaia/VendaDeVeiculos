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
    public partial class CadastroCliente : Form
    {

        private Cliente cliente;
        private bool adicionar = false;
        private ClienteService cs = new ClienteService();

        public CadastroCliente()
        {
            InitializeComponent();
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
            cliente.CliId = Convert.ToInt32(tbCodigo.Text);
            cliente.CliNome = tbNome.Text;
            cliente.CliCpfCnpj = tbCpfCnpj.Text;
            // cliente.CliCidade = Convert.ToInt32(tbCidade.Text)
            cliente.CliBairro = tbBairro.Text;
            cliente.CliLogradouro = tbLogradouro.Text;
            cliente.CliNum = Convert.ToInt32(tbNum.Text);
            cliente.CliCompl = tbCompl.Text;
            cliente.CliEmail = tbEmail.Text;
            cliente.CliFone = tbFone.Text;
            cliente.CliNascimento = dtpNasc.Value.Date;
            if (adicionar)
            {
                cs.gravarCliente(cliente);
            } else
            {

            }
        }
    }
}
