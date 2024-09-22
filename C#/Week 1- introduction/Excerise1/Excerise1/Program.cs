namespace Excerise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapa, kompilera och kör en ”Hello C#” konsolapplikation
            Console.WriteLine("Hello, C#!");
            Thread.Sleep(1000);

            //Ändra applikationen så att den skriver ut en annan text, som du själv matar in.
            Console.WriteLine("Hej!Jag heter Sabrina.");
            Thread.Sleep(1000);


            //Skapa ett program som skriver ut talen 9, 155 och 312, samt summan av talen.
            int num1 = 9;
            int num2 = 155;
            int num3 = 312;

            Console.WriteLine("Talen är 9,155 och 312");
            int sum = num1 + num2 + num3;

            Console.WriteLine($"Summan av {9} + {155} + {312} = {sum}");
            Thread.Sleep(1000);

            //Skapa en konsolapplikation som skriver ut aktuellt datum och klockslag i formatet ”Idag är det 2022 - 09 - 12 13:51:40”
            Console.WriteLine("Idag är det " + DateTime.Now);
            Thread.Sleep(1000);

            //Skapa en konsolapplikation som beräknar och skriver ut summan av två valfria tal, som matas in av användaren.
            Console.WriteLine("Ange första tal: ");
            string firstNum  = Console.ReadLine();
            int firstNumInt = int.Parse(firstNum);

            Console.WriteLine("Ange andra tal: ");
            string secondNum = Console.ReadLine();
            int secondNumInt = int.Parse(secondNum);

            int summan =  firstNumInt + secondNumInt;

            Console.WriteLine($"Summan av {firstNumInt} + {secondNumInt} = {summan}");
            Thread.Sleep(1000);

            //Skapa ett program som läser ditt födelseår från konsolen och skriver ut hur gammal du är nu.
            Console.WriteLine("Skriv ditt födelseår: ");
            string birthYear = Console.ReadLine();  
            int birthYearInt = int.Parse(birthYear);

           int  currentYear = DateTime.Now.Year;
           int age = currentYear - birthYearInt;
           Console.WriteLine($"Din ålder är {age}");
           Thread.Sleep(1000);

            //Sagan: Skapa en applikation som bygger en saga enligt följande upplägg:
            Console.WriteLine("Skapa en Saga");
            Console.WriteLine("Vad är djurs ålder ? ");
            string animalAge = Console.ReadLine();
            int animalAgeInt = int.Parse(animalAge);

            Console.WriteLine("Vad är djurs namn ? ");
            string animalName = Console.ReadLine();

            Console.WriteLine("Vad är djursort ? ");
            string animalType = Console.ReadLine();

            Console.WriteLine("Hur många ben har djur ? ");
            string animalLegs = Console.ReadLine();
            int animalLegsInt = int.Parse(animalLegs);

            Console.WriteLine($"Det var en gång en {animalAgeInt} år gammal {animalType} som hette {animalName}. En dag var {animalName} ute på en promenade i skogen, och mötte en stor varg. Vargen bet av ett ben. {animalName} sprang snabbt hem på sina {animalLegsInt - 1} ben. Så var sagan slut");

            Console.ReadLine();


        }

    }
}
