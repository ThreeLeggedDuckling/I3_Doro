using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice17
{
    public struct Address
    {
        public string street, number, zipCode, city, country;
    }
    public struct Person 
    {
        public string lastname, firstname;
        public DateTime? birthdate;
        public Address? address;
    }
}
