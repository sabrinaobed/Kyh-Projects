namespace _2WeekExcerise4Temperature2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //frågar efter temperaturen i Svedala och Jukkasjärvi. Programmet berättar sedan var det är kallast…lägg till Visby på förra punkten och berätta var det är varmast.
            Console.WriteLine("Vilka är varmast av följände staderna? ");
            Console.WriteLine("Vad är temperaturen in Svedala? ");
            string tempSvedala = Console.ReadLine();
            decimal tempSvedalaD = decimal.Parse(tempSvedala);

            Console.WriteLine("Vad är temperaturen i Jukkasjärvi? ");
            string tempJukkasjärvi = Console.ReadLine();
            decimal tempJukkasjärviD = int.Parse(tempJukkasjärvi);

            Console.WriteLine("Vad är temperaturen i Visby? ");
            string tempVisby = Console.ReadLine();
            decimal tempVisbyD = decimal.Parse(tempVisby);

            if (tempSvedalaD > tempJukkasjärviD && tempSvedalaD > tempVisbyD)
            {
                Console.WriteLine("Svedala är varmast!");
            }
            else if (tempJukkasjärviD > tempVisbyD && tempJukkasjärviD > tempSvedalaD) 
            {
                Console.WriteLine("Jukkasjärvi är varmast!");
            
            }
            else
            {
                 Console.WriteLine("Visby är varmast!");
            }

            Console.ReadLine();
        }
    }
}
