namespace Demo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayNames = 
                {
                "dimanche",
                "lundi",
                "mardi",
                "mercredi",
                "jeudi",
                "vendredi",
                "samedi",
                
                };
            //aussi declarable avec les []...
            Console.WriteLine($"Il y a {dayNames.Length} jours dans la semaine");

            foreach (string dayName in dayNames) 
            {
                Console.WriteLine($"-   {dayName}");
                //il va ecrire les noms des jours de la semaine les un apres les autres
            }
            //Console.WriteLine("En anglais, comment traduisez-vous: ");
            //for (int i = 0; i < dayNames.Length; i++)
            //{
            //    Console.WriteLine($"-    {dayNames[i]}");
            //    dayNames[i] = Console.ReadLine();
            //}
            Console.WriteLine($"Aujourd'hui nous sommes {dayNames[(int)DateTime.Now.DayOfWeek]} {DateTime.Now.ToString("dd MMMM yyyy")}");

        }


    }
}
