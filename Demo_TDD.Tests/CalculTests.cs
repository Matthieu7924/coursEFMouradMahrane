using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Demo_TDD.Tests
{
    [TestClass]
    public class CalculTests
    {
        [TestMethod]
        [TestCategory("TDD")]
        public void Add_Test()
        {
            //Arrange:
            int a = 10;
            int b = 5;
            int attendu = 15;

            //Act:

            int obtenu = Calcul.Add(a, b);

            //Assert
            Assert.AreEqual(attendu, obtenu);

        }

        [TestMethod]
        [TestCategory("TDD")]
        public void Add_ParamsPositifs_RetrunResultPositif()
        {
            //Arrange:
            int a = 20;
            int b = 50;
            int attendu = 70;

            //Act:

            int obtenu = Calcul.Add(a, b);

            //Assert
            Assert.AreEqual(attendu, obtenu);

        }
    }
}
