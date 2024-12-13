namespace Exercice08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("donne moi 10 nombres entiers :");
            string? Usernbre = Console.ReadLine();
            bool converted = int.TryParse(Usernbre, out int nbre1);

            while (!converted)
            {
                Console.WriteLine("donne moi 10 nombres entiers :");
                Usernbre = Console.ReadLine();
                converted = int.TryParse(Usernbre, out nbre1);
            }

            for (int i = 1; i < 10; i++)
            {

                Console.WriteLine("donne moi 10 nombres entiers :");
                Usernbre = Console.ReadLine();
                bool converted2 = int.TryParse(Usernbre, out int nbre);
                while (!converted2)
                {
                    Console.WriteLine("Donne moi 10 nombres entier: ");
                    Usernbre = Console.ReadLine();
                    converted = int.TryParse(Usernbre, out nbre);
                }
                if (nbre < nbre1)
                {
                    nbre1 = nbre;
                }
            }


            Console.WriteLine($"votre plus petit nombre entier :{nbre1}");

            //correction
            int nb;
            do
            {
                Console.WriteLine("Veuillez introduire un premier nombre: ");
            } while (!int.TryParse(Console.ReadLine(), out nb));

            int smallest = nb;

            for (int i = 1; i < 10; i++)
                do
                {
                    Console.WriteLine("Veuillez introduire un premier nombre: ");
                } while (!int.TryParse(Console.ReadLine(), out nb));

            if (nb > smallest)
            {
                smallest = nb;
            }
            Console.WriteLine($"LE plus petit nombre de la serie est {smallest}");
        }
    }
}
