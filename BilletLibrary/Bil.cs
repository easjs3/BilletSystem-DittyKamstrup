﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Køretøjer
    {
        public Bil(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {

        }

        //METHODS
        public override int Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
