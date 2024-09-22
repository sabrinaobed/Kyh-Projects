namespace _2WeekExcerise7ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //◦ Skapa en Console Application som med hjälp av en while loop skriver ut alla tal
            //mellan 1 och 100, och markerar jämna nummer med en hakparentes omkring sig.
            //(1[2] 3[4] 5[6]...)

            for (int number = 1; number <= 100; number++)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"[{number}]");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
