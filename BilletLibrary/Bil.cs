using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        /// <summary>   
        /// Objekt Bil.
        /// </summary>
        /// <param name="nummerplade"></param>
        public Bil(string nummerplade) : base(nummerplade)
        {

        }
        /// <summary>
        /// Returnere prisen på en billet.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Returnere typen på køretøjet.
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
