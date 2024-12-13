using Demo03OO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03OO.models
{
    public class Carte
    {
        private CouleurCarte _couleur;
        private ValeurCarte _valeur;

        public CouleurCarte Couleur
        {
            get { return _couleur; }
        }

        public ValeurCarte Valeur 
        {
        get { return _valeur; }
        }

        // pas de setter car la carte ne change pas ni de valeur ni de couleur ..

        public Carte(CouleurCarte couleur, ValeurCarte valeur)
        {
            _couleur = couleur;
            _valeur = valeur;
        }





    }
}
