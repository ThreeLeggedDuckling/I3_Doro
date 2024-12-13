using System.Collections.Specialized;
using System.Threading.Channels;

namespace Exercice07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ordi = new Random(); 

            int reponse = ordi.Next(1,101);
            Console.WriteLine("entrez un nombre entre 1 et 100");
            string? Usernbre = Console.ReadLine();
            bool converted=int.TryParse(Usernbre, out int User);
            int essai = 1;
           
                while (User != reponse)
                {
                    if (!converted && User < 100)
                    {
                        Console.WriteLine("attention on vous demande  un nombre entre 1 et 100");
                        Usernbre = Console.ReadLine();
                        converted = int.TryParse(Usernbre, out User);

                    }

                    else if (User > reponse)
                    {
                        Console.WriteLine("le nombre est plus plus petit");
                    }
                    else
                    {
                        Console.WriteLine("le nombre est plus grand");
                    }
                        Console.WriteLine("essaie encore: ");
                        Usernbre = Console.ReadLine();
                        int.TryParse(Usernbre, out User);
                        essai ++;
                }
                Console.WriteLine($"Bravo! Vous avez fait {essai} tentatives");



        }

        //        Correction

//        const int MINVAL = 1;
//        const int MAXVAL = 100;
//        Random RNG = new Random();

//        int cpuNumber = RNG.Next(MINVAL, MAXVAL);
//        Console.WriteLine( "BIENVENUE DANS LE JEU");
//        int player Number;
//        do
//        {
//          Console.WritLine("veuillez entre un nombre entre 1 et 100);
//        }while (!int.TryParse(Console.Readline(), out playerNumber)|| playerNumber<1 ||playerNumber>100);

//        int triesCount = 1;
//        while (playerNumber != cpuNumber)
//        {
//        if (playerNumber >cpuNumber){ Console.WriteLine("c'est moins!")
//        else{ Console.WriteLine("c'est plus!")
//        }
//do
//{
//    Console.Writline("veuillez entre un nombre entre 1 et 100)
//        }While(!int.TryPArse(Console.Readline(), out playerNumber) || playerNumber < 1 || playerNumber > 100);
//Console.WriteLine("Felicitation ! vous avez trouvé la solution en {triesCount} essai{((triesCount >1)? "s":"")}

    }
}
