using Encapsulation;

namespace Demo01NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login user1 = new Login()
            {
                Email = "samuel.legrain@bstorm.be"
            };

            user1.Password= "Test1234=";

            Console.WriteLine($"Votre email est {user1.Email}");
            string inputEmail, inputPassword;
            do
            {
                Console.WriteLine("veuillez encoder votre email: ");
                inputEmail = Console.ReadLine();
                Console.WriteLine("veuillez encoder votre mot de passe");
                inputPassword = Console.ReadLine();

            }while (!user1.CheckIdentity(inputEmail, inputPassword));   
        }
    }
}
