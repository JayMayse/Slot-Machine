﻿namespace Slot_Machine
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

            int[] minas = new int [4] {HOU7, HOU2, HOU8, HOU3};
            Random rng = new Random();
            int randomMinas = rng.Next(0, 5);
            int GameCoins = minas[randomMinas];


            Console.WriteLine("You have " + GameCoins + " game coins to play with.\n\n");
            //allot coins randomly

            Console.WriteLine("You can play center line for 1\nYou can play all 3 lines for 3\n");

            //numbers in the array[1, 2 3, 4, 6, 7, 8, 832, 281, 713, 346]
             Console.WriteLine("*** How to WIn ***");
            Console.WriteLine("3x 713 wins $50\n3x 281 wins $35\n3x area codes# wins $30\n3x any other number wins $25\n713 + 2x any other wins $20\n2x area code# wins $15\narea code# +2x any other number wins 10\n2x any number wins $5");

            // insert array set up with 3x3 vertical
            int [,] slots = new int [3,3];

            //display coin count

            //ask how many coins to play

            //run slot

            //if statement on slot results

            //loop 


         }
    }
}
