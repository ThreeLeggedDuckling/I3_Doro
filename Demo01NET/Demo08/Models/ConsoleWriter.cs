using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08.Models
{
    internal class ConsoleWriter : ImessageWriter
    {

        public virtual void Write(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
