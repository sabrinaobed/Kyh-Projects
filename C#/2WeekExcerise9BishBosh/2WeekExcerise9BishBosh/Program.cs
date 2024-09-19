namespace _2WeekExcerise9BishBosh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //welcome note
            Console.WriteLine("Välkommen!Bish Bosh Spel!");

            //write end number
            Console.WriteLine("Skriv en tal för spel vilket skulle visa spelgränsen: ");
            string inputNum = Console.ReadLine();
            int inputNumInt = int.Parse(inputNum);

            //write bish number
            Console.WriteLine("Skriv en Bish tal: ");
            string bishNum = Console.ReadLine();
            int bishNumInt = int.Parse(bishNum);

            //write a bosh number
            Console.WriteLine("Skriv en Bosh tal: ");
            string boshNum = Console.ReadLine();
            int boshNumInt = int.Parse(boshNum);

            for (int i = 1; i <= inputNumInt; i++)
            {
                if (i % bishNumInt == 0)
                {
                    Console.Write("Bish ");
                }
                else if (i % boshNumInt == 0)
                {
                    Console.Write("Bosh ");
                }
                else if (i % bishNumInt == 0 && i % bishNumInt == 0)
                {
                    Console.Write("Bish-Bosh ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }


                
            }

            Console.ReadLine();
        }   
    }
}
