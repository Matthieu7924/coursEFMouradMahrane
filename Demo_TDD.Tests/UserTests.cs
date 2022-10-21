using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Demo_TDD.Tests
{
    //Mot de passe valide: pas null, pas une chaine vide,
    //contient au minimum 8 caractère, pas d'espaces, pas de caractères spéciaux

    [TestClass]
    public class UserTests
    {
        User u;

        [TestInitialize]
        public void Setup()
        {
            u = new User();
        }

        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void Password_Valide_ReturnTrue()
        {
            //Arrange:
            string password = "sqdqsd1458s";

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsTrue(obtenu);
        }

        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void Password_Null_ReturnFalse()
        {
            //Arrange:
            string password = null;

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsFalse(obtenu);
        }

        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void Password_Empty_ReturnFalse()
        {
            //Arrange:
            string password = string.Empty;

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsFalse(obtenu);
        }


        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void PasswordLenght_LessThen8Char_ReturnFalse()
        {
            //Arrange:
            string password = "zedtllm";

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsFalse(obtenu);
        }

        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void Password_Contain_Space_ReturnFalse()
        {
            //Arrange:
            string password = "zedtllmlll hhhh";

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsFalse(obtenu);
        }

        [TestMethod]
        [TestCategory("TDD Ex2")]
        public void Password_Contain_SpecialChar_ReturnFalse()
        {
            //Arrange:
            string password = "zedtllmlll@hhhh";

            //Act:
            //User u = new User();
            bool obtenu = u.CheckPassword(password);

            //Assert
            Assert.IsFalse(obtenu);
                
        }
    }
}
