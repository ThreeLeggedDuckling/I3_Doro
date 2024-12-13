using System.Security.Cryptography;

namespace Exercice12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random RNG = new Random();
            const int SIZE = 7;

            int[] tab= new int[SIZE];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i]= RNG.Next(1,11);
            }


            Console.WriteLine("Tableau initial : ");
            foreach (int value in tab)
            {
                Console.WriteLine(value);
            }

            for (int i = 0; i < (tab.Length/2); i++)
            {
                int temp = tab[i];
                tab[i] = tab[tab.Length-1-i];
                tab[tab.Length-1-i] = temp;
            }


            Console.WriteLine("Tableau inversé: ");

            foreach (int item in tab)
            {
                Console.WriteLine(item);
            }










        }
    }
}
