using Exercice.NET01.Classes;
using Exercice.NET01.Enums;
using EXOOrienteObjet01.Enums;
using EXOOrienteObjet01.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOrienteObjet01.Models
{
    public class CasePropriete : Case , IProprietaire
    {

        //Auto propriété seulement si aucune verification 
        public string Nom { get; private set; }
        public Couleurs couleur { get; private set; }
        public int Prix { get; private set; }
        public bool EstHypothequee { get; private set; }
        public Joueur Proprietaire { get; private set; }
        public CasePropriete( string nom, int prix, Couleurs _couleur): base(nom) { 
            //Nom = nom;
            Prix = prix;
            couleur = _couleur;

            // pas necessaire de mettre les affectations de EstHypohtequee et Proprietaire car elles ont deja les bonnes valeurs (demandées) par defaut.
        }

       
       

        private void Acheter(Joueur acheteur)//Achete si solde suffisant si oui paye et devient proprio
        {
            if (acheteur == null) return;   //Gestion d'exception
            if (Proprietaire == acheteur) return; //this n'est pas utile ici car propriétaire est dans cette class
            //Puisque une exception peut etre relevée par la méthode Joueur.Payer(int montant), il n'est plus nécessaire de controler le Solde

            //if(acheteur.Solde < Prix) throw new NotEnoughMoneyException(acheteur,Prix,this);

            try { 
                acheteur.Payer(Prix);
                }
            catch(NotEnoughMoneyException ex) 
            {
                throw new NotEnoughMoneyException(ex.Payeur,ex.Montant,this);
            }
            Proprietaire = acheteur;   
            acheteur.AjoutePropriete(this);


        }

        private void Sejourner(Joueur visiteur) 
        {
            if (visiteur == null) return;   //Gestion d'exception
            if (Proprietaire is null) return;
            if(Proprietaire ==  visiteur) return;   
            int montant = Prix / 4;
            visiteur.Payer(montant);
            Proprietaire.EtrePaye(montant);
        }

        public override void Activer(Joueur visiteur) 
        { 
         if(visiteur == null) return;
            if (Proprietaire == null)
            {
                try 
                { 
                    Acheter(visiteur);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        if (Proprietaire != visiteur) Sejourner(visiteur);
        //if (Proprietaire == visiteur) return; cette ligne n'est pas nécessaire.

        }

        public void Hypothequer()
        {
            if(EstHypothequee) return; //Gestion d'exception
            EstHypothequee =true;
            Proprietaire.EtrePaye(Prix / 2);

        }

        public void Deshypothequer()
        {
            if (!EstHypothequee) return; //Gestion d'exception
            EstHypothequee =false;

            //Proprietaire.Payer(Prix*10/6);
            Proprietaire.Payer((int) (Prix * 0.6));
            int currentSolde = Proprietaire.Solde;

            if (currentSolde != Proprietaire.Solde)
            {
                EstHypothequee = false;
            }


        }
    }
}
