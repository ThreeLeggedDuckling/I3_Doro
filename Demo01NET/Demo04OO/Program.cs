using Demo04OO.Models;

namespace Demo04OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingredient tartine = new Ingredient("Tartine", 100);
            Ingredient choco = new Ingredient("Pate a tartinée chocolatée",60);
            Recette tartineAuChoco = tartine + choco;


            Console.WriteLine($" total de valeur nutritive de {tartineAuChoco.ValeurNutritiveTotale}!");
            Console.WriteLine($" Si je prend une quantite de 3 {tartine.Nom} j'obtiens une valeur nutritive de {tartine*3}.");

            if (tartine == choco) //ici on compare les adresses memoires de tartine et de choco Mais ici ce sont deux instances différentes
            {
                Console.WriteLine("ici on compare tartine est choco : ici tartine vaut choco ");
            }

            Ingredient tartine2 = tartine;
            if (tartine2 == tartine)
            {
                Console.WriteLine($" ici tartine2 et bien egal a tartine dans ce cas. les adresses memoires sont les même.");
            }

            Ingredient tartine3 = new Ingredient("Tartine",100);
            if (tartine3 == tartine) 
            {
                Console.WriteLine($"ici avec la surcharge d'operateur du == cela s'affiche sinon non. il n e verifie plus l'adresse memoire mais bien les données");
            }
        }
    }
}
