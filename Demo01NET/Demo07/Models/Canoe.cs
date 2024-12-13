using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Models
{
    internal class Canoe : IBateau
    {
        public bool EstCoule { get; set; }

        public void Naviguer()
        {
            Console.WriteLine("Je navigue à bord de mon Canoë");
        }

        public void Navigator()
        {
        }

        public void Couler()
        {
            if (!EstCoule)
            {
                Console.WriteLine("Zuuuuut, une trou dans mon Canoë");
            }
        }
    }
}
