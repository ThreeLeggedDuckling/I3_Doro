namespace Exercice01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Donnez-moi un nombre");
            string? UserAnswer1 = Console.ReadLine();
            int User1 = int.Parse(UserAnswer1);
            Console.WriteLine("Donnez-moi un autre nombre? ");
            string? UserAnswer2 = Console.ReadLine();
            int User2 = int.Parse(UserAnswer2);

            //On peut mettre le Console.Readline directement dans la parenthèze au lieu de passer par la variable UserAnswer ici.


            Console.WriteLine($"{User1}+{User2} = ");
            int Total = User1 + User2;  
            Console.WriteLine(Total);

            //Console.Clear();
            Console.WriteLine("Donnez-moi un chiffre: ");
            string? Chiffre1 = Console.ReadLine();
            int Ch1;
            bool ch1_converted = int.TryParse(Chiffre1, out Ch1);

            Console.WriteLine("Donnez moi un autre chiffre: ");
            string? Chiffre2 = Console.ReadLine();
            int Ch2;
            bool ch2_converted = int.TryParse(Chiffre2, out Ch2);

            //On peut raccourcir le code : bool ch2_converted = int.TryParse(Console.ReadLine(), out int Ch2);
            //le readline et la declaration de variable est directement placee dans le tryparse
            //on peut aussi ne pas declarée de bool ch2_converted, si on a pas besoin du resultat du TryPArse

            Console.WriteLine($"{Chiffre1}+{Chiffre2} = ");

            int Total2 = Ch1 + Ch2;
            Console.WriteLine(Total2);




        }
    }
}
