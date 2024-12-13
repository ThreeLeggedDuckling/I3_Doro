namespace Exercice15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Correction

            Dictionary<string, string> choices = new Dictionary<string, string>();

            choices.Add("papier", "ciseaux");
            choices.Add("ciseau", "pierre");
            choices.Add("pierre", "papier");

            Random RNG = new Random();
           

            string userChoice;

            do {
                Console.WriteLine("Choisissez une valeur entre:");
                Console.WriteLine("Pierre - Papier - Ciseaux");
                Console.WriteLine("Pour(Q)uitter");
                int computerChioce = RNG.Next(3);
                string cpuChoice = choices.Keys.ToArray()[computerChioce];
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == cpuChoice.ToLower())
                {
                    Console.WriteLine("égalité");
                }
                else if (choices[userChoice] == cpuChoice)
                {
                    Console.WriteLine("vous avez perdu");
                }
                else if (userChoice!= "q")
                {
                    Console.WriteLine("vous avez gagné");
                }


            } while (userChoice !="q");

            /////////////////////////////Exercice du Jeu Pierre, Papier, Ciseaux
            ///


            Console.WriteLine("jouons au jeu du Pierre, papier , ciseaux: quel est ton choix?");
            string userAnswer = Console.ReadLine().ToLower();

            Dictionary<int, string> jeu = new Dictionary<int, string>();
            jeu.Add(1, "Pierre");
            jeu.Add(2, "Papier");
            jeu.Add(3, "Ciseau");
            //Random RNG = new Random();

            int ordi = RNG.Next(1, 3);

            Console.WriteLine($"reponse jeu:{jeu[ordi]}");

            if (userAnswer == "pierre" && ordi == 2 || userAnswer == "ciseau" && ordi == 1 || userAnswer == "papier" && ordi == 3)
            {
                Console.WriteLine("Tu as perdu");
            }
            else if (userAnswer == jeu[ordi].ToString())
            {
                Console.WriteLine("égalité");
            }
            else
            {
                Console.WriteLine("Tu as gagné");
            }



        }




    }
}
