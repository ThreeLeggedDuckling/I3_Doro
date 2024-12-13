using Exercice.NET01.Classes;
using Exercice.NET01.Enums;
using EXOOrienteObjet01.Enums;
using EXOOrienteObjet01.Models;

namespace Exercice.NET01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* TEST DU DE
            De.valeurMin = 1;
            De.valeurMax = 6;
            int[] result = De.Lancer(2);
            Console.WriteLine($"Premier dé: {result[0]}\n Second dé : {result[1]}");
            */

            /*Test class joueur et test class casepropriete

            //Joueur j1 = new Joueur("Samuel", Pions.Dino);

            //Console.WriteLine($"{j1.Nom} c'est votre tour ! Bougez le pion {j1.Pion} de la case {j1.Position}");

            //if (j1.Avancer())
            //{
            //    Console.WriteLine($" Bravo {j1.Nom}! Vous avez fait un double!");
            //}

            //Console.WriteLine($"{j1.Nom} vous êtes à présent sur la case {j1.Position}!");



            //CasePropriete i3Patio = new CasePropriete("Patio Interface3", 20, Couleurs.Violet);

            //Console.WriteLine($"");
            //Console.WriteLine(i3Patio.Nom);
            //Console.WriteLine($"Couleur : { i3Patio.couleur}");
            //Console.WriteLine( $" Coutant : {i3Patio.Prix}");
            //if (i3Patio.EstHypothequee ) Console.WriteLine("Ce terrain est hypotèqué ...");
            //else Console.WriteLine( "Ce terrain n'est pas hypothéqué");

            //if (i3Patio.Proprietaire is null) Console.WriteLine(" ce terrain est en vente !");
            //else Console.WriteLine($" Ce terrain appartient à {i3Patio.Proprietaire.Nom}");

            //Console.WriteLine( $"{j1.Nom} Vous etes a present sur la case {j1.Position}");

            //i3Patio.Acheter(j1);

            //Console.WriteLine("ce qu'il se passe apres achat : ");

            //Console.WriteLine(i3Patio.Nom);
            //Console.WriteLine($"Couleur : {i3Patio.couleur}");
            //Console.WriteLine($" Coutant : {i3Patio.Prix}");
            //if (i3Patio.EstHypothequee) Console.WriteLine("Ce terrain est hypotèqué ...");
            //else Console.WriteLine("Ce terrain n'est pas hypothéqué");
            //if (i3Patio.Proprietaire is null) Console.WriteLine(" ce terrain est en vente !");
            //else Console.WriteLine($" Ce terrain appartient à {i3Patio.Proprietaire.Nom}");
            //Console.WriteLine($"{j1.Nom} Vous etes a present sur la case {j1.Position}");

            //Console.WriteLine($"Votre Solde est de {j1.Solde}");
            //Console.WriteLine($"Vos propriétés: ");
            //foreach ( CasePropriete prop in j1.Proprietes) {
            //    Console.WriteLine($" {prop.Nom} de couleur {prop.couleur}");
            //        };

            */


            /*TEST AVANT LA NOTION ABSTRACT

            //Joueur joueurCourant = monopolyI3[Pions.Chapeau];
            //Console.WriteLine($" c'est au tour de {joueurCourant.Pion} ({joueurCourant.Nom})");

            //joueurCourant.Avancer();

            //Console.WriteLine($" {joueurCourant.Nom}: avancer à la case {joueurCourant.Position}");
            //Case caseJoueur = monopolyI3[joueurCourant.Position];
            //Console.WriteLine($" Bienvenue sur la case {caseJoueur.Nom}");

            //caseJoueur.Acheter(joueurCourant);
            //if (caseJoueur is CasePropriete)
            //{
            //    CasePropriete propriete = (CasePropriete)caseJoueur;
            //    CasePropriete[] proprietesJoueur = joueurCourant + propriete;
            //    Console.WriteLine($" {joueurCourant.Nom} : votre solde est de {joueurCourant.Solde}");
            //}

            //if (caseJoueur is CasePropriete propriete)
            //{
            //    CasePropriete[] proprietesJoueur = joueurCourant + propriete;
            //    Console.WriteLine($" {joueurCourant.Nom} : votre solde est de {joueurCourant.Solde}");
            //}
            */



            /*ESSAI SURCHARGE OPERATEUR (VERIF)

            //joueurCourant = joueurCourant + 200;


            // Test Case et Case Propriété

            //Case caseDepart = new Case("Case depart");
            //CasePropriete propriete1 = new CasePropriete("Propriete 1", 20, Couleurs.BleuCiel);

            //caseDepart.AjouterVisiteur(joueurCourant);
            //caseDepart.AjouterVisiteur(monopolyI3[Pions.Dino]);

            //Console.WriteLine($"Les joueurs présents sur {caseDepart.Nom} sont :");
            //foreach (Joueur visiteur in caseDepart.Visiteurs)
            //{
            //    Console.WriteLine($"\t- {visiteur.Nom} ({visiteur.Pion})");
            //}

            //caseDepart.RetirerVisiteur(joueurCourant);
            //propriete1.AjouterVisiteur(joueurCourant);

            //Console.WriteLine($"Les joueurs présents sur {propriete1.Nom} sont :");
            //foreach (Joueur visiteur in propriete1.Visiteurs)
            //{
            //    Console.WriteLine($"\t- {visiteur.Nom} ({visiteur.Pion})");
            //}

            */


            jeu monopolyI3 = new jeu(
                [
                new CasePropriete("Patio", 200, Couleurs.Marron),
                new CasePropriete("RDC Bat.G.", 100, Couleurs.Marron),
                new CasePropriete("Ascensseur", 50, Couleurs.Marron),
                new CasePropriete("1er etage", 45, Couleurs.Bleu),
                new CasePropriete("Conference RDC", 250, Couleurs.BleuCiel),
                new CasePropriete("Classe Game", 60, Couleurs.BleuCiel),
                new CasePropriete("Classe WAD", 30000, Couleurs.Violet),
                new CasePropriete("Classe WEB", 30, Couleurs.Violet),
                new CasePropriete("Classe UI", 31, Couleurs.Vert),
                new CasePropriete("Secretariat", 40, Couleurs.Vert),
                new CasePropriete("Patio", 150, Couleurs.Bleu),
                ]);

            monopolyI3.AjouterJoueur("Marwa", Pions.Dino);
            monopolyI3.AjouterJoueur("Dorothée", Pions.Voiture);
            //monopolyI3.AjouterJoueur("Leslie", Pions.Chien);
            //monopolyI3.AjouterJoueur("Melusine", Pions.DeACoudre);
            /*monopolyI3.AjouterJoueur("Jenny", Pions.Chaussure);
            //monopolyI3.AjouterJoueur("Emilie", Pions.Cuirasse);
            //monopolyI3.AjouterJoueur("Debby", Pions.Dino);
            //monopolyI3.AjouterJoueur("Amalia", Pions.Chien);
            //monopolyI3.AjouterJoueur("Charifa", Pions.Chapeau);
            //monopolyI3.AjouterJoueur("Jessica", Pions.Fer);
            //monopolyI3.AjouterJoueur("Anais", Pions.Brouette);*/


            int nbJoueursSolvable = 0;
            foreach (Joueur j in monopolyI3.Joueurs)
            {
                if(j.Solde >0) nbJoueursSolvable++;
            }

            int indexJoueur = 0;
            while (nbJoueursSolvable > 1)
            {
                Joueur joueurcourant = monopolyI3.Joueurs[indexJoueur % monopolyI3.Joueurs.Length];
                Console.WriteLine($" Au tour de {joueurcourant.Nom}");
                if (joueurcourant.Proprietes.Length > 0)
                {
                    int choix;
                    do
                    {
                        Console.WriteLine($"Voulez vous effectuer une action sur l'une de vos {joueurcourant.Proprietes.Length} Propriétés ?");

                        for (int i = 0; i < joueurcourant.Proprietes.Length; i++)
                        {
                            CasePropriete prop = joueurcourant.Proprietes[i];
                            if (prop.EstHypothequee)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine($" -{i + 1} {prop.Nom} ({prop.couleur}) {prop.Prix}€ Monopoly");
                            Console.ResetColor();
                        }
                        do
                        {
                            Console.WriteLine("Entrez le numéro de la propriété pour changer son statut d'hypothèque ou alors entre 0 pour jouer votre tour. "); 
                        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > joueurcourant.Proprietes.Length); 

                        if (choix != 0) 
                        {
                                IProprietaire propchoisie = joueurcourant.Proprietes[choix - 1];
                                if (propchoisie.EstHypothequee) propchoisie.Deshypothequer();
                                else propchoisie.Hypothequer();

                        }
                    } while (choix != 0);
                }
                bool rejoue;
                do
                {
                    
                    Case caseCourante = monopolyI3[joueurcourant.Position];
                    Console.WriteLine($"Il est actuellement sur la case {monopolyI3[joueurcourant.Position].Nom}");
                    caseCourante.RetirerVisiteur(joueurcourant);
                    rejoue = joueurcourant.Avancer();
                    Console.WriteLine($" il se deplace sur la case {caseCourante.Nom}");
                    caseCourante.AjouterVisiteur(joueurcourant);
                    try
                    {
                        caseCourante.Activer(joueurcourant);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Console.Beep(440, 2000);
                    }
                    Console.WriteLine($" Le nombre de propriété de {joueurcourant.Nom} est de {joueurcourant.Proprietes.Length}");
                    Console.WriteLine($" Son solde actuel est de {joueurcourant.Solde} $Monopoly"); 
                } while (rejoue);

                nbJoueursSolvable = 0;
                foreach (Joueur j in monopolyI3.Joueurs)
                {
                    if (j.Solde > 0) nbJoueursSolvable++;
                }

              indexJoueur++; 

            }
        }
    }
}
