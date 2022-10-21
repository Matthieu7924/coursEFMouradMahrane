using EntityFR.DAO;
using EntityFR.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EntityFR.Tests.IntegrationTests
{
    [TestClass]
    public class ContactServiceIntegrationTests
    {
        ContactService service;
        ContactDAO dao;

        [TestInitialize]
        public void Setup()
        {
            dao = new ContactDAO();
            service = new ContactService(dao);
        }

        [TestMethod]
        [TestCategory("Entity FR Integrations Tests")]
        public void Insert_Test()
        {
            Contact contact = new Contact() { Id = 1, Name = "test" };
            service.Insert(contact);
            Assert.AreEqual(1, service.GetAll().Count);
        }

        [TestMethod]
        [TestCategory("Entity FR Integrations Tests")]
        public void GetAll_Test()
        {
           Assert.AreEqual(1, service.GetAll().Count);
        }


        [TestMethod]
        [TestCategory("Entity FR Integrations Tests")]
        public void GetById_Test()
        {
            int id = 2;
            Contact c = service.GetById(id);
            Assert.IsNotNull(c);
        }

        [TestMethod]
        [TestCategory("Entity FR Integrations Tests")]
        public void Update_Test()
        {
            int id = 2;
            Contact c = service.GetById(id);
            c.Name = "new name";
            service.Update(c);
            Contact newContact = service.GetById(id);
            Assert.AreEqual("new name", newContact.Name);
        }

        [TestMethod]
        [TestCategory("Entity FR Integrations Tests")]
        public void Delete_Test()
        {
            int tailleAvantSuppression = service.GetAll().Count;
            int id = 2;
            service.Delete(id);
            int tailleApresSuppression = service.GetAll().Count;
            Assert.AreEqual(tailleApresSuppression, tailleAvantSuppression - 1);
        }
    }
}
