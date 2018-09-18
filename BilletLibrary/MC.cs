using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        /// <summary>   
        /// Objekt Motor Cykle.
        /// </summary>
        /// <param name="nummerplade"></param>
        public MC(string nummerplade) : base(nummerplade)
        {

        }
        /// <summary>
        /// Returnere prisen på en billet.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris(bool broBizz)
        {
            if (broBizz)
                return (125 / 100) * 95;
            return 125;
        }
        /// <summary>
        /// Returnere typen på køretøjet.
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType()
        {
            return "MC";
        }
    }
}
