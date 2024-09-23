namespace GroupCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                Console.WriteLine("Välkommen till GJD's fräcka kalkylator!");
                Console.WriteLine("Välj två tal och sedan vad du ska göra med dom. Skriv ditt första tal");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv ditt andra tal.");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Välj ett menyalternativ!");
                Console.WriteLine("" +
                    "1: Addition \n" +
                    "2: Subtratktion \n" +
                    "3: Multiplikation \n" +
                    "4: Division \n" +
                    "5: Avsluta");
                int svar = Convert.ToInt32(Console.ReadLine());

                switch (svar)
                {
                    case 1:
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Du måste välja ett alternativ");
                        break;

                }
            }
        }
        public static int Subtraction(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
      
        public static int Subtraction(int a, int b)
        {
            int sum = a - b;
            return sum;
        }

        static int Multiplicate(int firstNum, int secondNum)
        {
            int product = firstNum * secondNum;
            return product;
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
