using System.Diagnostics.Metrics;

namespace _2WeekSimpleConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en consoleapplikation som tar in ett valfritt numreriskt värde.
            /*◦ Visa en lista på ett antal vikt och längd - omvandlingar.
            ◦ T ex om du matar in siffran 12 ska listan se ut ungefär såhär:
            ◦ 12 meter = 13.12 yards
            ◦ 12 kg = 26.45 pound(lb)
            ◦ 12 grader Celsius = 53.6 Fahrenheit
            ◦ 12 kilowatt = 16.08 hästkrafter*/

            Console.WriteLine("Välkomna till Omvandla,ni kan omvandla valfritt värde till olika enheter.");
            Console.WriteLine("Matar in en valfritt tal: ");
            string input = Console.ReadLine();
            double inputD = double.Parse(input);

            //omvandla celsius till farenheit
            double celsiusToFarenheit = ((inputD * 9 / 5f) + 32f);
            Console.WriteLine($"{inputD}C = {celsiusToFarenheit}F");


            //omvandla meter till yards
            double meterToYards = inputD * 1.09361;
            Console.WriteLine($"{inputD}meters = {meterToYards} yards");


            //omvandla kg till pounds
            double kgToPounds = inputD * 2.20462;
            Console.WriteLine($"{inputD}kg = {kgToPounds} pounds");


            //omvanlda kilowatt till hästkrafter
            double kilowattToHorsepower = inputD * 1.34102;
            Console.WriteLine($"{inputD}kw = {kilowattToHorsepower}hp");


            //omvandla inches to cm
            double inchesToCm = inputD * 2.54;
            Console.WriteLine($"{inputD}inches = {inchesToCm}cm");
            Console.ReadLine();

        }
    }
}
