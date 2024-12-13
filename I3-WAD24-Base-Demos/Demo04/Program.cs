namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez nous indiquer votre année de naissance: ");
            string userInput = Console.ReadLine();
            int userBirthYear;
            //bool isConverted = int.TryParse(userInput, out userBirthYear);
            //if (isConverted)
            if(int.TryParse(userInput,out userBirthYear))
            {
                int yearsOld = DateTime.Now.Year - userBirthYear;
                if (yearsOld >= 18)
                {
                    Console.WriteLine("Veuillez indiquer votre pays de residence: ");
                    string country = Console.ReadLine();

                    //Version Switch

                    switch (country.ToLower())
                    {
                        case "belgique":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale , une fois!");
                            break;
                        case "france":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale , cocorico");
                            break;
                        case "suisse":
                            Console.WriteLine("Bienvenueeeeuuuh sur le siteeeeuuuh de la loterie nationaleeeeuuuh !");
                            break;
                        case "canada":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale , tabernac!");
                            break;
                        default:
                            Console.WriteLine("Essayer un autre pays...celui la ne va pas ");
                            break;  
                    }
                    

                    //Console.WriteLine("Bienvenue sur le site de loterie");
                }
                else
                {
                    Console.WriteLine($"Reviens  dans {18 - yearsOld} ! ");
                }
            }
            else
            {
                Console.WriteLine("Entree invalide...");
            }
        }
    }
}

//if (country.ToLower() == "belgique")
//{
//    Console.WriteLine("Bienvenue sur le site de la loterie nationale , une fois!");

//}
//else if (country.ToLower() == "france")
//{
//    Console.WriteLine("Bienvenue sur le site de la loterie nationale , cocoricco!");
//}
//else if (country.ToLower() == "suisse")
//{
//    Console.WriteLine("Bienvenueeeeuuuh sur le siteeeeuuuh de la loterie nationaleeeeuuuh !");
//}
//else if (country.ToLower() == "canada")
//{
//    Console.WriteLine("Bienvenue sur le site de la loterie nationale , tabernac!");
//}
//else
//{
//    Console.WriteLine("Malheureusement, vous n'êtes pas né du bon côté de la frontière...");
//}
