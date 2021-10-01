using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Cidade
    {
        private int? cidId;
        private string cidNome;
        private string cidPais;
        private string cidUf;

        public Cidade()
        {}

        public Cidade(int? cidId, string cidNome, string cidPais, string cidUf)
        {
            this.cidId = cidId;
            this.cidNome = cidNome;
            this.cidPais = cidPais;
            this.cidUf = cidUf;
        }

        public int? getCidId()
        {
            return this.cidId;
        }

        public void setCidId(int? cidId)
        {
            this.cidId = cidId;
        }

        public string getCidNome()
        {
            return this.cidNome;
        }

        public void setCidNome(string cidNome)
        {
            this.cidNome = cidNome;
        }

        public string getCidPais()
        {
            return this.cidPais;
        }

        public void setCidPais(string cidPais)
        {
            this.cidPais = cidPais;
        }

        public string getCidUf()
        {
            return this.cidUf;
        }

        public void setCidUf(string cidUf)
        {
            this.cidUf = cidUf;
        }

        public override bool Equals(object obj)
        {
            return obj is Cidade cidade &&
                   cidId == cidade.cidId;
        }

        public override int GetHashCode()
        {
            return -1830224766 + cidId.GetHashCode();
        }
    }
}
