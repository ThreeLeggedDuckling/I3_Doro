namespace Exercice11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

            int nbre;
            do
            {
                Console.WriteLine("Veuillez introduire le nombre de joueurs (max 10): ");
            } while (!int.TryParse(Console.ReadLine(), out nbre) || nbre < 0 || nbre > 10);

            int[] joueurs = new int[nbre];
            

            for (int i = 0; i < joueurs.Length; i++) 
            {
                Console.WriteLine($"Veuillez donner le score du Joueur {i+1}");
               joueurs[i]= int.Parse(Console.ReadLine());
            }

            int somme=0;
            
            for (int i = 0; i < joueurs.Length; i++)
            {
                somme= joueurs[i]+somme;
                
            }
            double moyenne=somme/nbre;

            Console.WriteLine($"Voici la moyenne des scores de vos joueurs: {moyenne}");












        }
    }
}
