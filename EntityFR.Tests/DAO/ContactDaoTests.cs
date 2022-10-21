using EntityFR.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EntityFR.Tests.DAO
{
    [TestClass]
    public class ContactDaoTests
    {
        /*
         * Installer Entity Framework
         * Dans App.config: fournir la chaine de connexion à une BD de test (ne pas utiliser la BD de la PROD)
         * 
         */

        ContactDAO dao;

        [TestInitialize]
        public void Setup()
        {
            dao = new ContactDAO();
        }

        [TestMethod]
        [TestCategory("EntityFR")]
        public void a_Insert_Contact_Test()
        {
            //Arrange:
            Contact c = new Contact { Id = 1, Name = "Test" };
            int tailleAvantInsertion = dao.GetAll().Count;

            //Act
            dao.Insert(c);
            int tailleApresInsertion = dao.GetAll().Count;

            //Assert
            Assert.AreEqual(tailleApresInsertion, tailleAvantInsertion + 1);
            

        }


        [TestMethod]
        [TestCategory("EntityFR")]
        public void c_GetById_Test()
        {
            //Arrange:
            int id = 1;

            //Act
            Contact c = dao.GetById(id);

            //Assert
            Assert.IsNotNull(c);
        }

        [TestMethod]
        [TestCategory("EntityFR")]
        [ExpectedException(typeof(Exception))]
        public void d_GetById_IdNotExist_ReturnException()
        {
            //Arrange:
            int id = 1500;

            //Act
            Contact c = dao.GetById(id);

        }

        [TestMethod]
        [TestCategory("EntityFR")]
        public void e_Update_Contact_Test()
        {
            //Arrange:
            int id = 1;
            Contact c = dao.GetById(id);
            c.Name = "new name";

            //Act
            dao.Update(c);
            Contact updatedContact = dao.GetById(id);

            //Assert
            Assert.AreEqual("new name", updatedContact.Name);


        }

        [TestMethod]
        [TestCategory("EntityFR")]
        [ExpectedException(typeof (Exception))]
        public void f_Update_IdNotExist_ReturnException()
        {
            //Arrange:
            int id = 1500;
            Contact c = dao.GetById(id);
            c.Name = "new name";

            //Act
            dao.Update(c);

        }

        [TestMethod]
        [TestCategory("EntityFR")]
        public void b_GetAll_Test()
        {
            Assert.AreEqual(1, dao.GetAll().Count);
        }

        [TestMethod]
        [TestCategory("EntityFR")]
        public void g_Delete_Contact_Test()
        {
            //Arrange:
            int id = 1;
            int tailleAvantSuppression = dao.GetAll().Count;
            //Act
            dao.Delete(id);

            int tailleApresSuppression = dao.GetAll().Count;

            //Assert
            Assert.AreEqual(tailleApresSuppression, tailleAvantSuppression - 1);


        }

        [TestMethod]
        [TestCategory("EntityFR")]
        [ExpectedException (typeof (Exception))]
        public void h_Delete_IdNotExist_ReturnException()
        {
            //Arrange:
            int id = 2500;
            
            //Act
            dao.Delete(id);
        }
    }
}
