using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.Models
{
    internal class TalkieWalkie : IDisposable //EXEMPLE DE IDISPOSABLE (Obligation de la methode)
    {
        public string UserName { get; set; }    

        public TalkieWalkie(string userNAme) 
        {
            UserName = userNAme;
        }

        public void EmettreMessage(string message) 
        {
            Console.WriteLine($" {UserName} {DateTime.Now.ToShortTimeString()} : {message}");
            Console.WriteLine("A vous! ");
        }

        public void Dispose()
        {
            Console.WriteLine($"C'était {UserName} : Terminé ! {DateTime.Now.ToShortTimeString()}");
        }
        /*EXEMPLE DE DISTRUCTEUR (A NE PAS UTILISER ..)*/

        //~TalkieWalkie()
    }
}
