using Demo11.models;

namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un premier nombre: ");
            double nombre1= double.Parse(Console.ReadLine());
            Console.WriteLine("veuillez introduire un second nombre: ");
            double nombre2= double.Parse(Console.ReadLine());
            Console.WriteLine($"Le quotient de {nombre1} par {nombre2} vaut {Mathematique.Division(nombre1, nombre2)}");

            //On peut aussi faire le tru catch ici plutot que dans la class en cas de besoin

            Console.WriteLine("Calculons une moyenne des valeurs: ");

            int[] nbs = null; // =new int[0]


            //Moyenne peut poser deux souci un tableau vide ou un tableau avec du null


            try
            {
                Console.WriteLine($"la moyenne est de {Mathematique.Moyenne(nbs)} ");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("il n'y a pas e vlaeur a traitée.");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Le tableau est vide...");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Cette exception est l'exception dite de base pour gerer des eventuelles exeptions auquel on a pas pensé.");
                Console.WriteLine(ex.Message);
            }

            //Finally c'est vraiment pour pouvoir mettre une derniere "ligne" apres le try catch qu'il passe par un catch ou pas.


        }
    }
}
