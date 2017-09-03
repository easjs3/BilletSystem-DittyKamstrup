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

        //ABSTRACT METHODS
        public abstract int Pris();
        public abstract string Køretøj();

    }
}
