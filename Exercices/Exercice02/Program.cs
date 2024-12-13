namespace Exercice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez-moi un nombre");
            string? UserAnswer = Console.ReadLine();
            int User;
            bool ch_converted = int.TryParse(UserAnswer, out User);
            //int User = int.Parse(UserAnswer);
            
            //if (ch_converted == false)
            if (!ch_converted)
            {
                Console.WriteLine("Ceci n'est pas un nombre entier...");

            }
            else
            {
                int Moitie = User / 2;
                if (Moitie * 2 == User)
                {
                    Console.WriteLine("Le nombre est pair");
                }
                else
                {
                    Console.WriteLine("le nombre est impair");
                }
            }
        }
    }
}
