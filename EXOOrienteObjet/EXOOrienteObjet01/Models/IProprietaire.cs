using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOrienteObjet01.Models
{
    public interface IProprietaire
    {
        bool EstHypothequee { get; }
        void Hypothequer();
        void Deshypothequer();
    }
}
