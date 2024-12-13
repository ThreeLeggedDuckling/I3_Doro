using Exercice.NET01.Enums;
using EXOOrienteObjet01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXOOrienteObjet01.Exceptions;

namespace Exercice.NET01.Classes
{
    public class Joueur
    {
        private int _position;
        private List<CasePropriete> _propriete;
        public int Solde {  get; private set; }
       
        public string Nom { get; set; }
        public Pions Pion { get; set; }

        //Constructeur
        public Joueur( string nom, Pions pion )
        {
            Nom = nom;
            Pion = pion;    
            Solde = 1500;
            //Position = 0; d'office a zero par defaut
            _propriete = new List<CasePropriete>();
        }



        public int Position
        {
            get
            {
                return _position;
            }
            private set
            {
                _position = value;
            }
        }

        public bool Avancer() {

            int[] result = De.Lancer(2);
            Position += result[0] + result[1];
            return result[0] == result[1];
        
        }


        public CasePropriete[] Proprietes
        {
            get
            {
                return _propriete.ToArray(); 
            }
        }


        //Methode public payer, etre payer et ajouter propriete


        public void EtrePaye(int montant)
        {
            if (montant <= 0) return; //Gerer avec des exceptions
            Solde += montant;
        }

        public void Payer(int montant)
        {
            if (montant <= 0) return;
            if (Solde < montant)
                throw new NotEnoughMoneyException(this,montant);
            Solde -= montant;

           
        }

        public void AjoutePropriete(CasePropriete propriete) 
        {
            if (_propriete == null) return; //verifie que la propriété n'est pas null
            if(Proprietes.Contains(propriete)) return; //verifie que le proprietaire a deja la propriété?
            //on verifie que le joueur est propriétaire et si oui on l'ajoute a sa liste de propriété.
            if ( propriete.Proprietaire == this ) {
                _propriete.Add(propriete);
            }
        }

        public static Joueur operator +( Joueur left, int right) 
        {

            left.Solde+=right; //pas fait de verif que c'est bien positif
            return left;
        }

        //public static CasePropriete[] operator +(Joueur left, CasePropriete right)
        //{
        //    right.Acheter(left);
        //   return left.Proprietes;
        //}
        //Surcharge operateur devenu obsolète par le niveau de protection de la methode CasePropriete.Acheter
    }
}
