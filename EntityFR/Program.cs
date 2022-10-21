using EntityFR.DAO;
using EntityFR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactService service = new ContactService(new ContactFichierDAO());

            service.Insert(new Contact());
        }
    }
}
