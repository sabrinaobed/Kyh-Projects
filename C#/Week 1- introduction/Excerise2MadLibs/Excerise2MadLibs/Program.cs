using System;

namespace Excerise2MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*◦ Ett sällskapsspel som bygger på att spelarna får hitta på olika ord, utan att veta hurhistorien ser ut. Det liknar övningen med Sagan.
                   ◦ Du skapar en historia med luckor.
                   ◦ Spelaren får hitta på t ex verb, substantiv, adjektiv m m, utan att veta hur de kommer användas.
                   ◦ När orden är ifyllda så visas historien, och förhoppningsvis uppstår en del komiska ordval.*/

            Console.WriteLine("Skriv ord och skapa en Saga själv");

            Console.WriteLine("Skriv en substantiv : flicka/pöjke ");
            string noun = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv namn: ");
            string nounName = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv plats : ");
            string nounPlace = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv sak: ");
            string nounThing = Console.ReadLine();

            Console.WriteLine("Skriv en pronomen: hon/hon/hen ");
            string pronoun = Console.ReadLine();

            Console.WriteLine("Skriv en verb :");
            string verb = Console.ReadLine();

            Console.WriteLine("Skriv en adjektiv: ");
            string adjective = Console.ReadLine();

            Console.WriteLine($"Det var en gång i tiden ett {noun} som var väldigt {adjective}.{pronoun} hette {nounName}.{pronoun} bodde i {nounPlace}. {nounName} fungerade {adjective} till {verb} en {nounThing}");
            Console.ReadLine();


        
        }


    }
}
