using System.Security.Cryptography.X509Certificates;

namespace Excerise1Scope1
{
    internal class Program
    {
        // Enum for different parts
        public enum UnderredeTyp { Rostfritt, Stål }
        public enum DäckTyp { Dubbdäck, Sommardäck }
        public enum InredningTyp { Läder, Tyg }
        public enum Färgtyp { Röd, Blå, Svart, Vit }

        // Create a single Random instance
        private static Random random = new Random();

        // Method to simulate building time
        private static int ByggTid(int min, int max)
        {
            int tid = random.Next(min, max);
            Task.Delay(tid * 1000).Wait(); // Delay in seconds
            return tid;
        }

        // Method for undercarriage
        public static (UnderredeTyp underrede, int tid) ByggUnderrede()
        {
            int tid = ByggTid(5, 11);
            return ((UnderredeTyp)random.Next(0, 2), tid);
        }

        // Method for wheels
        public static (int antalHjul, DäckTyp däcktyp, int tid) ByggHjul()
        {
            int antalHjul = random.Next(3, 5);
            DäckTyp däcktyp = (DäckTyp)random.Next(0, 2);
            int tid = ByggTid(3, 8);
            return (antalHjul, däcktyp, tid);
        }

        // Method for engine
        public static (int hästkrafter, int tid) ByggMotor()
        {
            int hästkrafter = random.Next(75, 401);
            int tid = ByggTid(10, 16);
            return (hästkrafter, tid);
        }

        // Method for interior
        public static (InredningTyp inredning, int tid) ByggInredning()
        {
            int tid = ByggTid(2, 6);
            return ((InredningTyp)random.Next(0, 2), tid);
        }

        // Method for color
        public static (Färgtyp kaross, int tid) ByggKaross()
        {
            int tid = ByggTid(4, 9);
            return ((Färgtyp)random.Next(0, 4), tid); // Corrected range for Färgtyp
        }

        // Method to assemble car
        public static void ByggBil()
        {
            var (underrede, underredeTid) = ByggUnderrede();
            var (antalHjul, däckTyp, hjulTid) = ByggHjul();
            var (motor, motorTid) = ByggMotor();
            var (inredning, inredningTid) = ByggInredning();
            var (kaross, karossTid) = ByggKaross();

            // Total time calculation
            int totalTid = underredeTid + hjulTid + motorTid + inredningTid + karossTid;

            // Output car details
            Console.WriteLine($"En bil med {underrede} underrede, {antalHjul} hjul, {motor} hästkrafter, {inredning} klädsel med {kaross} lack, som tog {totalTid} minuter att bygga.");
            Console.WriteLine("Bilen har byggts med följande delar:");
            Console.WriteLine($"Underrede: {underrede}");
            Console.WriteLine($"Antal hjul: {antalHjul}, Däcktyp: {däckTyp}");
            Console.WriteLine($"Motor: {motor} hästkrafter");
            Console.WriteLine($"Inredning: {inredning}");
            Console.WriteLine($"Kaross: {kaross} lack");
        }

        // Main method 
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Bygger bil {i + 1}");
                ByggBil();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();



        }
    }
}
