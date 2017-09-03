using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Køretøjer
    {
        public Bil(string bro, string nummerPlade, DateTime dato, bool broBizz) : base(bro, nummerPlade, dato, broBizz)
        {
            if (bro == "Storebælt")
            {
                GrundPris = 240;
            }
            else if (bro == "Øresund")
            {
                GrundPris = 410;
            }
            else
            {
                throw new ArgumentException("Dette er ikke en bro i systemet");
            }
        }

        //METHODS
        public override double Pris()
        {
            if (Bro == "Storebælt")
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
            else if (Bro == "Øresund")
            {
                if (BroBizz)
                {
                    GrundPris = 161;
                    return GrundPris;
                }
                else
                {
                    return GrundPris;
                }
            }
            else
            {
                throw new ArgumentException("Dette er ikke en bro i systemet");
            }
        }
        public override string Køretøj()
        {
            if (Bro == "Storebælt")
            {
                return "Bil";
            }
            else if (Bro == "Øresund")
            {
                return "Øresund Bil";
            }
            else
            {
                throw new ArgumentException("Dette er ikke en bro i systemet");
            }
        }
    }
}
