namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////// essai du consoleKey////////
            ///Declarer en ConsoleKey exemple
            ///utiliser en ConsoleKey.(valeur)

            string[] menuOption = { "Femme", "Homme", "Autre" };
            int selectedPosition = 0;
            ConsoleKey userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Veuillez sélectionner votre genre: ");
                for (int i = 0; i < menuOption.Length; i++)
                {
                    string option = menuOption[i];
                    if (i == selectedPosition)
                    {
                        Console.WriteLine($"[{option}]");
                    }
                    else
                    {
                        Console.WriteLine(option);
                    }
                }
                Console.WriteLine(" (M)onter , (D)escendre , (V)alider");
                userChoice = Console.ReadKey(true).Key;
                if (userChoice == ConsoleKey.M || userChoice == ConsoleKey.UpArrow && selectedPosition > 0)
                {
                    selectedPosition--;
                }
                else if (userChoice == ConsoleKey.D || userChoice == ConsoleKey.DownArrow && selectedPosition < menuOption.Length - 1)
                {
                    selectedPosition++;
                } 
            } while (userChoice!= ConsoleKey.V && userChoice != ConsoleKey.Enter);
            Console.WriteLine($"Vous avez choisi {menuOption[selectedPosition]}");
        }
    }
}
