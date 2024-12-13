namespace Exercice16
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcul calcul;
            do
            {
                Console.WriteLine("Veuillez introduire un premier nombre : ");
            } while (!double.TryParse(Console.ReadLine(), out calcul.nb1));

            do
            {
                Console.WriteLine("Veuillez introduire un second nombre : ");
            } while (!double.TryParse(Console.ReadLine(), out calcul.nb2));

            do
            {
                Console.WriteLine("Veuillez introduire un opérateur (+ , - , * , / ) : ");
                calcul.operat = Console.ReadLine()[0];
            } while (calcul.operat != '+' && calcul.operat != '-' && calcul.operat != '*' && calcul.operat != '/');

            calcul.isValid = true;
            switch (calcul.operat)
            {
                case '+':
                    calcul.result = calcul.nb1 + calcul.nb2;
                    break;
                case '-':
                    calcul.result = calcul.nb1 - calcul.nb2;
                    break;
                case '*':
                    calcul.result = calcul.nb1 * calcul.nb2;
                    break;
                case '/':
                    if (calcul.nb2 == 0)
                    {
                        calcul.result = null;
                        calcul.isValid = false;
                    }
                    else {
                        calcul.result = calcul.nb1 / calcul.nb2;
                    }
                    break;
                default:
                    calcul.result = null;
                    calcul.isValid = false;
                    break;
            }

            if (calcul.isValid)
            {
                Console.WriteLine($" Le resultat de {calcul.nb1} {calcul.operat} {calcul.nb2} vaut {calcul.result}");
            }
            else
            {
                Console.WriteLine($" il n'y a pas de reponse valide pour :{calcul.nb1} {calcul.operat} {calcul.nb2} ");
            }
            

            
        }
    }
}
