using static System.Net.WebRequestMethods;
using System;

namespace KyhExcerise2MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //◦ Ett sällskapsspel som bygger på att spelarna får hitta på olika ord, utan att veta hur historien ser ut.Det liknar övningen med Sagan.
           //◦ Du skapar en historia med luckor.
           //◦ Spelaren får hitta på t ex verb, substantiv, adjektiv m m, utan att veta hur de kommer användas.
           //◦ När orden är ifyllda så visas historien, och förhoppningsvis uppstår en del komiska ordval.
            Console.WriteLine("Skriv en substantiv namn: ");
            string substantivName = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv plats: ");
            string substantivPlace = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv sak: ");
            string substantivThing = Console.ReadLine();

            Console.WriteLine("Skriv en substantiv Flicka/pojke: ");
            string substantiv = Console.ReadLine();


            Console.WriteLine("Skriv en verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Skriv en adjektiv: ");
            string adjective = Console.ReadLine();

            Console.WriteLine("Skriv en pronoun hon/han: ");
            string pronoun = Console.ReadLine();

            Console.WriteLine($"Det var en gång i tiden en {substantiv} som var väldigt {adjective}.{pronoun} hette {substantivName}.{pronoun} bodde i {substantivPlace}. {pronoun} fungerade {adjective} för att {verb} en {substantivThing}");
         Console.ReadLine();
        }
    }
}
