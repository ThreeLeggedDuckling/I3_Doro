using Demo07.Models;

namespace Demo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateau b = new Bateau("la toison d'or");
            Canoe c = new Canoe();

            IBateau monBateau = b;
            IBateau monSecondBateau = c;

            List<IBateau> monPort = new List<IBateau>(); 
            
            monPort.Add(b);
            monPort.Add(c);

            Random rnd = new Random();
            IBateau choixBateau = monPort[rnd.Next(monPort.Count)];

            choixBateau.Naviguer();

            if (choixBateau is Bateau bateau) // si on recupere bateau on peut utliser les methodes de la class bateau
            {
                Console.WriteLine($"le nom du bateau est {bateau.Matricule}");
            }

            choixBateau.Couler();

            //on cree un lien entre IBateau et Icouler donc plus besoin de ce code 

            //if (choixBateau is ICouler epave) 
            //{
            //    epave.Couler();
            //}

            Voiture v = new Voiture("Ma Ferrari");
            VehiculeAmphibie va = new VehiculeAmphibie("Crocodile rouge");

            List<IVoiture>parking = new List<IVoiture>();

            parking.Add(v); //Ajoute la voiture 
            parking.Add(va); //ajoute le vehicule amphibie

            parking[1].Rouler(); //utilise le vehicule amphibie pour rouler

            monPort.Add((VehiculeAmphibie)parking[1]); //Ajouter le vehicule amphibie au port
            monPort[2].Naviguer(); //on peut utilliser le vehicule amphibie pour naviguer
        }
    }
}
