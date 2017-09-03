using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class Køretøjer
    {
        //PROPERTIES
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }
        public bool BroBizz { get; set; }
        public double GrundPris { get; set; }

        //CONSTRUCTOR
        public Køretøjer(string nummerPlade, DateTime dato, bool broBizz)
        {
            NummerPlade = nummerPlade;
            Dato = dato;
            BroBizz = broBizz;

            if (nummerPlade.Length > 7)
            {
                throw new ArgumentOutOfRangeException("Nummerpladen kan maks være på 7 tegn!");
            }

        }

        //ABSTRACT METHODS
        public abstract string Køretøj();

        //METHODS
        public virtual double Pris()
        {
            if (BroBizz)
            {
                return GrundPris * 0.95;
            }
            else
            {
                return GrundPris;
            }
        }

    }
}
