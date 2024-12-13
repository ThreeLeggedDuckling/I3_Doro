namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des présences: ");
            List<string> presence = new List<string>(); 
            string name = "";
            do
            {
                Console.WriteLine($"Veuillez introduire le nom d'un élève présent: ");
                Console.WriteLine($"Pour finalisez les présences, écrivez \"FIN\"");
                name=Console.ReadLine();
                if (!presence.Contains(name.ToUpper()))
                {
                    presence.Add(name.ToUpper());  
                }
                else 
                {
                    Console.WriteLine($"l'eleve {name} est deja present");
                }
                presence.Add( name );
            
            } while (name != "FIN");
            presence.Remove("FIN");

            while (presence.Count >0)
            {
                Console.WriteLine("Actuellement sont présents: ");
                int i = 0;
                foreach (string eleve in presence)
                {
                    Console.WriteLine($"\t-{++i}) {eleve}");
                }
                int choix;
                do
                {
                    Console.WriteLine($"Indiquer le numero d'un élève sortant : ");
                }
                while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > presence.Count);
                string elevePartant = presence[choix - 1];

                Console.WriteLine($" Etes vous sur de vouloir supprimer l'eleve = {elevePartant}? (Oui - Non)");
                if (Console.ReadLine().ToUpper() == "OUI")
                {
                    presence.Remove(elevePartant);
                } 
            }
            Console.WriteLine("Phrase finale");
            
        }
    }
}
