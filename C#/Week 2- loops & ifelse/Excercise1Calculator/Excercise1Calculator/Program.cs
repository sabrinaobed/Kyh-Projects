namespace Excercise1Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange första talet: ");
            string firstNum = Console.ReadLine();
            decimal firstNumD = decimal.Parse(firstNum);

            Console.WriteLine("Ange andra talet: ");
            string secondNum = Console.ReadLine();
            decimal secondNumD = decimal.Parse(secondNum);


            //Summa
            Console.WriteLine("Summa talen " + (firstNumD + secondNumD));

            //Subtrahera
            Console.WriteLine("Subtrahera talen " + (firstNumD - secondNumD));

            //Dela
            Console.WriteLine("Dela talen " + (firstNumD / secondNumD));

            //Modulus
            Console.WriteLine("Modulus talen " + (firstNumD % secondNumD));

            Console.ReadLine();


        }
    }
}
