using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercice.NET01.Classes
{
     internal class De
    {






        //Exercice 01

        //public static int valeurMin = 1;
        //public static int valeurMax = 6;
        //public static Random rng; // on peut aussi mettre public static random rng = new random();
        //public static int[] Lancer(int nbDes) 
        //{
        //    if (rng is null)
        //    {
        //        rng = new Random();
        //    }

        //    int[] result = new int[nbDes];
        //    for (int i = 0; i < nbDes; i++) 
        //    { 
        //        result[i] = rng.Next(valeurMin, valeurMax + 1); 
        //    }


        //    return result;
        //        }


        //EXercice 02

        //Correction 
        private static int _valeurMin = 1;
        private static int _valeurMax = 6;
        private static Random rng;




        public static int ValeurMin
        {
            get 
            {
                return _valeurMin;
            }
            set 
            {
                if (value <= 0) return; //Gerer à l'aide d'exception
                _valeurMin = value;
                if (value >= _valeurMax) _valeurMax = value +1;
            }
        }

        public static int ValeurMax
        {
            get
            {
                return _valeurMax;
            }
            set
            {
                if (value <= 1) return; //Gerer à l'aide d'exception
                _valeurMax = value;
                if (value <= _valeurMin) _valeurMin = value - 1;
            }
        }



        public static int[] Lancer(int nbDes)
        {
            if (rng is null)
            {
                rng = new Random();
            }

            int[] result = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                result[i] = rng.Next(_valeurMin,_valeurMax + 1);
            }


            return result;
        }
















        //MON EXO 


        //public int _valeurMax;

        //public int ValeurMAx
        //{
        //    get { 
        //        return _valeurMax; }
        //    set {
        //        if (_valeurMax > 1 && _valeurMax >= ValeurMin)
        //        {
        //            _valeurMax = _valeurMax - 1;
        //        }
        //        _valeurMax = value; 
        //    }
        //}


        //public int _valeurMin;

        //public int ValeurMin
        //{
        //    get { 
                
        //        return _valeurMin; }

        //    set { 
        //        if (_valeurMin > 0 && _valeurMin <= ValeurMAx)
        //        {
        //            _valeurMin = _valeurMin +1;
        //        }
                
        //        _valeurMin = value; 
        //    }
        //}




        //public static Random rng; // on peut aussi mettre public static random rng = new random();
        //public static int[] Lancer(int nbDes)
        //{
        //    if (rng is null)
        //    {
        //        rng = new Random();
        //    }

        //    int[] result = new int[nbDes];
        //    for (int i = 0; i < nbDes; i++)
        //    {
        //        result[i] = rng.Next(_valeurMin, valeurMax + 1);
        //    }


        //    return result;
        //}



    }
}
