using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are higher \nThan the Heat Index!!!\n");
// starting game coins
const int BUCKETS = 100;
int GameCoins = BUCKETS;


Console.WriteLine("You have " + GameCoins + " game coins to start with.\n\n");
Console.WriteLine("*** How to Win ***");
Console.WriteLine("You can play center line for 1\nYou can play the 3 vertical or 3 horizontal lines for 3\nYou can play both diaganols for 5\n");
Console.WriteLine("\nPress:\nC for Center Row (1 coin)\nV for Vertical Lines (3 coins)\nH for Horizontal Lines (3 coins)\nD for Diagonal (5 coins)\n");
string choices = Console.ReadLine().ToLower();
if (choices != "c" && choices != "d" && choices != "v" && choices != "h")
{
    Console.WriteLine("Please choose between C, V, H, or D.");
}
//Console.WriteLine("");
//grid = int grid (square);
else
{
    Console.Write("\nHow big of a grid do you want to work with? (3, 5, or 7): ");
    if (!int.TryParse(Console.ReadLine(), out int grid) || (grid != 3 && grid != 5 && grid != 7))
    {
        Console.WriteLine("Invalid grid size! Please enter 3, 5, or 7.");
    }
    else
    {
        Random rngspoke = new Random();
        int[,] slots = new int[grid, grid];

        for (int row = 0; row < slots.GetLength(0); row++)
        {
            for (int col = 0; col < slots.GetLength(1); col++)
            {
                slots[row, col] = rngspoke.Next(10);
                Console.Write(slots[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("");


        bool isWinner = false;
        if (choices == "c")
        {
            GameCoins -= 1;
            if (slots[1, 0] == slots[1, 1] && slots[1, 0] == slots[1, 2])
            {
                Console.WriteLine("Congratulations! You won the center line");
                GameCoins += 2;
                isWinner = true;
                break;
            }
            if (!isWinner)
            {
                Console.WriteLine("Sorry, you failed.");
            }
        }
        else if (choices == "v")
        {
            GameCoins -= 3;
            for (int col = 0; col < slots.GetLength(0); col++)
            {
                if (slots[0, col] == slots[1, col] && slots[0, col] == slots[2, col])
                {
                    Console.WriteLine("Congratulations you won on the Vertical lines");
                    isWinner = true;
                    GameCoins += 6;
                    break;
                }
            }
            if (!isWinner)
            {
                Console.WriteLine("SOrry, you have failed");
            }
        }
        else if (choices == "h")
        {
            GameCoins -= 3;
            for (int row = 0; row < slots.GetLength(0); row++)
            {
                if (slots[row, 0] == slots[row, 1] && slots[row, 0] == slots[row, 2])
                {
                    Console.WriteLine("Congratulations you won on the Vertical lines");
                    isWinner = true;
                    GameCoins += 6;
                    break;
                }
            }
            if (!isWinner)
            {
                Console.WriteLine("SOrry, You have failed");
            }
        }
        else if (choices == "d")
        {
            GameCoins -= 5;
            if (slots[0, 0] == slots[1, 1] && (slots[0, 0]) == slots[2, 2])
            {
                Console.WriteLine("Congratulations you won on the diaganol");
                GameCoins += 10;
                isWinner = true;
                break;
            }
            if (slots[0, 2] == slots[1, 1] && (slots[0, 2]) == slots[2, 0])
            {
                Console.WriteLine("Congratulations you won on the diaganol");
                GameCoins += 10;
                isWinner = true;
                break;
            }
            if (!isWinner)
            {
                Console.WriteLine("SOrry, you have FAiled");
            }
        }
        Console.WriteLine($"\nYou have " + GameCoins + " coins left.");
    }
    if (GameCoins > 0)
    {
        Console.WriteLine("\nDo you want to play again? (Y/N)");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain != "y")
        {
            break;
        }
    }
}
    
