using System;
using System.Threading;
namespace TIC_TAC_TOE
{
    class Program
    {
        //making array and
        //by default I am providing 0-9 where no use of zero
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set
        static int choice; //This holds the choice at which position user want to mark
        // The flag variable checks who has won if it's value is 1 then someone has won the match
        //if -1 then Match has Draw if 0 then match is still running
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function
                choice = int.Parse(Console.ReadLine());//Taking users choice
                // checking that position where user want to run is marked (with X or O) or not
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                //If there is any position where user want to run
                //and that is already marked then show message and load board again
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// calling of check win
            }
            while (flag != 1 && flag != -1);
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board();// getting filled board again
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Board method which create board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not
        private static int CheckWin()
        {
            #region Horizontal Winning Condition
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region Vertical Winning Condition
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}



// namespace TicTacToe;

// class Program
// {
//     static char[,] board = new char[3, 3]; // 3x3 Tic-Tac-Toe board
//     static char currentPlayer = 'X'; // 'X' starts the game

//     static void Main(string[] args)
//     {
//         InitializeBoard();
//         int input1 = 0, input2 = 0;
//         while(true)
//         {
//             DrawBoard();
//             Console.WriteLine($"Player {currentPlayer}'s turn. Enter row: ");
//             input1 = Convert.ToInt32(Console.ReadLine());
//             int row = (input1) - 1;
//             Console.WriteLine($"Player {currentPlayer}'s turn. Enter column: ");
//             input2 = Convert.ToInt32(Console.ReadLine());
//             int col = (input2) - 1;

//             if (IsValidMove(row, col))
//             {
//                 board[row, col] = currentPlayer;

//                 if (CheckWin())
//                 {
//                     DrawBoard();
//                     Console.WriteLine($"Player {currentPlayer} wins!");
//                     break;
//                 }

//                 if (IsBoardFull())
//                 {
//                     DrawBoard();
//                     Console.WriteLine("Its a draw!");
//                     break;
//                 }

//                 currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; //switch players
//             }

//             else
//             {
//                 Console.WriteLine("Invalid move. Try again.");
//             }
//         }
//     }

//     static void InitializeBoard()
//     {
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; i < 3; j++)
//             {
//                 board[i, j] = '-';
//             }
//         }
//     }

//     static void DrawBoard()
//     {
//         Console.WriteLine(" 1 2 3");
//         for (int i = 0; i < 3; i++)
//         {
//             Console.Write($"{i + 1} ");
//             for (int j = 0; j < 3; j++)
//             {
//                 Console.WriteLine($"{board[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }

//     static bool IsValidMove(int row, int col)
//     {
//         return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '-';
//     }

//     static bool CheckWin()
//     {
//         // Check rows
//         for (int i = 0; i <3; i++)
//         {
//             if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
//             {
//                 return true;
//             }
//         }

//         // Check columns
//         for (int j = 0; j < 3; j++)
//         {
//             if (board[0, j] != '-' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
//             {
//                 return true;
//             }
//         }

//         // Check diagonals
//         if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
//         {
//             return true;
//         }
//         if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
//         {
//             return true;
//         }

//         return false;
//     }

//     static bool IsBoardFull()
//     {
//         for (int i = 0; i < 3; i++)
//         {
//             for(int j = 0; j < 3; j++)
//             {
//                 if (board[i, j] == '-')
//                 {
//                     return false;
//                 }
//             }
//         }
//         return true;
//     }
// }



// namespace Tic_Tac_Toe;

// class Program
// {
//     static void play()
//     {

//         int p1=0;
//         int p2=0;
//         bool result = false;
//         int pos[] = 
        
//         while(result != false)
//         {
//             Console.Write("Enter your position for player 1: ");
//             int pos1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("                   |                     |                    ");
//             Console.WriteLine("    " + a1 + "     |      " + a2 + "     |      " + a3 + "    ");
//             Console.WriteLine("                   |                     |                    ");
//             Console.WriteLine("--------------------------------");
//             Console.WriteLine("                   |                     |                    ");
//             Console.WriteLine("    " + b1 + "     |      " + b2 + "     |      " + b3 + "    ");
//             Console.WriteLine("                   |                     |                    ");
//             Console.WriteLine("--------------------------------");
//             Console.WriteLine("                   |                     |                    ");
//             Console.WriteLine("    " + c1 + "     |      " + c2 + "     |      " + c3 + "    ");
//             Console.WriteLine("                   |                     |                    ");
//         }
//         Console.WriteLine("Congratulation " + winner + " you have won the match");
//     }
//     static void Main(string[] args)
//     {
//         // char p1,p2,x = "X",o = "O";
//         Console.WriteLine("Welcome Players for a match of Tic-Tac-Toe");
//         int ch=0;

        
//         while(ch!=2)
//         {
//             Console.WriteLine("1. Play");
//             Console.WriteLine("2. Exit");
//             Console.Write("What would you like to do: ");
//             ch = Convert.ToInt32(Console.ReadLine());

//             switch(ch)
//             {
//                 case 1:
//                     play();
//                     break;
//                 case 2:
//                     Console.WriteLine("Thank you for playing the game.");
//                     break;
//                 default:
//                     Console.WriteLine("Enter a valid number!");
//                     break;
//             }
//         }
//     }
// }