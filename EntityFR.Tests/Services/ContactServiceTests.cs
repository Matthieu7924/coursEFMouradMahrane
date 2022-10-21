using EntityFR.DAO;
using EntityFR.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;


namespace EntityFR.Tests.Services
    /*
     * Le service dépend complètement du dao. Pour fournir des tests pour cette couche (service)
     * sans utiliser le dao, on doit le mocker (le simuler) - Java(mockito) - moq (.net)
     * Pour mocker des objets on utilise des framework de Mocking
     * 
     * 
     */
{
    [TestClass]
    public class ContactServiceTests
    {
        ContactService service;
        Mock<IContact> mockDAO = new Mock<IContact>();

        [TestInitialize]
        public void Setup()
        {
            service = new ContactService(mockDAO.Object);
        }

        [TestMethod]
        [TestCategory("EntityFR service")]
        public void GetAll_Test()
        {
            //Arrange:
            List<Contact> lst = new List<Contact>();
            lst.Add(new Contact());
            lst.Add(new Contact());
            mockDAO.Setup(a => a.GetAll()).Returns(lst);

            //Act:
            var list = service.GetAll();

            //Assert
            Assert.AreEqual(2, list.Count);
        }


        [TestMethod]
        [TestCategory("EntityFR service")]
        public void GetById_Test()
        {
            //Arrange:
            Contact c = new Contact { Id = 1, Name = "dawan" };

            mockDAO.Setup(a => a.GetById(1)).Returns(c);

            //Act:
            var contact = service.GetById(1);

            //Assert
            Assert.AreEqual("dawan", contact.Name);
            Assert.AreEqual(1, contact.Id);
        }

        [TestMethod]
        [TestCategory("EntityFR service")]
        public void Insert_Test()
        {
            //Arrange:
            Contact c = new Contact { Id = 1, Name = "dawan" };

            mockDAO.Setup(a => a.Insert(c)).Callback(() => Console.WriteLine("Contact inséré"));

            //Act:
            service.Insert(c);

            
        }

        [TestMethod]
        [TestCategory("EntityFR service")]
        public void Update_Test()
        {
            //Arrange:
            Contact c = new Contact { Id = 1, Name = "dawan" };

            mockDAO.Setup(a => a.Update(c)).Callback(() => Console.WriteLine("Nom: " + c.Name));
            //Act
            c.Name = "new name";
            service.Update(c);

           
        }

        [TestMethod]
        [TestCategory("EntityFR service")]
        public void Delete_Test()
        {
            //Arrange:
            Contact c = new Contact { Id = 1, Name = "dawan" };

            mockDAO.Setup(a => a.Delete(c.Id)).Callback(() => Console.WriteLine("Contact supprimé...."));

            //Act:
           service.Delete(c.Id);

            
        }
    }
}
