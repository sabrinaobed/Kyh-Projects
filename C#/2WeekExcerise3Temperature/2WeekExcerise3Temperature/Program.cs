namespace _2WeekExcerise3Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //frågar efter temperaturen i Svedala och Jukkasjärvi. Programmet berättar sedan var det är kallast.
            Console.WriteLine("Vad är temperaturen i Svedala? ");
            string tempSvedala = Console.ReadLine();
            decimal tempSvedalaD = decimal.Parse(tempSvedala);

            Console.WriteLine("Vad är tempaturen i Jukkasjärvi? ");
            string tempJukkasjärvi = Console.ReadLine();
            decimal tempJukkasjärviD = decimal.Parse(tempJukkasjärvi);

            if (tempSvedalaD > tempJukkasjärviD)
            {
                Console.WriteLine("Jukkasjärvi är kallast");
            }
            else
            {
                Console.WriteLine("Svedala är kallast");
            }

            Console.ReadLine();
        }
    }
}
