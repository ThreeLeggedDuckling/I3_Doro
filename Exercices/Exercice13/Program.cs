using System.Collections;
using System.ComponentModel.Design;

namespace Exercice13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Correction To do List

            List<string> todolist = new List<string>();
            string userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Voici votre liste de tâches: ");
                for (int i = 0; i < todolist.Count; i++)
                {
                    string task = todolist[i];  
                    Console.WriteLine($"{i+1} - {task}");
                }
                Console.WriteLine("veuillez faire un choix: ");
                Console.WriteLine($"(A)jouter - {((todolist.Count>0)?"(S)upprimer - (M)odifier -" : "")} (Q)uitter");
                userChoice = Console.ReadLine().ToUpper();

                
                int index;
                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("Veuillez indiquer la nouvelle tâche: ");
                            todolist.Add(Console.ReadLine());
                            break;
                        case "S" when todolist.Count > 0:
                       
                        do
                        {
                            Console.WriteLine("Veuillez sélectionner la tâche à supprimer : ");
                        }while(!int.TryParse(Console.ReadLine(), out index) || index <1 || index>todolist.Count);    
                       
                        todolist.Remove(todolist[index-1]);
                            break;

                        case "M" when todolist.Count > 0: //mot cle when simplfie la tache 
                        do
                        {
                            Console.WriteLine("Veuillez sélectionner la tâche à modifier : ");
                        } while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > todolist.Count);
                        Console.WriteLine($"la tache a remplacer: {todolist[index-1]}");
                        Console.WriteLine("Par quoi voulez vous la remplacer?");
                        todolist[index - 1] = Console.ReadLine();

                        break;
                    }


                
            } while (userChoice != "Q");
            Console.WriteLine("Fin");





            ////Exercice To do list
            //Console.WriteLine("Exercice de To do list: ");
            //Console.WriteLine("Ecris ta tâche:");
            //ArrayList Liste = new ArrayList();
            //object tache=(Console.ReadLine());
            //Liste.Add(tache);


            //string commande;

            //do
            //{
            //    Console.WriteLine("Vous pouvez introduire une nouvelle tâche (N), Supprimer la tache (S) ou modifier la tache (M),ecrire 'stop' pour arreter:");
            //    commande = Console.ReadLine();
            //    if (commande == "N")
            //    {
            //        Console.WriteLine("Ecris ta tâche:");
            //        object tache2 = (Console.ReadLine());
            //        Liste.Add(tache2);
                    

            //    }
            //    else if (commande == "S")
            //    {
            //        Console.WriteLine("Donner votre tache a supprimer:");
            //        object tache3 = (Console.ReadLine());
            //        Liste.Remove(tache3);
            //    }
            //    else if (commande == "M") 
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Recap de votre to do list");
            //        foreach (var item in Liste)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            //    Console.WriteLine("Vous pouvez introduire une nouvelle tâche (N), Supprimer la tache (S) ou modifier la tache (M):");
            //    commande = Console.ReadLine();

            //}
            //while (commande != "N" && commande != "S" && commande != "M" && commande != "stop");
                
               


        }
    }
}
