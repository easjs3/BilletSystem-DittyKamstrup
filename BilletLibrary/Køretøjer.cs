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

        //CONSTRUCTOR
        public Køretøjer(string nummerPlade, DateTime dato)
        {
            NummerPlade = nummerPlade;
            Dato = dato;

            if (nummerPlade.Length > 7)
            {
                throw new ArgumentOutOfRangeException("Nummerpladen kan maks være på 7 tegn!");
            }
        }

        //ABSTRACT METHODS
        public abstract int Pris();
        public abstract string Køretøj();

    }
}
