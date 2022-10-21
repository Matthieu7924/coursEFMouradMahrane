using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertClasse
{
    public class Employe : object
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employe employe &&
                   Name == employe.Name;
        }
    }

    public class Technicien : Employe
    {

    }
}
