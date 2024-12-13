using Exercice.NET01.Classes;
using Exercice.NET01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOrienteObjet01.Models
{
   public class jeu 
    {

		//Variables
		private List<Joueur> _joueurs;
		private List<Case> _plateau;

		


		//Proprietes
		public Joueur[] Joueurs
		{
			get {

				return _joueurs.ToArray();
			}
			
		}

        public Case[] Plateau
        {
            get
            {

                return _plateau.ToArray();
            }

        }

		public Case this[int index] 
		{
			get
			{
				index = index % _plateau.Count; // faire le tour du plateau et + 
				return _plateau[index];
			}
		}

		public Joueur? this[Pions pion] 
		{
			get
			{
				foreach (Joueur joueur in _joueurs) //Parcours de la liste joueurs
				{
					if (joueur.Pion == pion) return joueur;
				}
				return null;
			}
		}

        public jeu(Case[] cases ) // liste des case pour initialiser le jeu
        {

			if( cases.Length <=0 ) return; //gerer a l'aide d'exception
			if ( cases is null ) return; //gerer a l'aide d'exception

            //tableau de case:
            _plateau = new List<Case>(cases);

			//initiatise propriété joueurs en une liste vide 
            _joueurs = new List<Joueur>();
        }


		//Methode
		public void AjouterJoueur(string nom, Pions pion) 
		{ 
			//verification du nom et du pion
			if (nom is null ) return; //gerer a l'aide d'exception
			if (this[pion] is not null) return;



			//ajout du joueur
            Joueur joueur = new Joueur(nom, pion);
			_joueurs.Add(joueur);


		}
    }
}
