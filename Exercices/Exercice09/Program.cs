namespace Exercice09
{
    internal class Program
    {
        static void Main(string[] args)

        {


            //Console.WriteLine("donne moi 1 nombre entier pour la repetition:");
            //string? Usernbre1 = Console.ReadLine();
            //bool converted = int.TryParse(Usernbre1, out int nbreRepetition);
            //while (!converted)
            //{
            //    Console.WriteLine("Donne moi 1 nombre entier: ");
            //    Usernbre1 = Console.ReadLine();
            //    converted = int.TryParse(Usernbre1, out nbreRepetition);
            //}
            //Console.WriteLine("donne moi 1 nombre entier pour le nombre de tiret :");
            //string? Usernbre2 = Console.ReadLine();
            //bool converted2 = int.TryParse(Usernbre2, out int nbreTiret);
            //while (!converted2)
            //{
            //    Console.WriteLine("Donne moi 3 nombres entier: ");
            //    Usernbre2 = Console.ReadLine();
            //    converted2 = int.TryParse(Usernbre2, out nbreTiret);
            //}
            //Console.WriteLine("donne moi 1 nombre entier pour le nombre d'espace :");
            //string? Usernbre3 = Console.ReadLine();
            //bool converted3 = int.TryParse(Usernbre3, out int nbreEspace);
            //while (!converted3)
            //{
            //    Console.WriteLine("Donne moi 3 nombres entier: ");
            //    Usernbre3 = Console.ReadLine();
            //    converted3 = int.TryParse(Usernbre3, out nbreEspace);
            //}

            //Correction

            int nbTiret;
            do
            {
                Console.WriteLine("Veuillez introduire le nombre de tiret: ");
            }while (!int.TryParse(Console.ReadLine(), out nbTiret)|| nbTiret<0);
            int nbEspace;
            do
            {
                Console.WriteLine("Veuillez introduire le nombre d espace: ");
            } while (!int.TryParse(Console.ReadLine(), out nbEspace) || nbEspace < 0);
            int nbRepetition;
            do
            {
                Console.WriteLine("Veuillez introduire le nombre de repetition: ");
            } while (!int.TryParse(Console.ReadLine(), out nbRepetition) || nbRepetition < 0);


            string tirets = "";
            string espaces = "";
            for (int i = 1; i <= nbTiret; i++)
            {
                tirets += "_";
            }
            for (int i = 1; i <= nbEspace; i++)
            {
                espaces += " ";
            }
            for(int i = 1;i <= nbRepetition; i++)
            {
                Console.WriteLine($"{espaces}{tirets}");
            }


        }

    }
}
