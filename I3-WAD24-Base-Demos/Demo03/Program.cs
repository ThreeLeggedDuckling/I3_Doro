namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString());
            Console.WriteLine(today.ToString("yyyy MMMM dd"));*/

            //avec Parse

            /*Console.WriteLine("Quel jour sommes nous?");
            string userAnswer = Console.ReadLine();

            int dayInMonth = int.Parse(userAnswer);
            Console.WriteLine($"Ok, il reste donc +/- {31 - dayInMonth} jours dans le mois");*/

            Console.WriteLine("Quel jour sommes-nous?");
            string userAnswer = Console.ReadLine();
            int dayInMonth;
            bool isConverted;

            isConverted = int.TryParse(userAnswer, out dayInMonth);

            Console.WriteLine($"Convertion réussié ? {isConverted}");
            Console.WriteLine($"Ok, il reste donc +/- {31 - dayInMonth} jours dans le mois"); 
        }
    }
}
