namespace Exercice18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // transforme en Fahrenheit

            double essai1= 1 ;
            conversion m = new conversion();
            double resultat1 = m.Fahrenheit(essai1);

            Console.WriteLine(resultat1);

            //transforme en Celsius

            double essai2 = 41;
            double resultat2 = m.Celsius(essai2);
            Console.WriteLine(resultat2);
        }
    }
}
