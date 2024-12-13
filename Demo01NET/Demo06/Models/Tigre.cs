using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Models
{

    //Lorsque on "bloque la class chat"
    public class Tigre : Animal
    {
        public override void Crier()
        {
            Console.WriteLine("Graouoowww");
            Console.WriteLine("Je suis un tigre");
        }
    }
}
