


string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool player1Turn = true;
bool gameOver = false;
bool player2Turn = false;

while (!gameOver)
{
    printBoard();
    if(player1Turn == true)
    {
        Console.WriteLine("Player 1 turn!");
    }
    else
    {
        Console.WriteLine("Player 2 turn!");
    }
    string choice = Console.ReadLine();

    if (grid.Contains(choice) && choice != "X" && choice != "O")
    {
        int gridChoice = int.Parse(choice);
        if (player1Turn == true)
        {
            grid[gridChoice - 1] = "X";
            player1Turn = false;
            player2Turn = true;

            if(checkVictory())
            {
                Console.WriteLine("Player 1 wins!");
                gameOver = true;
            }
            
        }
        else
        {
            grid[gridChoice - 1] = "0";
            player1Turn = true;
            player2Turn = false;

            if (checkVictory())
            {
                Console.WriteLine("Player 2 wins!");
                gameOver = true;
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid move!");


    }
    
}

bool checkVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];

    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];

    bool diag1 = grid[0] == grid[4] && grid[4] == grid[8];
    bool diag2 = grid[2] == grid[4] && grid[4] == grid[6];

    if (row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2)
    {
        return true;
    }
    else
    {
        return false;
    }
}



void printBoard()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write("|" + grid[i * 3 + j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("----------");
    }
}



