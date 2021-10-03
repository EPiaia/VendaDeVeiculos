using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Venda
    {
        private int? venId;
        private Cliente venCliente;
        private Vendedor venVendedor;
        private Veiculo venVeiculo;
        private DateTime venData;
        private double? venTotal;
        private string venPagamento;
        private string venEspecificacoes;

        public Venda()
        {
        }

        public Venda(int? venId, Cliente venCliente, Vendedor venVendedor, Veiculo venVeiculo, DateTime venData, double? venTotal, string venPagamento, string venEspecificacoes)
        {
            this.venId = venId;
            this.venCliente = venCliente;
            this.venVendedor = venVendedor;
            this.venVeiculo = venVeiculo;
            this.venData = venData;
            this.venTotal = venTotal;
            this.venPagamento = venPagamento;
            this.venEspecificacoes = venEspecificacoes;
        }

        public int? VenId { get => venId; set => venId = value; }
        public DateTime VenData { get => venData; set => venData = value; }
        public double? VenTotal { get => venTotal; set => venTotal = value; }
        public string VenPagamento { get => venPagamento; set => venPagamento = value; }
        public string VenEspecificacoes { get => venEspecificacoes; set => venEspecificacoes = value; }
        internal Cliente VenCliente { get => venCliente; set => venCliente = value; }
        internal Vendedor VenVendedor { get => venVendedor; set => venVendedor = value; }
        internal Veiculo VenVeiculo { get => venVeiculo; set => venVeiculo = value; }

        public override bool Equals(object obj)
        {
            return obj is Venda venda &&
                   venId == venda.venId;
        }

        public override int GetHashCode()
        {
            return 119796539 + venId.GetHashCode();
        }
    }
}
