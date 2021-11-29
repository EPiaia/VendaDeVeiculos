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
    public partial class RelatorioDeVeiculos : Form
    {

        private VeiculoService vs = new VeiculoService(); 

        public RelatorioDeVeiculos()
        {
            InitializeComponent();
            cbUsado.SelectedIndex = 0;
            cbVendidos.SelectedIndex = 0;
        }

        private void RelatorioDeVeiculos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
            this.reportViewer1.RefreshReport();
        }

        private void btnGerarRelat_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            if(tbMarca.Text.Trim().Length > 0)
            {
                filtros.Add("vclMarca", tbMarca.Text.Trim());
            }
            if (tbModelo.Text.Trim().Length > 0)
            {
                filtros.Add("vclModelo", tbModelo.Text.Trim());
            }
            if (tbTipo.Text.Trim().Length > 0)
            {
                filtros.Add("vclTipo", tbTipo.Text.Trim());
            }
            if(cbUsado.SelectedIndex != 0)
            {
                if(cbUsado.SelectedIndex == 1)
                {
                    filtros.Add("vclUsado", "1");
                } else
                {
                    filtros.Add("vclUsado", "0");
                }
            }
            if (cbVendidos.SelectedIndex != 0)
            {
                if (cbVendidos.SelectedIndex == 1)
                {
                    filtros.Add("vclVendido", "1");
                }
                else
                {
                    filtros.Add("vclVendido", "0");
                }
            }
            VeiculoBindingSource.DataSource = vs.filtrarVeiculos(filtros);
            this.reportViewer1.RefreshReport();
        }
    }
}
