namespace Execerise4ConsoleColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Windows-konsollen ser normal lite tråkig ut, men det går att göra en del saker.
            // Titta på Console Class(System) | Microsoft Doc
            //◦ Ändra properties:
            //◦ T ex bakgrundsfärgen till Röd
            //◦ Ändra förgrundsfärgen till Svart


            //Ändra bakgrundsfärg till röd och förgrundsfärg till svart
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            //Rensa konsolen och applicera ny färg
            Console.Clear();
            Console.WriteLine("Text med röd bakgrundsfärg och svart förgrundsfärg");

            //Återställ färgen till standaradinställningarna(default settings)
            Console.ResetColor();


            Console.ReadLine();
        }
    }
}
