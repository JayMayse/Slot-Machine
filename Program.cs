using System.Diagnostics;
using System.Runtime.InteropServices;

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
            //  int col = 0;

            Console.WriteLine("Let's get you some coins to play with!\nPlease enter a number from 1 to 5");
            Console.ReadLine();

            int[] minas = new int[4] { HOU7, HOU2, HOU8, HOU3 };
            Random rng = new Random();
            int randomMinas = rng.Next(0, 3);
            int GameCoins = minas[randomMinas];

            Console.WriteLine("You have " + GameCoins + " game coins to play with.\n\n");
            Console.WriteLine("You can play center line for 1\nYou can play all 3 lines for 3\n");
            Console.WriteLine("*** How to Win ***");
            //Console.WriteLine("3x 713 wins $50\n3x 281 wins $35\n3x area codes# wins $30\n3x any other number wins $25");
            //Console.WriteLine("713 + 2x any other wins $20\n2x area code# wins $15\narea code# +2x any other number wins 10\n2x any number wins $5");

            if (GameCoins > 0)
            {
                Random rngspoke = new Random();
                int clicks1 = rngspoke.Next(0, 10);
                int clicks2 = rngspoke.Next(0, 10);
                int clicks3 = rngspoke.Next(0, 10);
                int[,] slots = new int[3, 3];

                for (int row = 0; row < slots.GetLength(0); row++)
                {
                    for (int col = 0; col < slots.GetLength(1); col++)
                    {
                        slots[row, col] = rngspoke.Next(10);
                        Console.Write(slots[row, col]);

                    }

                    Console.WriteLine();
                }

                bool isWinner = true;

                for (int col = 1; col < slots.GetLength(1); col++)
                {

                    if (slots[1, 0] != slots[1, col])
                    { 
                        isWinner = false;
                      //Console.WriteLine("Looks like we got a winner!");
                    }

                }

                //if (slots[1,0] == slots[1,1] && slots[1,0] == slots[1,2])
                //{
                //    //win
                //}



            }
        }
    }
}
