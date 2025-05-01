using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are higher \nThan the Heat Index!!!\n");

const int BUCKETS = 100;
int gameCoins = BUCKETS;
const int tres = 3;
const int cinco = 5;
const int sete = 7;
const int deca = 10;
const int centMinus = 1;
const int centPlus = 2;
const int vertMinus = 3;
const int vertPlus = 6;
const int diagMinus = 5;
const int diagPlus = 10;
const int nullCoin = 0;


while (true)
{
    Console.WriteLine($"\nYou have {gameCoins} game coins to start with.\n");
    Console.WriteLine("*** How to Win ***");
    Console.WriteLine("You can play center line for 1\nYou can play the 3 vertical or 3 horizontal lines for 3\nYou can play both diagonals for 5\n");
    Console.WriteLine("\nPress:\nC for Center Row (1 coin)\nV for Vertical Lines (3 coins)\nH for Horizontal Lines (3 coins)\nD for Diagonal (5 coins)\n");

     string choices = Console.ReadLine().ToLower();
    if (choices != "c" && choices != "d" && choices != "v" && choices != "h")
    {
        Console.WriteLine("Please choose between C, V, H, or D.");
        continue;
    }

    Console.Write("\nHow big of a grid do you want to work with? (3, 5, or 7): ");
    if (!int.TryParse(Console.ReadLine(), out int grid) || (grid != tres && grid != cinco && grid != sete))
    {
        Console.WriteLine("Invalid grid size! Please enter 3, 5, or 7.");
        continue;
    }

    Random rngspoke = new Random();
    int[,] slots = new int[grid, grid];

    for (int row = 0; row < grid; row++)
    {
        for (int col = 0; col < grid; col++)
        {
            slots[row, col] = rngspoke.Next(deca);
            //slots[row, col] = 1;
            Console.Write(slots[row, col]);
        }
        Console.WriteLine();
    }

    bool isWinner = false;

    if(choices == "c")
{
        gameCoins -= centMinus;
        int midRow = grid / 2;
        bool center = true;
        for (int col = 1; col < grid; col++)
        {
            if (slots[midRow, col] != slots[midRow, 0])
            {
                center = false;
                break;
            }
        }
        if (center)
        {
            Console.WriteLine("Congratulations! You won the center line");
            gameCoins += centPlus;
            isWinner = true;
        }
    }
    else if (choices == "v")
    {
        gameCoins -= vertMinus;
        for (int col = 0; col < grid; col++)
        {
            bool colMatch = true;
            for (int row = 1; row < grid; row++)
            {
                if (slots[row, col] != slots[0, col])
                {
                    colMatch = false;
                    break;
                }
            }
            if (colMatch)
            {
                Console.WriteLine("Congratulations! You won on a vertical line");
                gameCoins += vertPlus;
                isWinner = true;
                break;
            }
        }
    }
    else if (choices == "h")
    {
        gameCoins -= vertMinus;
        for (int row = 0; row < grid; row++)
        {
            bool rowMatch = true;
            for (int col = 1; col < grid; col++)
            {
                if (slots[row, col] != slots[row, 0])
                {
                    rowMatch = false;
                    break;
                }
            }
            if (rowMatch)
            {
                Console.WriteLine("Congratulations! You won on a horizontal line");
                gameCoins += vertPlus;
                isWinner = true;
                break;
            }
        }
    }

    else if (choices == "d")
    {
        gameCoins -= diagMinus;
        bool leftDiag = true;
        for (int i = 1; i < grid; i++)
        {
            if (slots[i, i] != slots[0, 0])
            {
                leftDiag = false;
                break;
            }
        }

        bool rightDiag = true;
        for (int i = 1; i < grid; i++)
        {
            if (slots[i, grid - 1 - i] != slots[0, grid - 1])
            {
                rightDiag = false;
                break;
            }
        }

        if (leftDiag || rightDiag)
        {
            Console.WriteLine("Congratulations! You won on the diagonal");
            gameCoins += diagPlus;
            isWinner = true;
        }
    }



    if (gameCoins <= nullCoin)
    {
        Console.WriteLine("You're out of coins. Thanks for playing!");
        break;
    }

    Console.WriteLine("\nDo you want to play again? (Y/N)");
    string playAgain = Console.ReadLine().ToLower();
    if (playAgain != "y")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }
}
