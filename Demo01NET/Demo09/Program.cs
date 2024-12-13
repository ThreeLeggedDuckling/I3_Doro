using Demo09.Models;

namespace Demo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Bienvenue au touché-coulé");

            List<IPlacable> myShips = new List<IPlacable>();
            Bateau b1 = new Bateau(2);
            Bateau b2 = new Bateau(4);

            Console.WriteLine($"Veuillez positionner vos bateaux ");
            foreach (IPlacable ship in myShips )
            {
                Console.WriteLine("Veuillez indiquer la position sur l'axe X");
                int posX = int.Parse(Console.ReadLine());
                Console.WriteLine("Veuillez indiquer la position sur l'axe Y");
                int posY = int.Parse(Console.ReadLine());
                Console.WriteLine("Votre bateau est il à l'horizontal? (O)ui - (N)on?");
                bool isHorizontal = Console.ReadKey(true).Key == ConsoleKey.O;
                ship.SetPosition(posX, posY, isHorizontal);
                Console.WriteLine( $"Votre bateau est positionné en {posX} - {posY} {(isHorizontal)}");
            }

            List<IAttackable>oppenentShips = new List<IAttackable>();

            for (int i = 0; i < myShips.Count; i++) 
                { 
                    oppenentShips.Add((Bateau)myShips[i]);
                   }
            Console.WriteLine("Quel position envoyez vous votre missile?");
            Console.WriteLine("Veuillez indiquer la position sur l'axe X");
            int posMissileX = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer la position sur l'axe Y");
            int posMissileY = int.Parse(Console.ReadLine());
            bool hit = false;
            for (int i = 0; i < oppenentShips.Count; i++)
            {
                if (oppenentShips[i].FireOn(posMissileX,posMissileY)) {
            }
        }
}
