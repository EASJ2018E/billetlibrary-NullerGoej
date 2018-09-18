using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        /// <summary>   
        /// Objekt Motor Cykle.
        /// </summary>
        /// <param name="nummerplade"></param>
        public MC(string nummerplade)
        {
            Nummerplade = nummerplade;
            Dato = new DateTime();
        }
        /// <summary>
        /// Motor Cyklens Nummerplade.
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Motor Cyklens Dato.
        /// </summary>
        public DateTime Dato { get; set; }
        /// <summary>
        /// Pris for Motor Cykle Billet.
        /// </summary>
        /// <returns>Retunere Prisen for Motor Cykle Billet</returns>
        public decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Type Køretøj.
        /// </summary>
        /// <returns>Returene Køretøjet</returns>
        public string Køretøj()
        {
            return "MC";
        }
    }
}
