using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil
    {
        /// <summary>
        /// Objekt bil.
        /// </summary>
        /// <param name="nummerplade"></param>
        public Bil(string nummerplade)
        {
            Nummerplade = nummerplade;
            Dato = new DateTime();
        }
        /// <summary>
        /// Bilens Nummerplade.
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Bilens Dato.
        /// </summary>
        public DateTime Dato { get; set; }
        /// <summary>
        /// Pris for Bil Billet.
        /// </summary>
        /// <returns>Retunere Prisen for Bil Billet</returns>
        public decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Type Køretøj.
        /// </summary>
        /// <returns>Returene Køretøjet</returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
