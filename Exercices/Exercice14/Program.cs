namespace Exercice14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercice un pion dans un tableau de 10 éléments (deplacement gauche ou droite ou stopper l'algorithme)


            /////////////////////correction/////////////////////////////
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ConsoleKey userChoice;
            //string userChoice;
            //on peut aussi recuperer cette information avec un ReadKey().key exemple userChoice = Console.ReadKey().Key verif avec concoleKey.(value) plus besoin de la touche "Enter"
            bool[] tab = new bool[10];
            int index = 0;
            tab[index] = true;

            do
            {
                Console.Clear();
                //Affichage
               

                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i])
                    {
                        Console.Write("😊");
                    }
                    else
                    {
                        Console.Write("❌");
                    }

                }
                Console.WriteLine();
                //Menu pour le choix du deplacement

                Console.WriteLine("← | → | Esc "); //alt 24 (haut↑), alt 25 (bas↓), alt 26 (droite→), alt 27 (gauche←)
                userChoice = Console.ReadKey().Key;
                //int index = Array.IndexOf(tab, true);

                //Deplacement

                tab[index] = false;

                if (userChoice == ConsoleKey.LeftArrow && index > 0)
                {
                    index--;
                }
                else if (userChoice == ConsoleKey.RightArrow && index < tab.Length - 1)
                {
                    index++;
                }
                tab[index] = true; 
            } while (userChoice != ConsoleKey.Escape);











                //string []tableau = new string[10];
                //string [] tableau = { "x", "x", "x", "x", "x", "x", "x", "x", "x", "x" };
                //int position = 0;
                //Console.WriteLine(" Vous pouvez déplacer la position du i de droite à gauche à l'aide des lettres g et d , tapez q pour quitter: ");
                //string user = Console.ReadLine().ToLower();

                //do
                //{
                //    for (int i = 0; i<tableau.Length ; i++)
                //    {
                //        if (i == position)
                //        {
                //          
                //            Console.WriteLine("i");

                //        }
                //        else
                //        { 
                //            
                //            Console.WriteLine(tableau[position]);
                //        }

                //    }


                //    Console.WriteLine(" Vous pouvez déplacer la position du i de droite à gauche à l'aide des lettres g et d , tapez q pour quitter: ");
                //    user = Console.ReadLine().ToLower();
                //    if (user == "g")
                //    {
                //        position--;
                //    }
                //    else if (user == "d" )
                //    {
                //        position++;
                //    }
                //} while (user !="q");

                //Console.WriteLine("vous avez quitter le jeu");











            }
    }
}


