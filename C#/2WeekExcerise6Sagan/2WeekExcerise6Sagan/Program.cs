using System;

namespace _2WeekExcerise6Sagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //◦ Sagan: Skapa en applikation som bygger en saga enligt följande upplägg:
            /* Det var en gång en<ålder> år gammal<djursort> som hette<namn>.En dag var<namn> ute på en
              promenade I skogen, och mötte en stor varg.Vargen bet av ett ben på<honom eller henne>. < namn >
             sprang snabbt hem på sina<antalben – 1 >.Så var sagan slut.*/


            Console.WriteLine("Skapa en saga själv");

            Console.WriteLine("Vad är djurs ålder? ");
            string animalAge = Console.ReadLine();
            int animalAgeInt = int.Parse(animalAge);

            Console.WriteLine("Vad är djurs namn? ");
            string animalName = Console.ReadLine();
            

            Console.WriteLine("Är djur honom eller henne? ");
            string animalGender = Console.ReadLine();

            Console.WriteLine("Hur många ben har den här djur? ");
            String animalLegs = Console.ReadLine();
            int animalLegsInt = int.Parse(animalLegs);

            Console.WriteLine("Vad är djursort?");
            string animalType = Console.ReadLine();


            Console.WriteLine($"Det var en gång en {animalAgeInt} år gammal {animalType} som hette {animalName}.En dag var {animalName} ute på en promenade I skogen, och mötte en stor varg.Vargen bet av ett ben på {animalGender}.{animalName} sprang snabbt hem på sina {animalLegsInt - 1}.Så var sagan slut");
            Console.ReadLine();


        }
    }
}
