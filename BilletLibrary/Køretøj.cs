using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private DateTime _dato;
        public string Nummerplade { get; set; }

        public DateTime Dato
        {
            get { return _dato; }
            set
            {
                TjekNummerplade();
                _dato = value; 
            }
        }

        public Køretøj(string nummerplade)
        {
            Nummerplade = nummerplade;
            Dato = new DateTime();

            TjekNummerplade();
        }
        /// <summary>
        /// Returnere prisen på en billet.
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris(bool broBizz);
        /// <summary>
        /// Returnere typen på køretøjet.
        /// </summary>
        /// <returns></returns>
        public virtual string KøretøjType()
        {
            return "Køretøj";
        }
        /// <summary>
        /// Tjekker om nummerpladen er over 7 tegn.
        /// </summary>
        /// <returns></returns>
        public void TjekNummerplade()
        {
            if (Nummerplade.Length > 7)
            {
                throw new Exception("Nummerpladen må maks være på 7 tegn");
            }
        }
    }
}
