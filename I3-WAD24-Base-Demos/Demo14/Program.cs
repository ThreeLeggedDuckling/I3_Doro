namespace Demo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //surcharge des methodes
           //appel de la methode

            //instancier la methode ToolBox

            ToolBox toolBox = new ToolBox();

            toolBox.WriteVerticaly("Bonjour les WAD!");

            //attention ici le null il ne sait donc pas quelle methode utilisée puisque le string ET le char peuvent etre null..
            //toolBox.WriteVerticaly(null);
            //donc on declare d'abord en string

            string text = null;
            toolBox.WriteVerticaly(text);



            //Utilisation de la methode avec char creer dans le fichier structs

            toolBox.WriteVerticaly(new char[] {'O', 'K'});


            

        }
    }
}
