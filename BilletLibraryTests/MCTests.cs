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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}