using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Especificacoes
    {
        private int? espId;
        private Combustivel espCombustivel;
        private int? espPortas;
        private int? espHp;
        private Tipo espTipo;

        public Especificacoes()
        {
        }

        public Especificacoes(int? espId, Combustivel espCombustivel, int? espPortas, int? espHp, Tipo espTipo)
        {
            this.espId = espId;
            this.espCombustivel = espCombustivel;
            this.espPortas = espPortas;
            this.espHp = espHp;
            this.espTipo = espTipo;
        }

        public int? EspId { get => espId; set => espId = value; }
        public int? EspPortas { get => espPortas; set => espPortas = value; }
        public int? EspHp { get => espHp; set => espHp = value; }
        internal Combustivel EspCombustivel { get => espCombustivel; set => espCombustivel = value; }
        internal Tipo EspTipo { get => espTipo; set => espTipo = value; }

        public override bool Equals(object obj)
        {
            return obj is Especificacoes especificacoes &&
                   espId == especificacoes.espId;
        }

        public override int GetHashCode()
        {
            return -1155114202 + espId.GetHashCode();
        }
    }
}
