// See https://aka.ms/new-console-template for more information

//Tic-Tac-Toe
//Actions: 4. update board, 5. Switch Player, 6. determine winner/tie, 3. get user choice(same input not possible), 1. create board, 2. display board

//Track: board, player

using System;

namespace Jax // Note: actual namespace depends on the project name.
{
    internal class TicTacToe
    {
        static void Main(string[] args)
        {
            int gameStatus = 0;
            int currentPlayer = 1;
            //Announcing the list to hold values for the base game
            List<char> board = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

            while (gameStatus == 0)
            {
                if (gameStatus == 0){
                    DisplayBoard(board);
                }

                if (gameStatus == 0){
                    playerOne(board);
                    gameStatus = checkForWinner(board,currentPlayer);}
                currentPlayer = 2;

                if (gameStatus == 0){
                    DisplayBoard(board);
                }

                if (gameStatus == 0){
                    playerTwo(board);
                    gameStatus = checkForWinner(board,currentPlayer);
                }
                currentPlayer = 1;

                if (gameStatus != 0){
                    DisplayBoard(board);
                }

            }


        }

        //Function for displaying board
        static void DisplayBoard(List<char> displayboard){
            Console.WriteLine(displayboard[0] + "|" + displayboard[1] + "|" + displayboard[2]);
            Console.WriteLine("-" + "+" + "-" + "+" + "-");
            Console.WriteLine(displayboard[3] + "|" + displayboard[4] + "|" + displayboard[5]);
            Console.WriteLine("-" + "+" + "-" + "+" + "-");
            Console.WriteLine(displayboard[6] + "|" + displayboard[7] + "|" + displayboard[8]);
        }

        //Function for all of PlayerOne's Actions
        static void playerOne(List<char> displayboard){
            int check = 0;
            while (check == 0){
                Console.Write("x's turn to choose a square (1-9):");
                char playerOneInput = Console.ReadLine()[0];
                int intVal = (int)Char.GetNumericValue(playerOneInput) - 1;
                if (Char.Equals(displayboard[intVal],playerOneInput)){
                    displayboard[intVal] = 'x';
                    check = 1;
                    }
                else if(Char.Equals(displayboard[intVal],'x')||Char.Equals(displayboard[intVal],'o')){
                    Console.WriteLine("That spot has been taken.");
                    }
    
            }
        }


        //Function for all of PlayerTwo's actions
        static void playerTwo(List<char> displayboard){
            int check = 0;
            while (check == 0){
                Console.Write("o's turn to choose a square (1-9):");
                char playerTwoInput = Console.ReadLine()[0];
                int intVal = (int)Char.GetNumericValue(playerTwoInput) - 1;
                if (Char.Equals(displayboard[intVal],playerTwoInput)){
                    displayboard[intVal] = 'o';
                    check = 1;
                    }
                else if(Char.Equals(displayboard[intVal],'x')||Char.Equals(displayboard[intVal],'o')){
                    Console.WriteLine("That spot has been taken.");
                    }

            }
        }

        //Checks for every winnable solution and if there is a draw.
        static int checkForWinner(List<char> displayboard, int currentPlayer){
            int returnValue = 0;
            if (displayboard[0] == displayboard[1] && displayboard[0] == displayboard[2]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[0]}'s win!");
            }
            else if (displayboard[3] == displayboard[4] && displayboard[3] == displayboard[5]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[3]}'s win!");
            }
            else if (displayboard[6] == displayboard[7] && displayboard[6] == displayboard[8]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[6]}'s win!");
            }
            else if (displayboard[0] == displayboard[3] && displayboard[0] == displayboard[6]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[0]}'s win!");
            }
            else if (displayboard[1] == displayboard[4] && displayboard[1] == displayboard[7]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[1]}'s win!");
            }
            else if (displayboard[2] == displayboard[5] && displayboard[2] == displayboard[8]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[2]}'s win!");
            }
            else if (displayboard[0] == displayboard[4] && displayboard[0] == displayboard[8]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[0]}'s win!");
            }
            else if (displayboard[2] == displayboard[4] && displayboard[2] == displayboard[6]){
                returnValue = 1;
                Console.WriteLine($"{displayboard[2]}'s win!");
            }
            else if ((displayboard[0] == 'x' || displayboard[0] == 'o') && (displayboard[1] == 'x' || displayboard[1] == 'o') && (displayboard[2] == 'x' || displayboard[2] == 'o') && (displayboard[3] == 'x' || displayboard[3] == 'o') && (displayboard[4] == 'x' || displayboard[4] == 'o') && (displayboard[5] == 'x' || displayboard[5] == 'o') && (displayboard[6] == 'x' || displayboard[6] == 'o') && (displayboard[7] == 'x' || displayboard[7] == 'o') && (displayboard[8] == 'x' || displayboard[8] == 'o')){
                returnValue = 1;
                Console.WriteLine("Draw!");
            }
            else{}
            return returnValue;
        }
    }
}