using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace InitializationAndCleanup.Tests
{
    [TestClass]
    public class RectangeTests
    {
        /*
         * 3 niveaux d'initilisation des paramètres:
         * 
         * Méthode de test [TestInitialize]  [TestCleanup]
         * - Classe 
         * - Assembly
         * 
         */

        Rectangle rec;


        [TestInitialize] //cette méthode va s'exécuter avant chaque méthode de test
        public void Setup()
        {
            rec = new Rectangle();
            rec.Longueur = 10;
            rec.Largeur = 20;

            Console.WriteLine("Setup......");
            MessageBox.Show("Setup");
        }

        [TestCleanup] //cette méthode va s'exécuter après chaque méthode de test
        public void Cleanup()
        {
            rec = null;
            MessageBox.Show("Cleanup");
        }

        [TestMethod]
        [TestCategory("Initialisation et nettoyage des paramètres")]
        public void Surface_Test()
        {
            //Arrange
            /* Rectangle rec = new Rectangle();
             rec.Longueur = 10;
             rec.Largeur = 20;*/
            //Setup();
            double attendu = 200;

            //Act
            double obtenu = rec.Surface();

            //Assert
            Assert.AreEqual(attendu, obtenu);
            Console.WriteLine("Test surface");
            MessageBox.Show("Surface");
        }

        [TestMethod]
        [TestCategory("Initialisation et nettoyage des paramètres")]
        public void Perimetre_Test()
        {
            //Arrange
            /* Rectangle rec = new Rectangle();
             rec.Longueur = 10;
             rec.Largeur = 20;*/
            //Setup();
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
