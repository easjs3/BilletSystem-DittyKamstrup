using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Køretøjer
    {
        public MC(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {

        }

        //METHODS
        public override int Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
