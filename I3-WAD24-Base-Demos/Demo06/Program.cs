namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "blabla.lulu@bstorm.be";
            int positionArobase = email.IndexOf("@");
            int positiondot = email.IndexOf(".");

            int firstnamelength = positiondot; //postion du preom du depart à position du point

            string firstname = email.Substring(0, positiondot);

            string lastname = email.Substring(positiondot + 1, positionArobase - positiondot-1); //nom de famille position juste apres le point jusqu'a position de l'arobat - position du point

            string domainName = email.Substring(positionArobase + 1);

            Console.WriteLine($"Prenom: {firstname} , Nom : {lastname}, nom de domaine: {domainName}");
        }
    }
}
