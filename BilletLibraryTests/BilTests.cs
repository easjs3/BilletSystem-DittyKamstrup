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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            //Arrange
            Bil bil = new Bil("Storebælt", "AA12123", DateTime.Now, false);
            //Act
            var pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange
            Bil bil = new Bil("Storebælt", "AA12123", DateTime.Now, true);
            //Act
            var køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }
    }
}