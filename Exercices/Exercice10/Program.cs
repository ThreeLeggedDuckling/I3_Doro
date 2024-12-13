namespace Exercice10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tableau de 10 entier

            int[] tab = new int[10];
            tab[0] = 2;
            for (int i = 1; i < tab.Length; i++) 
            {
              tab[i] = tab[i - 1]*2;
            }

            foreach (int value in tab)
            {
                Console.WriteLine(value);
            }
















        }
    }
}
