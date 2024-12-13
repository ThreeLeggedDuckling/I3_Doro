using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Models
{
    internal class Bateau : IBateau , ICouler
    {
        public string Matricule { get; set; }

        public bool EstCoule { get; private set; }

        public  void Naviguer() //element de l'interface Doit etre public !
        {
            Console.WriteLine(  "Je navigue sur mon bateau ");
        }

        public Bateau(string matricule) 
        {
            Matricule = matricule;
            EstCoule = false;
        }

        public void Couler()
        {
            if (!EstCoule) 
            {
                Console.WriteLine($"JE coule!");
                EstCoule = true;
            }
        }


    }
}
