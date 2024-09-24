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
                int a = SelectNumber();
                Console.WriteLine("Skriv ditt andra tal.");
                int b = SelectNumber();
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
                        Console.WriteLine("Svaret är " + Addition(a,b));
                        break;
                    case 2:
                        Console.WriteLine("Svaret är " + Subtraction(a,b));
                        break;
                    case 3:
                        Console.WriteLine("Svaret är " + Multiplicate(a,b));
                        break;
                    case 4:
                        Console.WriteLine("Svaret är " + Divide(a,b));
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
        static int SelectNumber()
        {
            char[,] numpad = new char[,]
            {
                { '7', '8', '9' },
                { '4', '5', '6' },
                { '1', '2', '3' },
                { ' ', '0', ' ' }
            };

            int selectedNumber = -1; // Keep track of which number is highlighted
            bool selecting = true;

            while (selecting)
            {
                Console.Clear();
                Console.WriteLine("Tryck på en siffra (0-9) och tryck på Enter för att bekräfta.");

                // Display numpad and highlight the selected number
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (selectedNumber == (numpad[i, j] != ' ' ? int.Parse(numpad[i, j].ToString()) : -1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green; // Highlight selected number
                        }
                        else
                        {
                            Console.ResetColor();
                        }

                        Console.Write(numpad[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();

                // Read user input
                var keyPressed = Console.ReadKey(true);
                
                // Check if it's a number key
                if (char.IsDigit(keyPressed.KeyChar))
                {
                    selectedNumber = int.Parse(keyPressed.KeyChar.ToString()); // Highlight the number
                }
                else if (keyPressed.Key == ConsoleKey.Enter && selectedNumber != -1)
                {
                    selecting = false; // Confirm the selection when Enter is pressed
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen välj ett nummer mellan 0 och 9.");
                }
            }

            return selectedNumber;
        }
    }
}
