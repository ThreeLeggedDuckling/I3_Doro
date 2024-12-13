using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Models
{
    internal interface IBateau :ICouler
    {
        void Naviguer(); //interface n'accepte que du public donc pas besoin de le specifier
    }
}
