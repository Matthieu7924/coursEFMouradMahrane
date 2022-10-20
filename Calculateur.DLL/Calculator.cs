using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur.DLL
{
    public class Calculator
    {
        public static int Division(int numerateur, int denominateur)
        {
            if (numerateur == 0)
            {
                throw new DivideByZeroException("Dénominateur ne peu être négatif......");
            }
            return numerateur / denominateur;
        }

        //Méthode static privée
        /*
         * 2 options possibles:
         * 1- Utiliser la méthode privée dans une méthode publique, et tester la méthode publique
         * 2- Tester directement la méthode privée
         */

        private static bool IsPositif(int number)
        {
            return number > 0;
        }

        public static int Add(int a, int b)
        {
            if (IsPositif(a) && IsPositif(b))
            {
                return a + b;
            }
            else
            {
                throw new ArgumentException("Les 2 params doivent être positifs");
            }
        }

        private bool IsNegatif(int a)
        {
            return a < 0;
        }

        //Exos:
        //méthode qui en param un chaine et qui renvoie le nbre de char de la chaine

        public static int nbChar(string chaine)
        {
            if (string.IsNullOrEmpty(chaine))
            {
                return 0;
            }
            return chaine.Length;
        }

        //méthode qui en param un chaine et qui renvoie le nbre de mots de la chaine

        public static int nbMots(string chaine)
        {
            if (string.IsNullOrEmpty(chaine))
            {
                return 0;
            }
            return chaine.Trim().Replace("  ", " ").Split(' ').Length;
        }
        //méthode qui en param un tableau et qui renvoie la somme des éléments du tableau d'entiers

        public static int SommeTab(int[] tab)
        {
            if (tab == null)
            {
                throw new ArgumentNullException("Tableau ne peut pas être nul....");
            }
            int somme = 0;
            foreach (var item in tab)
            {
                somme += item;
            }
            return somme;
        }
        

    }
}
