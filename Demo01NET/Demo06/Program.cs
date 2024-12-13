using Demo06.Models;

namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal(); // pas assez d'info pour l'instancier.
            List<Animal> foyer = new List<Animal>();
            foyer.Add(new Souris() { Nom ="Jerry"});
            foyer.Add(new Chat() { Nom = "Tom" });
            foyer.Add(new Tigre() { Nom ="Tony"});

            foreach (Animal a in foyer)
            {
                a.Crier();
            }


        }
    }
}
