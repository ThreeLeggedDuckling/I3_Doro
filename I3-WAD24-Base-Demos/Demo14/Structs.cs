using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14
{
    public struct ToolBox
    {
        //declaration de la fonction
        public void WriteVerticaly(string message)
        {
            //verifie que le string envoyé n'est pas null ou espace blanc sinon return (arrete tout)
            if (string.IsNullOrWhiteSpace(message))
            {
                return; //meilleure solution serait d'utiliser des exceptions.
            }
            char[] chars = message.ToCharArray();
            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}
            WriteVerticaly(chars);
            //plutot que de faire la boucle on utilise la methode avec un tableau de caractère (creer juste en dessous et qui s'execute)
        }

        //surcharge : meme nom de fonction avec declaration de paramètre différent.

        public void WriteVerticaly(char[] message)
        {
            if (message is null || message.Length == 0 || CharArrayContainsOnlyWhiteSpace(message))
            {
                return;
            }

            foreach (char c in message)
            {
                Console.WriteLine(c);
            }
        }
        public bool CharArrayContainsOnlyWhiteSpace(char[] array)
        {

            foreach (char c in array)
            {
                if (!char.IsWhiteSpace(c) && c!= '\0') // '\0' = null
                {
                    return false;
                }
            }
            return true;
        }
    }
}
