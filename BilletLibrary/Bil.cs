using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil
    {
        //PROPERTIES
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        //METHODS
        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
