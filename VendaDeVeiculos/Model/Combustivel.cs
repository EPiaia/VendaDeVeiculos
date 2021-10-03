using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Combustivel
    {
        private int? comId;
        private string comNome;

        public Combustivel()
        {
        }

        public Combustivel(int? comId, string comNome)
        {
            this.comId = comId;
            this.comNome = comNome;
        }

        public int? ComId { get => comId; set => comId = value; }
        public string ComNome { get => comNome; set => comNome = value; }

        public override bool Equals(object obj)
        {
            return obj is Combustivel combustivel &&
                   comId == combustivel.comId &&
                   comNome == combustivel.comNome;
        }

        public override int GetHashCode()
        {
            int hashCode = -1788800486;
            hashCode = hashCode * -1521134295 + comId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(comNome);
            return hashCode;
        }
    }
}
