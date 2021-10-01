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

        public int? getVdrId()
        {
            return this.vdrId;
        }

        public void setVdrId(int? vdrId)
        {
            this.vdrId = vdrId;
        }

        public string getVdrNome()
        {
            return this.vdrNome;
        }

        public void setVdrNome(string vdrNome)
        {
            this.vdrNome = vdrNome;
        }

        public string getVdrCpf()
        {
            return this.vdrCpf;
        }

        public void setVdrCpf(string vdrCpf)
        {
            this.vdrCpf = vdrCpf;
        }

        public Cidade getVdrCidade()
        {
            return this.vdrCidade;
        }

        public void setVdrCidade(Cidade vdrCidade)
        {
            this.vdrCidade = vdrCidade;
        }

        public string getVdrBairro()
        {
            return this.vdrBairro;
        }

        public void setVdrBairro(string vdrBairro)
        {
            this.vdrBairro = vdrBairro;
        }

        public string getVdrLogradouro()
        {
            return this.vdrLogradouro;
        }

        public void setVdrLogradouro(string vdrLogradouro)
        {
            this.vdrLogradouro = vdrLogradouro;
        }

        public int? getVdrNum()
        {
            return this.vdrNum;
        }

        public void setVdrNum(int? vdrNum)
        {
            this.vdrNum = vdrNum;
        }

        public string getVdrCompl()
        {
            return this.vdrCompl;
        }

        public void setVdrCompl(string vdrCompl)
        {
            this.vdrCompl = vdrCompl;
        }

        public string getVdrEmail()
        {
            return this.vdrEmail;
        }

        public void setVdrEmail(string vdrEmail)
        {
            this.vdrEmail = vdrEmail;
        }

        public string getVdrFone()
        {
            return this.vdrFone;
        }

        public void setVdrFone(string vdrFone)
        {
            this.vdrFone = vdrFone;
        }

        public DateTime getVdrNascimento()
        {
            return this.vdrNascimento;
        }

        public void setVdrNascimento(DateTime vdrNascimento)
        {
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
