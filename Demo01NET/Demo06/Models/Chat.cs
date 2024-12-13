using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Models
{
    public sealed class Chat : Animal
    {

        public override void Crier()
        {
            Console.WriteLine("Miaou");
        }
    }
}
