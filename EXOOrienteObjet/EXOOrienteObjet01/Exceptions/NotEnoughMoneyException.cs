using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EXOOrienteObjet01.Models;
using Exercice.NET01.Classes;
using System.Net;

namespace EXOOrienteObjet01.Exceptions
{
    internal class NotEnoughMoneyException :Exception
    {
        public Joueur Payeur { get; private set; }
        public int Montant { get; private set; }
        public CasePropriete Bien {  get; private set; }

        public NotEnoughMoneyException(Joueur payeur, int montant):this(payeur, montant, null, $"{payeur.Nom} n'a pas su payer la somme du {montant}")
        {
           //Pas de code a ajouter tout se fait dans le constructeur à 4 paramètres.
        }

        public NotEnoughMoneyException(Joueur payeur, int montant, CasePropriete bien):this (payeur, montant, bien, $"{payeur.Nom}n'a pas su payer la somme de {montant} pour acquérir le bien {bien.Nom} ")
        {
            //Pas de code a ajouter tout se fait dans le constructeur à 4 paramètres.
        }


        //Constructeur pas demandé mais peut etre plus pratique pour rassembler les données à un endroit ""
        private NotEnoughMoneyException(Joueur payeur, int montant, CasePropriete bien, string message) : base(message) 
        {
            Payeur = payeur;
            Montant = montant;
            Bien = bien;

        }


    }
}
