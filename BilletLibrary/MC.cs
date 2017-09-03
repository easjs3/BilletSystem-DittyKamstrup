using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Køretøjer
    {
        public MC(string nummerPlade, DateTime dato, bool broBizz) : base(nummerPlade, dato, broBizz)
        {
            GrundPris = 125;
        }

        //METHODS
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
