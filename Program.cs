namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are better \nthan Your Chances of Passing Out from the Heat\n");

            //coins for players
            int [] minas = new int [4];
                
            //    [713, 281, 832, 346]

            //allot coins randomly

            Console.WriteLine("You can play center line for $1\nYou can play all 3 lines for $3\n");

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
