namespace Demo13
{
    public struct TempsHorloge
    {
        public int hours;
        public int minutes;
        public int seconds;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int hours = 10;
            int minutes = 11;
            int seconds = 59;
            */

            TempsHorloge debutDemo;
            debutDemo.hours = 10;
            debutDemo.minutes = 11;
            debutDemo.seconds = 59;

            Console.WriteLine($"La demo a commencé à {debutDemo.hours}:{debutDemo.minutes}:{debutDemo.seconds}");

            //TempsHorloge finDemo = new TempsHorloge();
            Console.WriteLine($"La demo a commencé à {debutDemo.hours}:{debutDemo.minutes}:{debutDemo.seconds}");
             //Ici on initialise donc les valeurs données a hours , minutes, secondes seront égales à 0



            //finDemo = debutDemo;
            // ici finDemo prend les valeurs de debutDemo 
            //si on change les valeurs dans finDemo on ne change pas les valeurs de debutDemo


            //non nullable sauf si declaré comme nullable , exemple:
            //TempsHorloge? finDemo = null;
            //finDemo = debutDemo;
            //if (finDemo is not null)
            //{
            //    TempsHorloge finDemoNotNull =(TempsHorloge)finDemo;
            //    finDemoNotNull.minutes = 30;
            //    finDemoNotNull.seconds = 00;   
            //}
        }
    }
}
