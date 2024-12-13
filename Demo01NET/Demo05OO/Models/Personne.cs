using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05OO.Models
{
    public class Personne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime BirthDate { get; set; }

        public Personne(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public virtual string SePresenter()
        {
            return $"Voici {FirstName} {LastName}, il est né le {BirthDate.ToShortDateString()}";
        }

        public override string ToString() //CHanger le comportement du ToString et fait une conversion 
        {
            return SePresenter();
         }
        public string SePresenter2()
        {
            return $"Voici {FirstName} {LastName}, il est né le {BirthDate.ToShortDateString()}";
        }




    }
}
