using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Veiculo
    {
        private int? vclId;
        private string vclChassi;
        private string vclMotor;
        private Modelo vclModelo;
        private bool vclUsado;
        private double? vclKm;
        private string vclComplemento;
        private bool vclVendido;

        public Veiculo()
        {
        }

        public Veiculo(int? vclId, string vclChassi, string vclMotor, Modelo vclModelo, bool vclUsado, double? vclKm, string vclComplemento, bool vclVendido)
        {
            this.vclId = vclId;
            this.vclChassi = vclChassi;
            this.vclMotor = vclMotor;
            this.vclModelo = vclModelo;
            this.vclUsado = vclUsado;
            this.vclKm = vclKm;
            this.vclComplemento = vclComplemento;
            this.vclVendido = vclVendido;
        }

        public int? VclId { get => vclId; set => vclId = value; }
        public string VclChassi { get => vclChassi; set => vclChassi = value; }
        public string VclMotor { get => vclMotor; set => vclMotor = value; }
        public bool VclUsado { get => vclUsado; set => vclUsado = value; }
        public double? VclKm { get => vclKm; set => vclKm = value; }
        public string VclComplemento { get => vclComplemento; set => vclComplemento = value; }
        public bool VclVendido { get => vclVendido; set => vclVendido = value; }
        internal Modelo VclModelo { get => vclModelo; set => vclModelo = value; }

        public override bool Equals(object obj)
        {
            return obj is Veiculo veiculo &&
                   vclId == veiculo.vclId;
        }

        public override int GetHashCode()
        {
            return 1963046179 + vclId.GetHashCode();
        }
    }
}
