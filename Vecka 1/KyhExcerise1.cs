namespace FirstExcerciseKyh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapa, kompilera och kör en ”Hello C#” konsolapplikation
            Console.WriteLine("Hello C#!");



            //Ändra applikationen så att den skriver ut en annan text, som du själv matar in.
            Console.WriteLine("Hello This is a new text");



            //Skapa ett program som skriver ut talen 9, 155 och 312, samt summan av talen.
            int num1 = 9;
            int num2 = 155;
            int num3 = 312;

            int sum = num1 + num2 + num3;
            Console.WriteLine($"Numbers are {num1},{num2} and {num3}");
            Console.WriteLine($"There sum is {sum}");



            //Skapa en konsolapplikation som skriver ut aktuellt datum och klockslag i formatet ”Idag är det 2022 - 09 - 12 13:51:40” 
            Console.WriteLine("Idag är det " + DateTime.Now);


            //Skapa en konsolapplikation som beräknar och skriver ut summan av två valfria tal, som matas in av användaren.
            Console.WriteLine("Enter first value: ");
            string firstValue = Console.ReadLine();
            int firstValueInt = int.Parse( firstValue );

            Console.WriteLine("Enter second value: ");
            string secondValue = Console.ReadLine();
            int secondValueInt = int.Parse( secondValue );

            Console.WriteLine("The sum is " + (firstValueInt + secondValueInt));



            //Skapa ett program som läser ditt födelseår från konsolen och skriver ut hur gammal du är nu.
            Console.WriteLine("Enter your birth year: ");
            string birthYear = Console.ReadLine();
            int birthYearInt = int.Parse(birthYear);

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYearInt;

            Console.WriteLine($"Your age is {age}");


            /*Sagan: Skapa en applikation som bygger en saga enligt följande upplägg:
          Det var en gång en<ålder> år gammal<djursort> som hette<namn>.En dag var<namn> ute på en
          promenade I skogen, och mötte en stor varg.Vargen bet av ett ben. < namn > sprang snabbt hem på sina
          <antalben – 1 >.Så var sagan slut.*/
            Console.WriteLine("What is the age of the animal? ");
            string animalAge = Console.ReadLine();
            int animalAgeInt = int.Parse(animalAge);

            Console.WriteLine("Which kind of animal was that? ");
            string animalType = Console.ReadLine();

            Console.WriteLine("What was the name of the animal? ");
            string animalName = Console.ReadLine();

            Console.WriteLine("How many legs does this animal has?");
            string animalLegs = Console.ReadLine();
            int animalLegsInt = int.Parse(animalLegs);

            Console.WriteLine($"Once upon a time there was a {animalAgeInt} years old {animalType} named {animalName}. One day {animalName} was out on one on walk In the forest, and met a big wolf. The wolf bit off a leg. {animalName} quickly ran home on his own {animalLegsInt - 1}. That was the end of the story.");


            Console.ReadLine();
        }
    }
}
