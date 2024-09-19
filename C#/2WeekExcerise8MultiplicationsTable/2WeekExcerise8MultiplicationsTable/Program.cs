using System.ComponentModel.Design;

namespace _2WeekExcerise8MultiplicationsTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //◦ Gör en console-application som skriver ut multiplikationstabellen enligt nedanstående
            //exempel, ändå till 10x10:

            //mellanrum för att justera första kolumnen
            Console.Write("   ");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();

            //
            for (int i = 1;i <= 10; i++)
            {
                Console.Write($"{i,3}");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,3}");
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
