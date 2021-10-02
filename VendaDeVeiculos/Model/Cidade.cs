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

        public int? CidId { get => cidId; set => cidId = value; }
        public string CidNome { get => cidNome; set => cidNome = value; }
        public string CidPais { get => cidPais; set => cidPais = value; }
        public string CidUf { get => cidUf; set => cidUf = value; }

        public Cidade()
        {}

        public Cidade(int? cidId, string cidNome, string cidPais, string cidUf)
        {
            this.cidId = cidId;
            this.cidNome = cidNome;
            this.cidPais = cidPais;
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
