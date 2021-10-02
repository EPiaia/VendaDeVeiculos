using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Vendedor
    {
        private int? vdrId;
        private string vdrNome;
        private string vdrCpf;
        private Cidade vdrCidade;
        private string vdrBairro;
        private string vdrLogradouro;
        private int? vdrNum;
        private string vdrCompl;
        private string vdrEmail;
        private string vdrFone;
        private DateTime vdrNascimento;

        public int? VdrId { get => vdrId; set => vdrId = value; }
        public string VdrNome { get => vdrNome; set => vdrNome = value; }
        public string VdrCpf { get => vdrCpf; set => vdrCpf = value; }
        public string VdrBairro { get => vdrBairro; set => vdrBairro = value; }
        public string VdrLogradouro { get => vdrLogradouro; set => vdrLogradouro = value; }
        public int? VdrNum { get => vdrNum; set => vdrNum = value; }
        public string VdrCompl { get => vdrCompl; set => vdrCompl = value; }
        public string VdrEmail { get => vdrEmail; set => vdrEmail = value; }
        public string VdrFone { get => vdrFone; set => vdrFone = value; }
        public DateTime VdrNascimento { get => vdrNascimento; set => vdrNascimento = value; }
        internal Cidade VdrCidade { get => vdrCidade; set => vdrCidade = value; }

        public Vendedor()
        {
        }

        public Vendedor(int? vdrId, string vdrNome, string vdrCpf, Cidade vdrCidade, string vdrBairro, string vdrLogradouro, int? vdrNum, string vdrCompl, string vdrEmail, string vdrFone, DateTime vdrNascimento)
        {
            this.vdrId = vdrId;
            this.vdrNome = vdrNome;
            this.vdrCpf = vdrCpf;
            this.vdrCidade = vdrCidade;
            this.vdrBairro = vdrBairro;
            this.vdrLogradouro = vdrLogradouro;
            this.vdrNum = vdrNum;
            this.vdrCompl = vdrCompl;
            this.vdrEmail = vdrEmail;
            this.vdrFone = vdrFone;
            this.vdrNascimento = vdrNascimento;
        }

        public override bool Equals(object obj)
        {
            return obj is Vendedor vendedor &&
                   vdrId == vendedor.vdrId;
        }

        public override int GetHashCode()
        {
            return -171552478 + vdrId.GetHashCode();
        }
    }
}
