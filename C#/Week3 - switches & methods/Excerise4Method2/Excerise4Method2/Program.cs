using System.Net.Sockets;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Excerise4Method2
{
    internal class Program
    {
        /*Skapa en Console Application med tre metoder:
◦ Addera(int tal1, int tal2) som tar två heltal och returnerar summan.
◦ Momsen(int summan) som tar ett tal som inparameter och räknar ut hur mycket moms som ska läggas till.
◦ Anta att moms är 25%.
◦ MomsOchBelopp(int summanMedMoms) som tar ett tal och momsprocent och returnerar resultatet.
◦ Appen ska sedan fungera såhär:
◦ Mata in två tal
◦ Applikationen ska sedan visa följande (om du t ex matar in 20 och 30):
◦ Summan av talen är: 50 kr
◦ Momsen är: 12.50 kr
◦ Totalsumma inklusive moms: 62.50 kr*/

        //deklararera const value'
        private static double VAT_RATE = 0.25;
        
        //add metod
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        //momsen metod
        static double Vat(int sum)
        {
          return sum * VAT_RATE;
        }
        //summan med Moms Metod
        static double TotalAmount(int sum)
        {
            return sum + (sum * VAT_RATE);
        }
        
        //ropa metoder i main    
        static void Main(string[] args)
        {

            //uppropa add numbers metod
            Console.WriteLine("Skriv in första tal: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in andra tal: ");
            int num2 = int.Parse(Console.ReadLine());  
            
            int sum = AddNumbers(num1, num2);
            Console.WriteLine($"Summan = {sum} kr");

            //uppropa VAT metod
            double vatAmount = Vat(sum);
            Console.WriteLine($"VAT = {vatAmount}kr");

            //upropa  total amount metod
            double totalAmount = TotalAmount(sum);
            Console.WriteLine($"Belopp med VAT = {totalAmount}kr");

            Console.ReadLine();


        }
    }
}
