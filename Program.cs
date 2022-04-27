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
            //Announcing the list to hold values for the base game
            List<char> board = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

            while (gameStatus == 0)
            {
                playerOne(board);

                playerTwo(board);

                DisplayBoard(board);
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

        static void playerOne(List<char> displayboard){
            Console.Write("x's turn to choose a square (1-9):");
            char playerOneInput = Console.ReadLine()[0];
            for (int i=0; i < displayboard.Count; i++){
                if (Char.Equals(displayboard[i],playerOneInput)){
                    displayboard[i] = 'x';

                }

            }
        }

        static void playerTwo(List<char> displayboard){
            Console.Write("o's turn to choose a square (1-9):");
            char playerTwoInput = Console.ReadLine()[0];
            for (int i=0; i < displayboard.Count; i++){
                if (Char.Equals(displayboard[i],playerTwoInput)){
                    displayboard[i] = 'o';
                }

            }
        }
    }
}