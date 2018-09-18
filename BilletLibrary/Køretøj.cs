using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public Køretøj(string nummerplade)
        {
            Nummerplade = nummerplade;
            Dato = new DateTime();

            if (Nummerplade.Length > 7)
            {
                throw new Exception("Nummerpladen må maks være på 7 tegn");
            }
        }
        /// <summary>
        /// Returnere prisen på en billet.
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();
        /// <summary>
        /// Returnere typen på køretøjet.
        /// </summary>
        /// <returns></returns>
        public virtual string KøretøjType()
        {
            return "Køretøj";
        }
    }
}
