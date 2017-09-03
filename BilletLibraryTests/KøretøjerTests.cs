using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class KøretøjerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void KøretøjerNummerPladeMax7TegnTest()
        {
            //Arrange & Act
            Bil bil = new Bil("AA121234", DateTime.Now);
            //Assert
            //none
        }
    }
}