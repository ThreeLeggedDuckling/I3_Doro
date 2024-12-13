namespace Exercice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez-moi un nombre");
            string? UserAnswer = Console.ReadLine();
            int User1;
            bool ch1_converted = int.TryParse(UserAnswer, out User1);
            if (!ch1_converted)
            {
                Console.WriteLine($"{UserAnswer}n'est pas un nombre entier ! ");
            }
            else {
                Console.WriteLine("Donnez-moi un autre nombre");
                UserAnswer = Console.ReadLine();
                int User2;
                bool ch2_converted = int.TryParse(UserAnswer, out User2);
                if (!ch2_converted)
                {
                Console.WriteLine($"{UserAnswer}n'est pas un nombre entier !");
                }
                //   division de type int
                //else
                //{
                //    int resultat1 = User1 / User2;
                //    Console.WriteLine($"Ton calcul= {User1}/{User2}={resultat1}");
                //}
                //    modulo
                //else 
                //{ 
                //    int resultat2 = (User1 % User2);
                //    Console.WriteLine($" le modulo de ton calcul : {resultat2}");
                //}
                //      Division classique
                else
                {
                    float resultat3 = (float) User1 / User2;
                    Console.WriteLine($" Division de tes nombres : {resultat3}");
                }



        }
    }
}
