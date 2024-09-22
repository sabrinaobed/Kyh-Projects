using System.ComponentModel.Design;

namespace Excerise1Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*◦ Skriv ett program som lägger till bonus till givna poäng.
◦ Poängen är mellan 1 och 9.
◦ Programmet läser en siffra som indata.
◦ Om siffran är
◦ mellan 1 och 3: multiplicera med 10
◦ mellan 4 och 6: multiplicera med 100
◦ mellan 7 och 9: multiplicera med 1000
◦ noll eller inte en siffra: skriv ut felmeddelande
◦ Använd en switch och avsluta med att skriva ut det nya värdet på konsolen
◦ Lägg in tryParse så det bara går att ange siffrorna 1-9  */

            //Skriv ett tal som ligger mellan 1 och 9
            Console.WriteLine("Skriv ett tal mellan 1 och 9: ");
            string input = Console.ReadLine();

            //omvandla detta tal från string till int
            bool isCorrectValue = int.TryParse(input, out int value);

            //villkor 
            if(isCorrectValue && value > 1 && value < 9)
            {
                int bonusPoints = 0;

                switch(value)
                {
                    case 2:
                    case 3:
                        {
                            bonusPoints = value * 10;
                            Console.WriteLine($"Bonus poäng är: {bonusPoints}");
                            break;
                        }
                    case 4:
                    case 5:
                    case 6:
                        {
                            bonusPoints = value * 100;
                            Console.WriteLine($"Bonus poäng är: {bonusPoints}");
                            break;
                        }
                    case 7:
                    case 8:
                        {
                            bonusPoints = value * 1000;
                            Console.WriteLine($"Bonus poäng är: {bonusPoints}");
                            break;
                        }

                }
               
               
            }
            else
            {
                Console.WriteLine("Fel:Mata in correkt tal!");
            }
            Console.ReadLine();


        }
    }
}
