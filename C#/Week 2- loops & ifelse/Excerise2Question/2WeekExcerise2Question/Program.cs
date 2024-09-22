namespace _2WeekExcerise2Question
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //…frågar om AIK (eller annat valfritt lag) är Sveriges bästa lag. Om användaren svarar ja skriver programmet ut ”Helt rätt!”, annars skrivs det ut ”Väldigt fel!”.

            Console.WriteLine("Är AIK bästa lag i Sverige: ja/nej ");
            string choice = Console.ReadLine();

            if (choice == "ja")
            {
                Console.WriteLine("Helt rätt!");
            }
            else
            {
                Console.WriteLine("Väldigt fel!");
            }

            Console.ReadLine();
        }
    }
}
