using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataDriverDevelopement
{
    public class Employe
    {
        public string Name { get; set; }
        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            {
                //Expression régulière: permet de définir un pattern (un format de données) à respecter
                /*
                 * Identifiant national:
                 * doit contenir 9 caractères max
                 * les 2 premiers caractères sont des lettres
                 * les six caractères suivants sont des chiffres
                 * le dernier caractère est soit: A, B, C, D - a,b,c,d
                 * Premier caractère ne doit pas être D, F, I, O, Q, U, V
                 * Second caractère ne doit pas être D, F, I, O, Q, U, V
                 * "^[A-CEGHJ-NPR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[a-dA-d]{1}$"
                 */

                Regex regTelephone = new Regex("^[0-9]{10-13}$");

                //paris75@dawan.fr
                Regex regEmail = new Regex(@"^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,20}\.[a-zA-Z]{2,5}$");
                Match match = regEmail.Match(value);
                if (match.Success)
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Adresse email non valide");
                }
            }
        }
    }
}
