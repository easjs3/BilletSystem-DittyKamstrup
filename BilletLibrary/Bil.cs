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
        public override double Pris()
        {
            if (BroBizz)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    return GrundPris * 0.80;
                }
                else
                {
                    return GrundPris * 0.95;
                }
            }
            else
            {
                return GrundPris;
            }
        }
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
