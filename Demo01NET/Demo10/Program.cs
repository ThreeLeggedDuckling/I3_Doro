using Demo10.Models;

namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (TalkieWalkie tw1 = new TalkieWalkie("Dorothée"), tw2 = new TalkieWalkie("Jenny"))
            {
                tw1.EmettreMessage("Hello l'essai du Idisposable...");
                tw2.EmettreMessage("Hello");
                tw1.EmettreMessage(" Les destructeurs c'est nulle");
                tw1.EmettreMessage("Il vaut mieux utiliser les IDisposable...");
                //tw1.Dispose();  pour que le "dispose fonctionne" il fuat tout placer dans un bloc et ne plus mettre le tw1.dispose()
            }
        }
    }
}
