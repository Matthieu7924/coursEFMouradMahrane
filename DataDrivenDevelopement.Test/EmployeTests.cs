using DataDriverDevelopement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataDrivenDevelopement.Test
{
    [TestClass]
    public class EmployeTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
            "data source=(localdb)\\MSSQLLocalDB;initial catalog = datadriven; integrated security = true",
            "Employe", DataAccessMethod.Sequential
            )]
        [TestCategory("Data Driven: database")]
        public void DataDriven_Db_Test()
        {
            Employe employe = new Employe();
            employe.Name = TestContext.DataRow["Name"].ToString();
            employe.Email = TestContext.DataRow["Email"].ToString();

            Assert.IsNotNull(employe.Name);
            Assert.IsNotNull(employe.Email);

        }
    }
}
