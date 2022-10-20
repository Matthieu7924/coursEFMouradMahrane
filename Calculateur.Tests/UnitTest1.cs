using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Calculateur.Tests
{
    [TestClass]

    public class UnitTest1
    {
        //Classe abstraite: pour avoir une instance, il suffit de délarer un attribut qui porte le nom de la classe
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test groupe2", "Sécurité")]
        [Priority(2)]
        [Owner("Dev")]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test groupe2", "Sécurité")]
        [Priority(2)]
        [Owner("Dev")]
        public void TestMethod2()
        {
            Console.WriteLine("test d'affichage.....");
            Debug.WriteLine("test console debug.....");
            TestContext.WriteLine(TestContext.TestName);
        }

    }
}
