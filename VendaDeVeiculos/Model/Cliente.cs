using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    public class Cliente
    {
        private int? cliId;
        private string cliNome;
        private string cliCpfCnpj;
        private Cidade cliCidade;
        private string cliBairro;
        private string cliLogradouro;
        private int? cliNum;
        private string cliCompl;
        private string cliEmail;
        private string cliFone;
        private DateTime cliNascimento;

        public Cliente()
        {
        }

        public Cliente(int? cliId, string cliNome, string cliCpfCnpj, Cidade cliCidade, string cliBairro, string cliLogradouro, int? cliNum, string cliCompl, string cliEmail, string cliFone, DateTime cliNascimento)
        {
            this.cliId = cliId;
            this.cliNome = cliNome;
            this.cliCpfCnpj = cliCpfCnpj;
            this.cliCidade = cliCidade;
            this.cliBairro = cliBairro;
            this.cliLogradouro = cliLogradouro;
            this.cliNum = cliNum;
            this.cliCompl = cliCompl;
            this.cliEmail = cliEmail;
            this.cliFone = cliFone;
            this.cliNascimento = cliNascimento;
        }

        public int? CliId { get => cliId; set => cliId = value; }
        public string CliNome { get => cliNome; set => cliNome = value; }
        public string CliCpfCnpj { get => cliCpfCnpj; set => cliCpfCnpj = value; }
        public string CliBairro { get => cliBairro; set => cliBairro = value; }
        public string CliLogradouro { get => cliLogradouro; set => cliLogradouro = value; }
        public int? CliNum { get => cliNum; set => cliNum = value; }
        public string CliCompl { get => cliCompl; set => cliCompl = value; }
        public string CliEmail { get => cliEmail; set => cliEmail = value; }
        public string CliFone { get => cliFone; set => cliFone = value; }
        public DateTime CliNascimento { get => cliNascimento; set => cliNascimento = value; }
        internal Cidade CliCidade { get => cliCidade; set => cliCidade = value; }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   cliId == cliente.cliId;
        }

        public override int GetHashCode()
        {
            return 1181283980 + cliId.GetHashCode();
        }
    }
}
