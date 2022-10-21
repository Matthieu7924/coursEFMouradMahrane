using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssertClasse
{
    [TestClass]
    public class AssertClasseTests
    {
        /*
         * Assert - CollectionAssert - StringAssert
         * 
         */

        [TestMethod]
        [TestCategory("Assert Classe")]
        public void AreEqual()
        {
            double attendu = 28;
            double obtenu = Math.Pow(5, 2);
            Assert.AreNotEqual(attendu, obtenu);

            //AreEqual
        }

        [TestMethod]
        [TestCategory("Assert Classe")]
        public void AreSame()
        {
            //Permet de tester les réference (pas le contenu - pour le contenu c'est la méthode equals)
            Employe e1 = new Employe { Name = "dawan" };
            Employe e2 = new Employe { Name = "dawan" };
            Employe e3 = e1;

            Assert.AreSame(e1, e3);
            Assert.AreNotSame(e1, e2);
        }


        [TestMethod]
        [TestCategory("Assert Classe")]
        public void IsNull()
        {
            Assert.IsNull(null);
            Assert.IsNotNull(new Employe());
        }

        [TestMethod]
        [TestCategory("Assert Classe")]
        public void IsTrue()
        {
            Assert.IsTrue(true);
            Assert.IsFalse(false);
        }

        [TestMethod]
        [TestCategory("Assert Classe")]
        public void InstanceOf()
        {
            Technicien t = new Technicien();
            Employe e = new Employe();

            Assert.IsInstanceOfType(t, typeof(Employe));
            Assert.IsInstanceOfType(e, typeof(object));
        }

        [TestMethod]
        [TestCategory("Assert Classe")]
        public void ObjectEquality()
        {
            //Redéfinir Equals dans la Classe Employe

            Employe e1 = new Employe { Name = "dawan" };
            Employe e2 = new Employe { Name = "dawan" };
            Console.WriteLine(e1.Equals(e2));
            Assert.AreEqual(e1, e2);
        }
    }
}
