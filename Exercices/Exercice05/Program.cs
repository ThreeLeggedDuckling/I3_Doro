namespace Exercice05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercice 1: table de 2 à l'aide d'une boucle (site les calculs avec les multiplicateurs de 1à 10)

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}*2={i*2}");
            }


            //exercice 2: à l'aide de deux boucles, afficher les tbles de multiplication de 1 à 9.
            //chaque table cite les calculs avec les multiplicateurs de 1à 10.


            for (int i = 1; i <= 9; i++) 
            {
                Console.WriteLine($"Table de {i}");
                for (int j  = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
            }

            
            

        }
    }
}
