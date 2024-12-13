using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11.models
{
    internal static class Mathematique
    {
        public static double Division(double a, double b) 
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Attention , division par 0: {e.Message}");
                return 0;
            }


        }
        /// <summary>
        /// Méthode statique permettant d'obtenir la moyenne de type entier à l'aide d'un tableau de type entier
        /// </summary>
        /// <param name="nombres"> Ensemble de valeurs soumis en format d'un tableau d'entiers( doit contenir au minimum une valeur )</param>
        /// <returns>Nombre entier correspondant a la moyenne d'un ensemble de valeur </returns>
        /// <exception cref="ArgumentNullException">Certains paramètres(nombres) ne doivent pas êre null </exception>
        /// <exception cref="ArgumentOutOfRangeException"> Certains paramètres (nombres) doivent avoir au minimum une valeur.</exception>

        public static double Moyenne(int[] nombres)
        {
            if(nombres is null) throw new ArgumentNullException(nameof(nombres),"Attention , le paramètre est null"); // throw declenche l'exception , nameof permet d'utiliser le parametre au lieu de le mettre ne string.
            if (nombres.Length <= 0) throw new ArgumentOutOfRangeException(nameof(nombres), "Attention le paramètre doit contenir au moins une valeur!");

            int sum = 0;
            foreach (int nb in nombres)
            {
                sum += nb;
            }
            return sum/nombres.Length; 

        }
    }
}
