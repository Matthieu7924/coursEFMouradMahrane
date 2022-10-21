using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAssertClasse
{
    [TestClass]
    public class StringAssertTests
    {
        [TestMethod]
        [TestCategory("String Assert Classe")]
        public void StartsWith_Test()
        {
            StringAssert.StartsWith("chaine de test", "chaine");
        }

        [TestMethod]
        [TestCategory("String Assert Classe")]
        public void EndsWith_Test()
        {
            StringAssert.EndsWith("chaine de test", "test");
        }

        [TestMethod]
        [TestCategory("String Assert Classe")]
        public void Contains_Test()
        {
            StringAssert.Contains("chaine de test", "test");
        }

        [TestMethod]
        [TestCategory("String Assert Classe")]
        public void Match_Test()
        {
            Regex regEmail = new Regex(@"^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,20}\.[a-zA-Z]{2,5}$");
            StringAssert.Matches("test@yahoo.fr", regEmail);   
        }
    }
}
