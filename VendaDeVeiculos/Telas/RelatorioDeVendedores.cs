using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaDeVeiculos.Service;

namespace VendaDeVeiculos.Telas
{
    public partial class RelatorioDeVendedores : Form
    {

        private VendedorService vs = new VendedorService();
        private bool maskCnpj = false; // controlar a máscara do campo de cpf/cnpj

        public RelatorioDeVendedores()
        {
            InitializeComponent();
            mtbCpfCnpj.Mask = "999.999.999-99";
            cbData.Checked = false;
            gbData.Visible = false;
        }

        private void RelatorioDeVendedores_Load(object sender, EventArgs e)
        {
            this.reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
            this.reportViewer1.RefreshReport();
        }

        private void btnGerarRelat_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if (tbNome.Text.Trim().Length > 0)
            {
                filtros.Add("vdrNome", tbNome.Text.Trim());
            }
            string cpfCnpj = mtbCpfCnpj.Text;
            cpfCnpj = cpfCnpj.Replace(".", "");
            cpfCnpj = cpfCnpj.Replace(",", "");
            cpfCnpj = cpfCnpj.Replace("-", "");
            cpfCnpj = cpfCnpj.Replace("/", "").Trim();
            if (cpfCnpj.Length > 0)
            {
                filtros.Add("vdrCpf", cpfCnpj);
            }
            if (cbData.Checked)
            {
                string data = dtpIni.Value.Year.ToString() + "-" + dtpIni.Value.Month + "-" + dtpIni.Value.Day;
                filtros.Add("vdrDtIni", data);
                data = dtpFim.Value.Year.ToString() + "-" + dtpFim.Value.Month + "-" + dtpFim.Value.Day;
                filtros.Add("vdrDtFim", data);
            }
            VendedorBindingSource.DataSource = vs.filtrarVendedores(filtros);
            this.reportViewer1.RefreshReport();
        }

        private Boolean validarCampos()
        {
            if (cbData.Checked && dtpIni.Value.Date > dtpFim.Value.Date)
            {
                MessageBox.Show("A data de início não pode ser maior do que a final.");
                dtpIni.Value = DateTime.Now;
                dtpFim.Value = DateTime.Now;
                return false;
            }
            return true;
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            gbData.Visible = cbData.Checked;
        }

        private void mtbCpfCnpj_KeyUp(object sender, KeyEventArgs e)
        {
            string cpfCnpj = mtbCpfCnpj.Text;
            cpfCnpj = cpfCnpj.Replace(".", "");
            cpfCnpj = cpfCnpj.Replace(",", "");
            cpfCnpj = cpfCnpj.Replace("/", "");
            cpfCnpj = cpfCnpj.Replace("-", "").Trim();
            if (cpfCnpj.Length < 11)
            {
                mtbCpfCnpj.Mask = "999.999.999-99";
                maskCnpj = false;
            }
            else if (cpfCnpj.Length == 11 && !maskCnpj)
            {
                mtbCpfCnpj.Mask = "999.999.999-99";
                maskCnpj = true;
            }
            else
            {
                mtbCpfCnpj.Mask = "99.999.999/9999-99";
            }
        }

        private void RelatorioDeVendedores_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
