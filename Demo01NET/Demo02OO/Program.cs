using Demo02OO.Models;

namespace Demo02OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animalDeCompagnie = new Animal("bugs");

            Console.WriteLine($" Voici les propriétés de notre animal : ");
            Console.WriteLine( $"Nom : {((animalDeCompagnie.Nom is null)? "NULL" : animalDeCompagnie.Nom)}");
            Console.WriteLine($" Point de vie: {animalDeCompagnie.PointDeVie}");
            Console.WriteLine($" Point de bonheur: {animalDeCompagnie.PointDeBonheur}");
            Console.WriteLine($"Liste de Jouets:");
            foreach (string jouet in animalDeCompagnie.Jouets)
            {
                Console.WriteLine($"\t- {jouet}");
            }

            // Si on lance ce code sans constructeur ca utilise des valeurs par defaut

            //resultat avec surcharge de constructeur  constructeur qui reconstruit tout , avec tous les paramètres

            Animal animalDeSauvegarde = new Animal("Bidule", 5, 0, ["balle","carotte kuin-kuin", "grelot", "bonbon"]);

            Console.WriteLine($" Voici les propriétés de votre animal apres votre sauvegarde : ");
            Console.WriteLine($"Nom : {((animalDeSauvegarde.Nom is null) ? "NULL" : animalDeSauvegarde.Nom)}");
            Console.WriteLine($" Point de vie: {animalDeSauvegarde.PointDeVie}");
            Console.WriteLine($" Point de bonheur: {animalDeSauvegarde.PointDeBonheur}");
            Console.WriteLine($"Liste de Jouets:");
            foreach (string jouet in animalDeSauvegarde.Jouets)
            {
                Console.WriteLine($"\t- {jouet}");
            }
        }
    }
}
