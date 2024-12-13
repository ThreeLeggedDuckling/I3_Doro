using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo11.Exceptions
{
    internal class ArgumentArrayNeedValueException : ArgumentOutOfRangeException
    {
        public int MinValueRequired { get;private set; }
        public int CurrentQuantityValues { get; private set; }

        public ArgumentArrayNeedValueException(int minValue, int currentQteValues): this(minValue, currentQteValues, "unknow argument")
        {
            //MinValueRequired = minValue;
            //CurrentQuantityValues = currentQteValues;
        }
        public ArgumentArrayNeedValueException(int minValue, int currentQteValues, string parameterName):this(minValue,currentQteValues ,parameterName,"la quantité de valeur du tableau n'est pas suffisante.") 
        {
            //MinValueRequired = minValue;
            //CurrentQuantityValues = currentQteValues;

        }

        public ArgumentArrayNeedValueException(int minValue, int currentQteValues, string parameterName, string message) : base(parameterName, message)
        {
            MinValueRequired = minValue;
            CurrentQuantityValues = currentQteValues;
        }


    }
}
