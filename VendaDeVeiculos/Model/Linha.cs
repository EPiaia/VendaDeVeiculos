using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Linha
    {
        private int? linId;
        private string linNome;
        private char linAtiina = 'A';
        private Marca linMarca;

        public int? LinId { get => linId; set => linId = value; }
        public string LinNome { get => linNome; set => linNome = value; }
        public char LinAtiina { get => linAtiina; set => linAtiina = value; }
        internal Marca LinMarca { get => linMarca; set => linMarca = value; }

        public Linha()
        {
        }

        public Linha(int? linId, string linNome, char linAtiina, Marca linMarca)
        {
            this.linId = linId;
            this.linNome = linNome;
            this.linAtiina = linAtiina;
            this.linMarca = linMarca;
        }

        public override bool Equals(object obj)
        {
            return obj is Linha linha &&
                   linId == linha.linId;
        }

        public override int GetHashCode()
        {
            return 88071181 + linId.GetHashCode();
        }
    }
}
