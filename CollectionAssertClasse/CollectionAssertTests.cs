using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CollectionAssertClasse
{
    [TestClass]
    public class CollectionAssertTests
    {
        [TestMethod]
        [TestCategory("Collection Assert Classe")]
        public void StringCollection_Test()
        {
            List<string> collection1 = new List<string>();
            collection1.Add("test");
            collection1.Add("test1");
            collection1.Add("test2");

            List<string> collection2 = new List<string>();
            collection2.Add("test");
            collection2.Add("test1");
            collection2.Add("test2");

            CollectionAssert.AreEqual(collection1, collection2); //NotEqual
            CollectionAssert.AreEquivalent(collection1, collection2); //vérification des réferences

        }

        [TestMethod]
        [TestCategory("Collection Assert Classe")]
        public void IntCollection_Test()
        {
            List<int> collection1 = new List<int>();
            collection1.Add(10);
            collection1.Add(20);
            collection1.Add(30);

            List<int> collection2 = new List<int>();
            collection2.Add(10);
            collection2.Add(20);
            collection2.Add(30);

            CollectionAssert.AreEqual(collection1, collection2); //NotEqual
            CollectionAssert.AreEquivalent(collection1, collection2);

        }

        [TestMethod]
        [TestCategory("Collection Assert Classe")]
        public void ComplexeObjectCollection_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe { Name="test1"});
            collection1.Add(new Employe { Name="test2"});
            collection1.Add(new Employe { Name="test3"});


            List<Employe> collection2 = new List<Employe>();
            collection2.Add(new Employe { Name = "test1" });
            collection2.Add(new Employe { Name = "test2" });
            collection2.Add(new Employe { Name = "test3" });



           CollectionAssert.AreEqual(collection1, collection2); //NotEqual
          // CollectionAssert.AreEquivalent(collection1, collection2); //vérifcation des réference

        }

        [TestMethod]
        [TestCategory("Collection Assert Classe")]
        public void ComplexeObjectCollection_Contains_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe { Name = "test1" });
            collection1.Add(new Employe { Name = "test2" });
            collection1.Add(new Employe { Name = "test3" });



            //override de Equals
            CollectionAssert.Contains(collection1, new Employe { Name = "test1" });
        }


        [TestMethod]
        [TestCategory("Collection Assert Classe")]
        public void ComplexeObjectCollection_IsSubset_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe { Name = "test1" }); //4444444
            collection1.Add(new Employe { Name = "test2" });
            collection1.Add(new Employe { Name = "test3" });

            List<Employe> collection2 = new List<Employe>();
            collection2.Add(new Employe { Name = "test1" }); //4444444
            collection2.Add(new Employe { Name = "test2" });

            //override de Equals + GetHashCode
            CollectionAssert.IsSubsetOf(collection2, collection1);
        }
    }
}
