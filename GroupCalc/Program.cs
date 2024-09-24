namespace GroupCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ViewDisplay();
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
                        Console.WriteLine("Svaret är " + Addition(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Svaret är " + Subtraction(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Svaret är " + Multiplicate(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Svaret är " + Divide(a, b));
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

        static double Divide(int number, int divider)
        {
            int quota = number / divider;
            return quota;
        }

        static void ViewDisplay()
        {
            string[][] display = new string[5][];

            string[][] test = 
            {
                new string[]
                {
                    "XXXXX",
                    "X   X",
                    "X i X",
                    "X   X",
                    "XXXXX",
                },
                new string[]
                {
                    " XX  ",
                    "X X  ",
                    "  X  ",
                    "  X  ",
                    "XXXXX"
                }
            };
            string[] testigen = ["XXXXX", "X   X", "X   X", "X   X", "XXXXX"];
            int slot = 0;
            
            while(slot <= 1)
            {

            ConsoleKeyInfo cki = Console.ReadKey(true);



            if(cki.Key == ConsoleKey.D0)
            {
                for(int i = 0; i < 5; i++)
                {
                    test[slot][i] = testigen[i];
                }
                
            }
                slot++;

                
            }
            
            

            // display = DisplayNumber(cki);

            for (int i = 0; i < 5; i++)
            {
                for (int column = i; column <= i; column++)
                {
                    Console.Write(test[0][i]);
                    Console.Write(" ");
                    Console.Write(test[1][i]);
                }


                Console.WriteLine(" ");
               
                // Console.Write(what);
                
                
            }




        }

        

        static string[][] DisplayNumber(ConsoleKeyInfo x)
        {
            string[][] convert = new string[5][];

            switch (x.Key)
            {
                case ConsoleKey.D0:

                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = ["X", " ", " ", " ", "X"];
                    convert[2] = ["X", " ", " ", " ", "X"];
                    convert[3] = ["X", " ", " ", " ", "X"];
                    convert[4] = ["X", "X", "X", "X", "X"];


                    break;

                case ConsoleKey.D1:

                    convert[0] = [" ", " ", "X", " ", " "];
                    convert[1] = [" ", "X", "X", " ", " "];
                    convert[2] = [" ", " ", "X", " ", " "];
                    convert[3] = [" ", " ", "X", " ", " "];
                    convert[4] = [" ", "X", "X", "X", " "];


                    break;

                case ConsoleKey.D2:

                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = [" ", " ", " ", " ", "X"];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = ["X", " ", " ", " ", " "];
                    convert[4] = ["X", "X", "X", "X", "X"];


                    break;
                case ConsoleKey.D3:

                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = [" ", " ", " ", " ", "X"];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = [" ", " ", " ", " ", "X"];
                    convert[4] = ["X", "X", "X", "X", "X"];

                    break;
                case ConsoleKey.D4:
                    convert[0] = ["X", " ", " ", " ", "X"];
                    convert[1] = ["X", " ", " ", " ", "X"];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = [" ", " ", " ", " ", "X"];
                    convert[4] = [" ", " ", " ", " ", "X"];
                    break;

                case ConsoleKey.D5:
                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = ["X", " ", " ", " ", " "];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = [" ", " ", " ", " ", "X"];
                    convert[4] = ["X", "X", "X", "X", "X"];
                    break;

                case ConsoleKey.D6:
                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = ["X", " ", " ", " ", " "];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = ["X", " ", " ", " ", "X"];
                    convert[4] = ["X", "X", "X", "X", "X"];
                    break;

                case ConsoleKey.D7:
                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = [" ", " ", " ", " ", "X"];
                    convert[2] = [" ", " ", " ", " ", "X"];
                    convert[3] = [" ", " ", " ", " ", "X"];
                    convert[4] = [" ", " ", " ", " ", "X"];
                    break;
                case ConsoleKey.D8:
                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = ["X", " ", " ", " ", "X"];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = ["X", " ", " ", " ", "X"];
                    convert[4] = ["X", "X", "X", "X", "X"];
                    break;
                case ConsoleKey.D9:
                    convert[0] = ["X", "X", "X", "X", "X"];
                    convert[1] = ["X", " ", " ", " ", "X"];
                    convert[2] = ["X", "X", "X", "X", "X"];
                    convert[3] = [" ", " ", " ", " ", "X"];
                    convert[4] = [" ", " ", " ", " ", "X"];
                    break;
                default:
                    break;


            }



            return convert;
        }
    }
}
