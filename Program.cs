using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are higher \nThan the Heat Index!!!\n");
int GameCoins = 100;


Console.WriteLine("You have " + GameCoins + " game coins to start with.\n\n");
Console.WriteLine("*** How to Win ***");
Console.WriteLine("You can play center line for 1\nYou can play the 3 vertical or 3 horizontal lines for 3\nYou can play both diaganols for 5\n");

while (GameCoins > 0)
{
    Console.WriteLine("Which way would you like to play?\n");
    Console.WriteLine($"You currently have {GameCoins}");
    Console.WriteLine("\nPress:\nC for Center Row\nV for Vertical Lines\nH for Horizontal Lines\nD for Diaganol\n");
    string choices = Console.ReadLine().ToLower();
    Console.WriteLine("");

    if (choices != "c" && choices != "d" && choices != "v" && choices != "h")
    {
        Console.WriteLine("Please choose between C, V, H, or D.");
    }
    else
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
        Console.WriteLine($"\nYou have " + GameCoins + " coins left." );
    }
if (GameCoins > 0)
    {
        Console.WriteLine("\nDo you want to play again? (Y/N)");
        string playAgain = Console.ReadLine().ToLower();
        if(playAgain != "y")
        {
            break;
        }
    }
}