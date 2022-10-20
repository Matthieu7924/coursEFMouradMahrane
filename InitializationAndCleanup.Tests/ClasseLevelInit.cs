using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace InitializationAndCleanup.Tests
{
    [TestClass]
    public class ClasseLevelInit
    {
        static Rectangle rec;

        [AssemblyInitialize] //méthode qui's'exécute avant toutes classes de test qui se trouve dans le mm projet
        public static void AssemblyInit(TestContext testContext)
        {
            MessageBox.Show("Assembly Level Cleanup");
        }

        [AssemblyCleanup] //méthode qui's'exécute avant toutes classes de test qui se trouve dans le mm projet
        public static void AssemblyCleanup()
        {
            MessageBox.Show("Assembly Level Cleanup");
        }


        [ClassInitialize] // cette méthode s'exécute une seulle fois avant toutes les méthodes de test
        public static void Setup(TestContext TestContext)
        {
            
            rec = new Rectangle();
            rec.Longueur = 10;
            rec.Largeur = 20;
            MessageBox.Show("Classe Level Setup");
        }

        [ClassCleanup] //cette méthode s'exécute une seule fois, à la fin de l'exécution de toutes les méthode de test
        public static void Cleanup()
        {
            rec = null;
            MessageBox.Show("Classe Level Cleanup");
        }


        [TestMethod]
        [TestCategory("Initialisation et nettoyage des paramètres niveau Classe")]
        public void Surface_Test()
        {
            
            double attendu = 200;

            //Act
            double obtenu = rec.Surface();

            //Assert
            Assert.AreEqual(attendu, obtenu);
            Console.WriteLine("Test surface");
            MessageBox.Show("Surface");
        }

        [TestMethod]
        [TestCategory("Initialisation et nettoyage des paramètres niveau Classe")]
        public void Perimetre_Test()
        {
           
            double attendu = 60;

            //Act
            double obtenu = rec.Perimetre();

            //Assert
            Assert.AreEqual(attendu, obtenu);
            Console.WriteLine("Test perimètre");
            MessageBox.Show("Perimetre");
        }
    }
}
