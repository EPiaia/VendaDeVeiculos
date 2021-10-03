using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Modelo
    {
        private int? modId;
        private string modNome;
        private string modAno;
        private char modAtiina = 'A';
        private Linha modLinha;
        private Combustivel modCombustivel;
        private Especificacoes modEspecificacoes;

        public Modelo()
        {
        }

        public Modelo(int? modId, string modNome, string modAno, char modAtiina, Linha modLinha, Combustivel modCombustivel, Especificacoes modEspecificacoes)
        {
            this.modId = modId;
            this.modNome = modNome;
            this.modAno = modAno;
            this.modAtiina = modAtiina;
            this.modLinha = modLinha;
            this.modCombustivel = modCombustivel;
            this.modEspecificacoes = modEspecificacoes;
        }

        public int? ModId { get => modId; set => modId = value; }
        public string ModNome { get => modNome; set => modNome = value; }
        public string ModAno { get => modAno; set => modAno = value; }
        public char ModAtiina { get => modAtiina; set => modAtiina = value; }
        internal Linha ModLinha { get => modLinha; set => modLinha = value; }
        internal Combustivel ModCombustivel { get => modCombustivel; set => modCombustivel = value; }
        internal Especificacoes ModEspecificacoes { get => modEspecificacoes; set => modEspecificacoes = value; }

        public override bool Equals(object obj)
        {
            return obj is Modelo modelo &&
                   modId == modelo.modId;
        }

        public override int GetHashCode()
        {
            return 1992526494 + modId.GetHashCode();
        }
    }
}
