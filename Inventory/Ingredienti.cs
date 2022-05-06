using System.IO;

namespace Inventory
{
    public class Ingredienti : Order
    {
        public string Preparation()
        {
            string[] basepizza = { "Margherita", "Pepperoni","Napoletana" };
            Console.WriteLine(@"base pizza disponibile: " + basepizza[0] + basepizza[1] + basepizza[2]);
            string[] impasto = { "Normale", "Integrale" };
            Console.WriteLine(@"Impasto disponibile: "+ impasto[0] + impasto[1]);
            string[] aggiunte = { "Prosciutto cotto(1€)", "Funghi (2€)", "Crudo (2€)", "Ananas(GRATIS€)" };
            Console.WriteLine(@"Puoi aggiungere alla pizza: " + aggiunte[0] + aggiunte[1] + aggiunte[2] + aggiunte[3]);
            return "Ottima scelta!";
            if (aggiunte[3] != null) return "pizza omaggio";
        }
        
    }
}
