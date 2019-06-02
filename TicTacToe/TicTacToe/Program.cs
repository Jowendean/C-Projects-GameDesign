using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a 2D array for the game board
            char[,] board =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };

            // create players
            char player1;
            char player2;
            string playerOneName;
            string playerTwoName;
            int playerSelect;
            int playAgain = -1;
            string input;
            bool winner;

            // get the player names
            Console.WriteLine("Lets Play Tic Tac Toe!");
            Console.WriteLine("Please enter Player One's name: ");
            playerOneName = Console.ReadLine();
            Console.WriteLine("Please enter Player Two's name: ");
            playerTwoName = Console.ReadLine();

            // display the game board
            GridLines(board);

            while (playAgain == -1)
            { 
                //Play the game
                // determine which player goes first
                playerSelect = GoFirst();
                if (playerSelect == 0)
                {
                    Console.WriteLine("Player One Goes First!!!");
                    player1 = 'X';
                    player2 = 'O';
                    winner = false;
                    while (winner == false)
                    {
                        winner = GamePlay(board, player1, player2, playerOneName, playerTwoName);
                    }
                }
                else
                {
                    Console.WriteLine("Player Two Goes First!!!");
                    player1 = 'O';
                    player2 = 'X';
                    winner = false;
                    while (winner == false)
                    {
                        winner = GamePlay(board, player2, player1, playerTwoName, playerOneName);
                    }
                }

                Console.WriteLine("Do you want to play another game?");
                Console.WriteLine("Enter -1 to play again or any other key to exit the program");
                input = Console.ReadLine();
                int.TryParse(input, out playAgain);
                if(playAgain == -1)
                {
                    // reset the game board and player again
                    Reset(board);
                }
                else
                {
                    // exit the program
                    Console.WriteLine("Now exiting the program....Thanks for playing!");
                    break;
                }
                
            }
            Console.ReadKey();
        }

        static void GridLines(char[,] b)
        {
            Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} | {1}  | {2} ",b[0,0], b[0,1], b[0,2] );
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} | {1}  | {2} ", b[1, 0], b[1, 1], b[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} | {1}  | {2} ", b[2, 0], b[2, 1], b[2, 2]);
            Console.WriteLine("    |    |    ");
        }

        static bool GamePlay(char[,] b, char p1, char p2, string pOne, string pTwo)
        {
            // get variables for the input
            string input;
            int option;
            bool isInt;

            // get the first players choice by getting user input, check to make sure input is an int, and that the number is within range
            Console.WriteLine("Enter a number 1-9 for {0}:", pOne);
            input = Console.ReadLine();
            isInt = int.TryParse(input, out option);
            while (option < 1 || option > 9)
            {
                Console.WriteLine("Invalid input, please enter a number 1-9");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out option);
            }

            // mark the first players choice on the board
            if (isInt)
            {
                // check to make sure that a spot on the board is not already marked
                while (CheckSpot(p1, p2, b, option))
                {
                    Console.WriteLine("Invalid input. Can't play a spot that is already marked on the board. Please provide valid input");
                    Console.WriteLine("Enter a number 1-9 for {0}:", pOne);
                    input = Console.ReadLine();
                    isInt = int.TryParse(input, out option);
                    while (option < 1 || option > 9)
                    {
                        Console.WriteLine("Invalid input, please enter a number 1-9");
                        input = Console.ReadLine();
                        isInt = int.TryParse(input, out option);
                    }
                }
                switch (option)
                {
                    case 1:
                        b[0,0] = p1;
                        break;
                    case 2:
                        b[0,1] = p1;
                        break;
                    case 3:
                        b[0,2] = p1;
                        break;
                    case 4:
                        b[1,0] = p1;
                        break;
                    case 5:
                        b[1,1] = p1;
                        break;
                    case 6:
                        b[1,2] = p1;
                        break;
                    case 7:
                        b[2,0] = p1;
                        break;
                    case 8:
                        b[2,1] = p1;
                        break;
                    case 9:
                        b[2,2] = p1;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter the correct input format.");
                return false;
            }

            // show result
            GridLines(b);

            // check for a winner
            if (CheckWinner(b, p1, p2, pOne, pTwo)) return true;

            // check if the game ends in a tie
            if (Tie(b, p1, p2)) return true;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // get the second players choice by getting user input, check to make sure input is an int, and that the number is within range
            Console.WriteLine("Enter a number 1-9 for {0}:", pTwo);
            input = Console.ReadLine();
            isInt = int.TryParse(input, out option);
            while (option < 1 || option > 9)
            {
                Console.WriteLine("Invalid input, please enter a number 1-9");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out option);
            }

            // mark the second players choice on the board
            if (isInt)
            {
                // check to make sure that a spot on the board is not already marked
                while (CheckSpot(p2, p1, b, option))
                {
                    Console.WriteLine("Invalid input. Can't play a spot that is already marked on the board. Please provide valid input");
                    Console.WriteLine("Enter a number 1-9 for {0}:", pTwo);
                    input = Console.ReadLine();
                    isInt = int.TryParse(input, out option);
                    while (option < 1 || option > 9)
                    {
                        Console.WriteLine("Invalid input, please enter a number 1-9");
                        input = Console.ReadLine();
                        isInt = int.TryParse(input, out option);

                    }

                }
                switch (option)
                {
                    case 1:
                        b[0,0] = p2;
                        break;
                    case 2:
                        b[0,1] = p2;
                        break;
                    case 3:
                        b[0,2] = p2;
                        break;
                    case 4:
                        b[1,0] = p2;
                        break;
                    case 5:
                        b[1,1] = p2;
                        break;
                    case 6:
                        b[1,2] = p2;
                        break;
                    case 7:
                        b[2,0] = p2;
                        break;
                    case 8:
                        b[2,1] = p2;
                        break;
                    case 9:
                        b[2,2] = p2;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter the correct input format.");
                return false;
            }
            // show result
            GridLines(b);

            // check to see if there is a winner
            if (CheckWinner(b, p1, p2, pOne, pTwo)) return true;

            // check if the game ends in a tie
            return Tie(b, p1, p2);
        }

            static int GoFirst()
        {
            Console.WriteLine("Determining who goes first..................");
            Random rand = new Random();
            decimal num = rand.Next() % 2;
            return (int) Math.Floor(num);
        }

        static bool CheckWinner(char[,] b, char p1, char p2, string player1, string player2)
        {
            // check for a horizontal winner for player one
            if (b[0, 0] == p1 && b[0, 1] == p1 && b[0, 2] == p1)
            {
                Congratulations(player1);
                return true;
            }
            if (b[1, 0] == p1 && b[1, 1] == p1 && b[1, 2] == p1)
            {
                Congratulations(player1);
                return true;
            }
            if (b[2, 0] == p1 && b[2, 1] == p1 && b[2, 2] == p1)
            {
                Congratulations(player1);
                return true;
            }

            // check for a horizontal winner for player two
            if (b[0, 0] == p2 && b[0, 1] == p2 && b[0, 2] == p2)
            {
                Congratulations(player2);
                return true;
            }
            if (b[1, 0] == p2 && b[1, 1] == p2 && b[1, 2] == p2)
            {
                Congratulations(player2);
                return true;
            }
            if (b[2, 0] == p2 && b[2, 1] == p2 && b[2, 2] == p2)
            {
                Congratulations(player2);
                return true;
            }

            // check for a vertical winner for player one
            if (b[0, 0] == p1 && b[1, 0] == p1 && b[2, 0] == p1)
            {
                Congratulations(player1);
                return true;
            }
            if (b[0, 1] == p1 && b[1, 1] == p1 && b[2, 1] == p1)
            {
                Congratulations(player1);
                return true;
            }
            if (b[0, 2] == p1 && b[1, 2] == p1 && b[2, 2] == p1)
            {
                Congratulations(player1);
                return true;
            }

            // check for a vertical winner for player two
            if (b[0, 0] == p2 && b[1, 0] == p2 && b[2, 0] == p2)
            {
                Congratulations(player2);
                return true;
            }
            if (b[0, 1] == p2 && b[1, 1] == p2 && b[2, 1] == p2)
            {
                Congratulations(player2);
                return true;
            }
            if (b[0, 2] == p2 && b[1, 2] == p2 && b[2, 2] == p2)
            {
                Congratulations(player2);
                return true;
            }

            //check for a diagonal winner for player one
            if (b[0, 0] == p1 && b[1, 1] == p1 && b[2, 2] == p1)
            {
                Congratulations(player1);
                return true;
            }
            if (b[0, 2] == p1 && b[1, 1] == p1 && b[2, 0] == p1)
            {
                Congratulations(player1);
                return true;
            }

            //check for a diagonal winner for player two
            if (b[0, 0] == p2 && b[1, 1] == p2 && b[2, 2] == p2)
            {
                Congratulations(player2);
                return true;
            }
            if (b[0, 2] == p2 && b[1, 1] == p2 && b[2, 0] == p2)
            {
                Congratulations(player2);
                return true;
            }

            // if there is no winner, return false and start the next round
            return false;
        }

        static void Congratulations(string player)
        {
            Console.WriteLine("Congratulations {0}!!  You Win!!", player);
        }

        static void Reset(char[,] b)
        {
            //Reset the game board to its original state
            b[0, 0] = '1';
            b[0, 1] = '2';
            b[0, 2] = '3';
            b[1, 0] = '4';
            b[1, 1] = '5';
            b[1, 2] = '6';
            b[2, 0] = '7';
            b[2, 1] = '8';
            b[2, 2] = '9';
        }

        static bool CheckSpot(char in1, char in2, char [,] b, int o)
        {
            // check to make sure the space on the board is not occupied
            if (o == 1 && ((b[0, 0] == in1) || (b[0, 0] == in2))) return true;
            if (o == 2 && ((b[0, 1] == in1) || (b[0, 1] == in2))) return true;
            if (o == 3 && ((b[0, 2] == in1) || (b[0, 2] == in2))) return true;
            if (o == 4 && ((b[1, 0] == in1) || (b[1, 0] == in2))) return true;
            if (o == 5 && ((b[1, 1] == in1) || (b[1, 1] == in2))) return true;
            if (o == 6 && ((b[1, 2] == in1) || (b[1, 2] == in2))) return true;
            if (o == 7 && ((b[2, 0] == in1) || (b[2, 0] == in2))) return true;
            if (o == 8 && ((b[2, 1] == in1) || (b[2, 1] == in2))) return true;
            if (o == 9 && ((b[2, 2] == in1) || (b[2, 2] == in2))) return true;

            // otherwise, the space is not occupied
            return false;
        }

        static bool Tie(char[,] b, char p1, char p2)
        {
            int row;
            int columns;
            int boardFull = 0;
            char check;

            for(row = 0; row < 3; row++)
            {
                for(columns = 0; columns < 3; columns++)
                {
                    check = b[row, columns];
                    if (check == p1 || check == p2) boardFull++;
                }
            }
            if(boardFull == 9)
            {
                Console.WriteLine("The game has ended in a tie!!");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}