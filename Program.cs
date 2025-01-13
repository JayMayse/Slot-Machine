using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("Greetings All!!  \nWelcome to the Houston Slots\nWhere your Chances of Winning are higher \nThan the Heat Index!!!\n");

//char("C") = Center
//char('r') = Rows
//char('d') - Diagonal


//int[] minas = new int[4] { HOU7, HOU2, HOU8, HOU3 };
//Random rng = new Random();
//int randomMinas = rng.Next(0, 3);
//int GameCoins = minas[randomMinas];
int GameCoins = 100;


Console.WriteLine("You have " + GameCoins + " game coins to play with.\n\n");
Console.WriteLine("You can play center line for 1\nYou can play all 3 lines for 3\nYou can play the diaganol for 5\n");
Console.WriteLine("*** How to Win ***");

if (GameCoins > 0)
{
    Console.WriteLine("Which way would you like to play?");
    Console.WriteLine("Press:\nC for Center\nL for Lines\nD for Diaganol");
    string choices = Console.ReadLine().ToLower();

    if (choices != "c" && choices != "d" && choices != "r")
    {
        Console.WriteLine("Please choose between C, R, or D.");
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

        bool isWinner = false;
        if (choices == "c")
        for (int col = 1; col < slots.GetLength(1); col++)
        {

            if (slots[1, 0] == slots[1, col])
            {
                isWinner = true;
                Console.WriteLine("Congratulations! You won the center line");
                GameCoins += 1;
                break;
            }
                if (!isWinner)
                {
                    Console.WriteLine("Sorry, you failed.");
                }
                else if (choices == "l")
                    for (int row = 0; row < slots.GetLength(0); row++)
                    {
                        for (int row = 0; col < slots.GetLength(1); row++)

                            if (slots[row, 0] == slots[row, 1] && slots[row, 0] == slots[row, 2])
                            {
                                Console.WriteLine("Congratulations you won on the lines");
                                isWinner = true;
                                GameCoins += 3;
                                break;
                            }
                        if (!isWinner)
                        {
                            Console.WriteLine("Sorry, you have failed");
                        }
                        else if (choices == "d")
                            if (slots[0, 0] == slots[1, 1] && (slots[0, 0]) == slots[2, 2])
                            {
                                Console.WriteLine("Congratulations you won on the diaganol");
                                isWinner = true;
                                GameCoins += 5;
                                break;
                            }
                    }


                        //if (slots[0, 0] == slots[1, 1]) == slots[2, 2]);
                        //}
                        //bool isWinner1 = true;

                        //for (int row = 1; row < slots.GetLength(1); row++)
                        //{

                        //    if (slots[1, 0] != slots[1, row])
                        //    {
                        //        isWinner1 = false;
                        //        Console.WriteLine("You have FAILED!");
                        //    }

                        //}

                        //
                        //{
                        //    //win
                        //}
        }

    }
}

//void ifelse(bool v)
//{
//    throw new NotImplementedException();
//    }