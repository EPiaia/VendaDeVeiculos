using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    public class Venda
    {
        private int? venId;
        private Cliente venCliente;
        private Vendedor venVendedor;
        private Veiculo venVeiculo;
        private DateTime venData;
        private double? venTotal;
        private double? venAdicionais;
        private double? venTributos;
        private double? venDescontos;
        private string venPagamento;

        /* propriedades utilizadas para mostrar o valor no datagrid da consulta de vendas,
         * já que o datagrid não suporta acessar uma propriedade de uma subclasse
         */
        private string marcaVeiculo;
        private string nomeCliente;
        private string nomeVendedor;

        public Venda()
        {
        }

        public Venda(int? venId, Cliente venCliente, Vendedor venVendedor, Veiculo venVeiculo, DateTime venData, double? venTotal, double? venAdicionais, double? venTributos, double? venDescontos, string venPagamento)
        {
            this.venId = venId;
            this.venCliente = venCliente;
            this.venVendedor = venVendedor;
            this.venVeiculo = venVeiculo;
            this.venData = venData;
            this.venTotal = venTotal;
            this.VenAdicionais = venAdicionais;
            this.VenTributos = venTributos;
            this.VenDescontos = venDescontos;
            this.venPagamento = venPagamento;
        }

        public int? VenId { get => venId; set => venId = value; }
        public DateTime VenData { get => venData; set => venData = value; }
        public double? VenTotal { get => venTotal; set => venTotal = value; }
        public string VenPagamento { get => venPagamento; set => venPagamento = value; }
        public double? VenAdicionais { get => venAdicionais; set => venAdicionais = value; }
        public double? VenTributos { get => venTributos; set => venTributos = value; }
        public double? VenDescontos { get => venDescontos; set => venDescontos = value; }
        public string MarcaVeiculo { get => marcaVeiculo; set => marcaVeiculo = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string NomeVendedor { get => nomeVendedor; set => nomeVendedor = value; }
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
