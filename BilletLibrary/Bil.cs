using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Køretøjer
    {
        public Bil(string nummerPlade, DateTime dato, bool broBizz) : base(nummerPlade, dato, broBizz)
        {
            GrundPris = 240;
        }

        //METHODS
        //public override double Pris()
        //{
        //    return 240;
        //}

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
