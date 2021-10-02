using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaDeVeiculos.Model
{
    class Marca
    {
        private int? marId;
        private string marNome;
        private char marAtiina = 'A';
        private byte[] marLogo;

        public int? MarId { get => marId; set => marId = value; }
        public string MarNome { get => marNome; set => marNome = value; }
        public char MarAtiina { get => marAtiina; set => marAtiina = value; }
        public byte[] MarLogo { get => marLogo; set => marLogo = value; }

        public Marca()
        {
        }

        public Marca(int? marId, string marNome, char marAtiina, byte[] marLogo)
        {
            this.marId = marId;
            this.marNome = marNome;
            this.marAtiina = marAtiina;
            this.marLogo = marLogo;
        }

        public override bool Equals(object obj)
        {
            return obj is Marca marca &&
                   marId == marca.marId;
        }

        public override int GetHashCode()
        {
            return 736454166 + marId.GetHashCode();
        }
    }
}
