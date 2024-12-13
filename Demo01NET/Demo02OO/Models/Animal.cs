using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OO.Models
{
    internal class Animal
    {

        public string Nom {  get; set; }
        public int PointDeVie { get; private set; }
        public int PointDeBonheur { get;private set; }
        private List<string> _jouets;

        //CReation du constructeur 


        //public Animal(string nom) 

        //{
        //    _jouets = new List<string>();
        //    PointDeVie = 10;
        //    PointDeBonheur = 3;
        //    Nom = nom;  
        //}

        //constructeur avec this:
        public Animal(string nom) : this(nom, 10, 3, new string[0])

        {
            //_jouets = new List<string>();
            //PointDeVie = 10;
            //PointDeBonheur = 3;
            //Nom = nom;
        }


        public Animal(string nom, int pv, int pb, string[] jouets) 
        {
             _jouets = new List<string>(jouets) ;
            PointDeBonheur = pb;
            PointDeVie= pv;
            Nom= nom;
        }


        public string[] Jouets {
            get 
            {
                return _jouets.ToArray(); // Mettre la liste en tableau pour plus de restrictions.
            }
        }

        public void Jouer(string jouet) 
        {
            if (jouet is null) return;
            if (_jouets.Contains(jouet)) PointDeBonheur++;
            else PointDeBonheur--;
        }

        public void OffrirJouet(string jouet) 
        {
            if (jouet is null) PointDeBonheur = 0;
            return;
            if (_jouets.Contains(jouet)) PointDeBonheur++;
            else {
                PointDeBonheur += 2;
                _jouets.Add(jouet); 
                    };
        }

        public void Manger()
        {
            PointDeVie++;
        }

        
    }
}
