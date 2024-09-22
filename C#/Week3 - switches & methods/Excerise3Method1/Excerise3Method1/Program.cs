namespace Excerise3Method1
{
    internal class Program
    {
        /*
        ◦ Skriv ett program med en Main enligt:
public static void Main()
{
SayHello();
SayGoodbye();
}
◦ Skriv metoderna SayHello() och SayGoodbye()
◦ Lägg till att du kan skriva in ditt namn, och få en personlig hälsning*/

    
   
       //metod för say hello
       public static void SayHello()
        {
            Console.WriteLine("Skriv ditt namn: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}! Välkommen till program.");
        }
        //metod för say goodbye
        public static void SayGoodbye()
        {
            Console.WriteLine("Skriv ditt namn: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Goodbye{name}!ha det bra.");
        }

        //main metod 
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();

            Console.ReadLine();
        }
    }
}
