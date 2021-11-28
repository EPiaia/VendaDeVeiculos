using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    public class Veiculo
    {
        private int? vclId;
        private string vclChassi;
        private string vclMotor;
        private string vclModelo;
        private string vclMarca;
        private string vclTipo;
        private bool vclUsado;
        private double? vclKm;
        private string vclComplemento;
        private double? vclValor;
        private bool vclVendido;

        public Veiculo()
        {
        }

        public Veiculo(int? vclId, string vclChassi, string vclMotor, string vclModelo, string vclMarca, string vclTipo, bool vclUsado, double? vclKm, string vclComplemento, double? vclValor, bool vclVendido)
        {
            this.vclId = vclId;
            this.vclChassi = vclChassi;
            this.vclMotor = vclMotor;
            this.vclModelo = vclModelo;
            this.VclMarca = vclMarca;
            this.VclTipo = vclTipo;
            this.vclUsado = vclUsado;
            this.vclKm = vclKm;
            this.vclComplemento = vclComplemento;
            this.VclValor = vclValor;
            this.vclVendido = vclVendido;
        }

        public int? VclId { get => vclId; set => vclId = value; }
        public string VclChassi { get => vclChassi; set => vclChassi = value; }
        public string VclMotor { get => vclMotor; set => vclMotor = value; }
        public bool VclUsado { get => vclUsado; set => vclUsado = value; }
        public double? VclKm { get => vclKm; set => vclKm = value; }
        public string VclComplemento { get => vclComplemento; set => vclComplemento = value; }
        public bool VclVendido { get => vclVendido; set => vclVendido = value; }
        public string VclMarca { get => vclMarca; set => vclMarca = value; }
        public string VclTipo { get => vclTipo; set => vclTipo = value; }
        public double? VclValor { get => vclValor; set => vclValor = value; }
        public string VclModelo { get => vclModelo; set => vclModelo = value; }

        public int getBitVendido()
        {
            if (vclVendido)
            {
                return 1;
            } else
            {
                return 0;
            }
        }

        public void setVendidoPorBit(int bit)
        {
            if(bit == 1)
            {
                this.vclVendido = true;
            } else if (bit == 2)
            {
                this.vclVendido = false;
            }
        }

        public int getBitUsado()
        {
            if (vclUsado)
            {
                return 1;
            } else
            {
                return 0;
            }
        }

        public void setUsadoPorBit(int bit)
        {
            if (bit == 1)
            {
                this.vclUsado = true;
            }
            else if (bit == 2)
            {
                this.vclUsado = false;
            }
        }


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
