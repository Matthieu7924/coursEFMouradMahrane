using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssertClasse
{
    public class Employe
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employe employe &&
                   Name == employe.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
