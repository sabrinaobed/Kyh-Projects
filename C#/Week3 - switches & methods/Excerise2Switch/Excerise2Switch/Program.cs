namespace Excerise2Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop för våningar 0 till 4
            for (int floor = 0; floor <= 4; floor++)
            {
                //stimularar hissen 
                Console.WriteLine($"Hissen stimularar till våningen {floor}");
                Thread.Sleep( 1000 );

                //använd sitch sats för att skriva ut för värje våning
                switch(floor )
                {
                    case 0:
                        Console.WriteLine("Våningen 0: Entre plan");
                        break;
                    case 1:
                        Console.WriteLine("Våningen 1: Säljavdelning");
                        break;
                    case 2:
                        Console.WriteLine("Våningen 2: IT avdelning");
                        break;
                    case 3:
                        Console.WriteLine("Våningen 3: Pröjekt-ledning");
                        break;
                    case 4:
                        Console.WriteLine("Våningen 4: Chefen");
                        break;
                }
                Console.WriteLine();
            }
            //vänta för användarinput innan du lämnar
            Console.WriteLine("Tryck på enter för att avsluta..");
            Console.ReadLine();

        }
    }
}
