using Calculateur.DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculateur.Tests
{
    [TestClass] //Attribut qui précise que c'est une classe de test
    public class CalculatorTests
    {
        /*Conventions de nommage pour les méthodes de Test: Nom_MethodeATester_EtatDesParams_EtatResultat
         * 
         * 
         */

        [TestMethod] //Attribut qui précise qu'il s'agit d'une méthode de test
        [TestCategory("Calculator")]
        [TestProperty("Test groupe1", "Performence")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurPositif_NumerateurPositif_ReturnResultatPositif()
        {
            //Pattern AAA: Arrange - Act - Assert

            //Arrange: initialiser les paramètres de la méthode à tester
            int numerateur = 10;
            int denominateur = 5;
            int resultatAttendu = 2;

            //Act: Appel de la méthode à tester
           int resultatObtenu = Calculator.Division(numerateur, denominateur);

            //Assert: vérifier les 2 résultats
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe1", "Performence")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurPositif_Denominateur_ReturnResultatNegatif()
        {
            //Arrange
            int numerateur = 10;
            int deniminateur = -5;
            int attendu = -2;

            //Act 
           int obtenu = Calculator.Division(numerateur, deniminateur);

            //Assert:
            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe1", "Performence")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurNegatif_DenominateurNegatif_ReturnResultatPositif()
        {
            //Arrange
            int numerateur = -10;
            int deniminateur = -5;
            int attendu = 2;

            //Act 
            int obtenu = Calculator.Division(numerateur, deniminateur);

            //Assert:
            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe1", "Performence")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurNegatif_DenominateurPositif_ReturnResultatNegatif()
        {
            //Arrange
            int numerateur = -10;
            int deniminateur = 5;
            int attendu = -2;

            //Act 
            int obtenu = Calculator.Division(numerateur, deniminateur);

            //Assert:
            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test groupe1", "Performence")]
        [Priority(1)]
        [Owner("Dawan")]
        [ExpectedException(typeof(DivideByZeroException))] //Attribut qui permet de vérifier les exceptions que peut générer une méthode
        public void Division_DenominateurEgalZero_ReturnException()
        {
            //Arrange
            int numerateur = -10;
            int deniminateur = 0;
            

            //Act 
            int obtenu = Calculator.Division(numerateur, deniminateur);

            
        }

        //Tester uneméthode privée statique:
        [TestMethod]
        [TestCategory("Test méthode privée via un eméthode publique")]
        public void Add_AvecIsPositif_Private()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int attendu = 30;

            //Act
           int obtenu = Calculator.Add(a, b);

            //Assert
            Assert.AreEqual(attendu,obtenu);
        }

        [TestMethod]
        [TestCategory("Test méthode privée via un eméthode publique")]
        [ExpectedException(typeof (ArgumentException))]
        public void Add_AvecIsPositif_Private_ParamNegatif()
        {
            //Arrange
            int a = 10;
            int b = -20;

            //Act
            int obtenu = Calculator.Add(a, b);

        }

        //Tester la méthode privée statique sans passer par une méthode publique
        [TestMethod]
        [TestCategory("Test méthode privée static")]
        public void IsPositif_ParamPositif_ReturnTrue()
        {
            //Arrange:
            int a = 10;
            PrivateType p = new PrivateType(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.InvokeStatic("IsPositif", a);

            //Assert
            Assert.IsTrue(obtenu);

        }

        [TestMethod]
        [TestCategory("Test méthode privée static")]
        public void IsPositif_ParamNegatif_ReturnFalse()
        {
            //Arrange:
            int a = -10;
            PrivateType p = new PrivateType(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.InvokeStatic("IsPositif", a);

            //Assert
            Assert.IsFalse(obtenu);

        }

        //Test de méthode privée non statique
        [TestMethod]
        [TestCategory("Test méthode privée non static")]
        public void IsNegatif_ParamNegatif_ReturnTrue()
        {
            //Arrange
            int a = -5;
            PrivateObject p = new PrivateObject(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.Invoke("IsNegatif", a);

            //Assert
            Assert.IsTrue(obtenu);
        }

        [TestMethod]
        [TestCategory("Test méthode privée non static")]
        public void IsNegatif_ParamPositif_ReturnTFalse()
        {
            //Arrange
            int a = 5;
            PrivateObject p = new PrivateObject(typeof(Calculator));

            //Act
            bool obtenu = (bool)p.Invoke("IsNegatif", a);

            //Assert
            Assert.IsFalse(obtenu);
        }

    }
}
