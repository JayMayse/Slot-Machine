namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are higher \nThan the Heat Index!!!\n");

            const int HOU7 = 713;
            const int HOU2 = 281;
            const int HOU8 = 832;
            const int HOU3 = 346;
             
            Console.WriteLine("Let's get you some coins to play with!\nPlease enter a number from 1 to 5");
            Console.ReadLine();

            int[] minas = new int[4] { HOU7, HOU2, HOU8, HOU3 };
            Random rng = new Random();
            int randomMinas = rng.Next(0, 4);
            int GameCoins = minas[randomMinas];


            Console.WriteLine("You have " + GameCoins + " game coins to play with.\n\n");
            //allot coins randomly

            Console.WriteLine("You can play center line for 1\nYou can play all 3 lines for 3\n");


            Console.WriteLine("*** How to WIn ***");
            Console.WriteLine("3x 713 wins $50\n3x 281 wins $35\n3x area codes# wins $30\n3x any other number wins $25");
            Console.WriteLine("713 + 2x any other wins $20\n2x area code# wins $15\narea code# +2x any other number wins 10\n2x any number wins $5");

            // insert array set up with 3x3 vertical
            //int[,] slots = new int [3,3];

            int nulo = 0;
            int un = 1;
            int duex = 2;


            if (GameCoins > 0)
            {

                int[] bangers = new int[11] { 1, 2, 3, 4, 6, 7, 8, 832, 281, 713, 346 };
                Random rngspoke = new Random();
                int clicks = rngspoke.Next(0, 10);
                //int GameWheel = bangers[clicks];

                //if (i = 0; 1 < x; i++)

                //int[,] slots = new int[3, 3];
                int[,] slots =    { {clicks, clicks, clicks}, 
                                    {clicks, clicks, clicks}, 
                                    {clicks, clicks, clicks},

                                   };

                for (int i = 0; i < slots.GetLength(0); i++ )
                {
                    for (int j = 0; j < slots.GetLength(1); j++)
                    {
                        Console.Write(slots[i,j] + "");
                    }
                    Console.WriteLine();
                };
                //int randomnumber = 7;

                //slots[0, 0] = randomnumber;


                Console.WriteLine(slots[nulo, nulo]);
                Console.WriteLine(slots[un, nulo]);
                Console.WriteLine(slots[duex, nulo]);
                Console.WriteLine("");
                Console.WriteLine(slots[un, nulo]);
                Console.WriteLine(slots[un, un]);
                Console.WriteLine(slots[un, duex]);
                Console.WriteLine("");
                Console.WriteLine(slots[duex, nulo]);
                Console.WriteLine(slots[duex, un]);
                Console.WriteLine(slots[duex, duex]);

            }
            //display coin count

            //ask how many coins to play

            //run slot

            //if statement on slot results

            //loop 


        }
    }
}
