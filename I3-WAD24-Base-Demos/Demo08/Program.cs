namespace Demo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "Test1234=";
            int countdown = 3;
            string password;
            do
            {
                Console.WriteLine($"Veuillez introduire votre mot de passe: ({countdown}essais restant)");
                password = Console.ReadLine();
                countdown--;
            } while (password != PASSWORD && countdown > 0);
            //ici logiquement on fait un if car si le compte est fini mais que le mot de passe est incorrect il faut tout de meme bloquer pour la suite 
            if (password is PASSWORD) 
            {
                Console.WriteLine("Bienvenue");
            }
            else
            {
                Console.WriteLine("Compte Bloqué...");
            }
        }
    }
}
