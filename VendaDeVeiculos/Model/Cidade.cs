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

        public Cidade(int? id, string nome, string pais, string uf)
        {
            this.cidId = id;
            this.cidNome = nome;
            this.cidPais = pais;
            this.cidUf = uf;
        }

        public int? getCidId()
        {
            return this.cidId;
        }

        public void setCidId(int? id)
        {
            this.cidId = id;
        }

        public string getCidNome()
        {
            return this.cidNome;
        }

        public void setCidNome(string nome)
        {
            this.cidNome = nome;
        }

        public string getCidPais()
        {
            return this.cidPais;
        }

        public void setCidPais(string pais)
        {
            this.cidPais = pais;
        }

        public string getCidUf()
        {
            return this.cidUf;
        }

        public void setCidUf(string uf)
        {
            this.cidUf = uf;
        }


    }
}
