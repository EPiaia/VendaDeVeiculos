using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Tipo
    {
        private int? tipId;
        private string tipNome;

        public Tipo()
        {
        }

        public Tipo(int? tipId, string tipNome)
        {
            this.tipId = tipId;
            this.tipNome = tipNome;
        }

        public int? TipId { get => tipId; set => tipId = value; }
        public string TipNome { get => tipNome; set => tipNome = value; }

        public override bool Equals(object obj)
        {
            return obj is Tipo tipo &&
                   tipId == tipo.tipId;
        }

        public override int GetHashCode()
        {
            return 199592255 + tipId.GetHashCode();
        }
    }
}
