using System.ComponentModel.Design;

namespace Exercice04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez encoder votre numéro de compte: ");
            string? Usernbre = Console.ReadLine();
            bool ch_converted = long.TryParse(Usernbre, out _);
            if (ch_converted == false || Usernbre.Length != 12)
            {
                Console.WriteLine("numero de compte invalide...  ");
            }
            else
            {
                string lengthnbre = Usernbre.Substring(0,10);
                string finbre= Usernbre.Substring(10);
                short fin = short.Parse(finbre);
                long debut = long.Parse(lengthnbre);
                long resultatmodulo = debut % 97;
                 
                if (resultatmodulo == fin || resultatmodulo == 0 && fin == 97)
                {
                    Console.WriteLine("OK");
                
                    string finstring = fin.ToString();
                    string codebeo = finstring + finstring + 111400 ;
                    long code =long.Parse(codebeo);
                    long result = code % 97;
                    long totaldebut = 98 - result;
                    // quoi faire si le resultat de total debut n 'est que un seul chiffre? .Tostring avec les "D2"
                    string debutstring = totaldebut.ToString("D2");
                    string lengthstring = lengthnbre.ToString();

                    string compte = "BE" + debutstring + lengthstring + finstring;

                    Console.WriteLine($" le compte est donc le : {compte}");

                }
                else
                    {
                    Console.WriteLine("KO");
                    }
            }

        }
    }
}
