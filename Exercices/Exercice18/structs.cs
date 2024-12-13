using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice18
{
    public struct conversion
    {
   
        public double Celsius(double temperature)
        {

            double C = (temperature - 32) / 1.8;
            return C;

        }

        public double Fahrenheit(double temperature)
        {
            double f = (temperature * 1.8) + 32;

            return f;
        }

    }
}
