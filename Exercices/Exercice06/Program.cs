namespace Exercice06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //exercice3 demandez un nombre à l'utilisateur chaque ligne affiche un nombre d'astérisque correspondant au numero de la ligne si il demande 5 5 lignes avec1 puis2 puis3 *

            Console.WriteLine("Veuillez encoder un chiffre: ");


            string? Usernbre = Console.ReadLine();
            bool converted=int.TryParse(Usernbre, out int index);
            // ici on peut redemander a l'utilisateur si ce n'est pas un nombre...
            while (!converted)
            {
                Console.WriteLine("Veuillez encoder un chiffre: ");
                Usernbre = Console.ReadLine();
                converted = int.TryParse(Usernbre, out index);
            }

            int x = 0;
            string etoile = "❤️";
            while (x < index)
            {
                Console.WriteLine(etoile);
                etoile = etoile + " ❤ ";
                x++;
            }
        }
    }
}
