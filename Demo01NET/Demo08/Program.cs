using Demo08.Models;

namespace Demo08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // En fonction de ce dont on a besoin on appelle une interface différente... : 

            //ImessageWriter writer = new ConsoleWriter();    
            ImessageWriter writer = new ConsoleRainbowWriter();
            //ImessageWriter writer = new HtmlWriter();
            
            writer.Write("Hello");



        }
    }
}
