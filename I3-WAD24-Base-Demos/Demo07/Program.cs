namespace Demo07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //VERSION WHILE
            //    Console.WriteLine("Veuillez introduire votre BBAN (12chiffres) :");
            //    string userInput=Console.ReadLine(); //initialise une variable
            //    while (userInput.Length != 12 || !long.TryParse(userInput, out _)) //Condition
            //    {
            //        Console.WriteLine("Entree invalide");
            //        userInput = Console.ReadLine(); //Modification (itération)
            //    };
            //    Console.WriteLine("Entree valide");

            //VERSION DO.WHILE
            string message = "Veuillez introduire votre BBAN (12chiffres) :";
            
            string userInput; //Declaration (attention pas initialisation)
            do
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine(); //initialisation (1ere fois et modif pour la suite)
                message = "Entrée invalide";
            }
            while (userInput.Length != 12 || !long.TryParse(userInput, out _));
            Console.WriteLine("Entrée Valide");

        }
    }
}
