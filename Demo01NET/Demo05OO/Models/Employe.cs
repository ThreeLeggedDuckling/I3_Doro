using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05OO.Models
{
    public class Employe : Personne
    {
        public string Departement { get; set; }
        public bool EstOccupe { get; set; }

        public Employe(string firstName, string lastName, DateTime birthDate, string departement) : base(firstName, lastName, birthDate)
        {
            Departement = departement;
            EstOccupe = false;
        }

        public void Travailler()
        {
            EstOccupe = true;
        }


        //possiblité de faire plusieurs override sur la meme methode;
        public override string SePresenter() 
        {
            //return base.SePresenter();
            return $"Voici {FirstName}, il travaille pour le departement {Departement} ";
        }

        public override string ToString()
        {
            return $"Employé : {base.ToString()}";
        }

        //Dissimulation de methode a l'aide de mot clé "new"

        public new string SePresenter2()
        {
            return $"Voici {FirstName}, il travaille pour le departement {Departement} ";
        }


    }
}
