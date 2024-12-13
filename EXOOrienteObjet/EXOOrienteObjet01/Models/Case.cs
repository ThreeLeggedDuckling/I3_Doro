using Exercice.NET01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOrienteObjet01.Models
{
    public abstract class Case : IVisiteur
    {

        //Class Case est une classe parent de CasePropriete

        //Variable
        private List<Joueur> _visiteurs;

        //Propriete publiques
        public string Nom { get; private set; }
        public Joueur[] Visiteurs
        {
            get { return _visiteurs.ToArray(); }
        }

        //constructeur

        public Case( string nom)
        {
            Nom = nom;
            _visiteurs = new List<Joueur>();
        }

        //Methodes
        public void AjouterVisiteur(Joueur visiteur) 
        {
            if (visiteur is null) return;
            if (_visiteurs.Contains(visiteur)) return;
            _visiteurs.Add(visiteur);
        }

        public void RetirerVisiteur(Joueur visiteur) 
        {
            if (visiteur is null) return;
            if (!_visiteurs.Contains(visiteur)) return;
            _visiteurs.Remove(visiteur);    
        }

        public abstract void Activer(Joueur visiteur);
       

    }
}
