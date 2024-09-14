using System;

namespace Excerise3SimpleConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bygg en application som kan omvandla mellan olika enheter.
            //◦ Om du anger t ex 23 grader Celsius så ska appen räkna ut att det motsvarar 73.4 Fahrenheit
            //◦ Sök på nätet efter andra enheter du kan bygga en omvandlare för.
            //◦ Vikter, hästkrafter, volym m m

            Console.WriteLine("Välkomna till en enkel Omvandlare");
            Console.WriteLine("Skriv 't' om du vill omvandla temperatur annars någon annat att omvandla Svensk kronor till Bristisk pounds");
            string answer = Console.ReadLine();

            if (answer == "t")
            {
                Console.WriteLine("Välja 'c' att convertera från Celsius till Fareneheit annars någon annat för vice versa.");
                string choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.WriteLine("Skriv temperature i Celsius: ");

                    float temperatureCelsius = int.Parse(Console.ReadLine());
                    float farenheitTemperature = (temperatureCelsius * 9 / 5f) + 35f;
                    Console.WriteLine($"Temperature i farenheit är :{farenheitTemperature} ");
                }
                else
                {
                    Console.WriteLine("Skriv temperature i Farenheit: ");
                    
                    float temperatureFarenheit = int.Parse(Console.ReadLine());
                    float celsiusTemperature = (temperatureFarenheit -32f) * 5/9f;
                    Console.WriteLine($"Temperature i farenheit är :{celsiusTemperature} ");
                }

            }
           else
            {
                Console.WriteLine("Välj 's' att conventera Svenksa krona till Britisk pouns annars någon annat för vice versa");
                string choice = Console.ReadLine() ;

                if (choice == "s")
                {
                    Console.WriteLine("Skriv belopp i svensk kronor :  ");

                    float swedishKronor = int.Parse(Console.ReadLine());
                    float britishPounds = swedishKronor * 0.0745f;
                    Console.WriteLine($"Beloppet i Bristish pounds är {britishPounds}");

                }
                else
                {
                    Console.WriteLine("Skriv belopp i British pounds: ");

                    float britishPounds = int.Parse(Console.ReadLine());
                    float swedishkronor = britishPounds * 0.0745f;
                    Console.WriteLine($"Beloppet i Svensk kronor är {swedishkronor}");
                }
            }

            Console.ReadLine();
        }
    }
}           
        
   

