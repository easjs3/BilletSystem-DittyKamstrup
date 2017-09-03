using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Køretøjer
    {
        public MC(string bro, string nummerPlade, DateTime dato, bool broBizz) : base(bro, nummerPlade, dato, broBizz)
        {
            if (bro == "Storebælt")
            {
                GrundPris = 125;
            }
            else if (bro == "Øresund")
            {
                GrundPris = 210;
                if (broBizz)
                {
                    GrundPris = 73;
                }
            }
        }

        //METHODS
        public override string Køretøj()
        {
            if (Bro == "Storebælt")
            {
                return "MC";
            }
            else if (Bro == "Øresund")
            {
                return "Øresund MC";
            }
            else
            {
                throw new ArgumentException("Dette er ikke en bro i systemet");
            }
        }
    }
}
