using System.Threading.Channels;

namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agenda:");
            Dictionary<DateTime, string> agenda = new Dictionary<DateTime, string>();
            string choix = "";
            do
            {
                if (agenda.Count >0)
                {
                    foreach (KeyValuePair<DateTime, string>entree in agenda)
                    {
                        Console.WriteLine($"{entree.Key}\t:\t{entree.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("Pas encore de rendez-vous...");
                }
                Console.WriteLine("(A)Jouter - (Q)uitter");
                choix = Console.ReadLine().ToUpper();
                switch (choix)
                {
                    case "A":
                        Console.WriteLine("A quelle date ajoutez-vous ce RDV ?");
                        Console.WriteLine("quel jour?");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quel mois? ");
                        int month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quelle année? ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("quelle heure?");
                        int hour=int.Parse(Console.ReadLine());
                        Console.WriteLine("quelle minute?");
                        int minute=int.Parse(Console.ReadLine());
                        DateTime dateKey = new DateTime(year,month,day, hour, minute,0);
                        //Methode Contains Key permet de verifier que la cle n'est pas presente puisqu'une cle est UNIQUE Sinon ca crash
                        if (agenda.ContainsKey(dateKey))
                        {
                            Console.WriteLine($"Attention un autre rendez vous est deja prevu à cette date:");
                            Console.WriteLine(agenda[dateKey]);
                        }
                        else
                        {
                            Console.WriteLine("En quoi concerne le rendez-vous?");
                            string objet = Console.ReadLine();

                            agenda.Add(dateKey, objet);
                        }
                        
                        break;
                }
            }
            while (choix != "Q");

            Console.WriteLine("Merci d'avoir utiliser blablaAgenda");

















        }
    }
}
