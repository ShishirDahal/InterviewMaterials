using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class TicTacToe
    {
        //Q1. 3x3 board is give. Find if game is over
        /*cases for game over
        a. if all cells in any rows/cols/diags/anitdiags have same value, gameOver=True
            1. rows: check all 3 rows, 
            2. columns: check all 3 columns,
            3. Diag
            4. Anti-diag
        b. Check invalid board conditions, in this case game Over
        */

        public static bool IsGameWon(char[,] board)
        {
            bool gameOwn = false;
            //check rows
            char firstChar = 'x';
            for (int r = 0; r < 3; r++)
            {
                //get value at the first cell
                firstChar = board[r, 0];
                //compare all other columns on that row with the firstChar
                if (board[r, 0] == firstChar && board[r, 1] == firstChar && board[r, 2] == firstChar)
                {
                    gameOwn = true;
                    break;
                }
            }

            //check columns if not game over yet
            if (!gameOwn)
            {
                for (int c = 0; c < 3; c++)
                {
                    firstChar = board[0, 0];
                    //compare all other rows on that column with the firstChar
                    if (board[0, c] == firstChar && board[1, c] == firstChar && board[2, c] == firstChar)
                    {
                        gameOwn = true;
                        break;
                    }
                }
            }

            //check diagonal if not game over yet
            if (!gameOwn)
            {
                firstChar = board[0, 0];
                if (board[0, 0] == firstChar && board[1, 1] == firstChar && board[2, 2] == firstChar)
                {
                    gameOwn = true;
                }
            }

            //check anti-diagonal if not game over yet
            if (!gameOwn)
            {
                firstChar = board[0, 0];
                if (board[2, 0] == firstChar && board[1, 1] == firstChar && board[0, 2] == firstChar)
                {
                    gameOwn = true;
                }
            }
            return gameOwn;
        }

        /*
        Cases for invalid board
        1. Difference between Player#1's move count(c1) and Player#2's move count(c2) should not be more than 1
        
        2. Minor (Generally not possible): If board has any other characters than 'x', '0' or null/empty char
         
       
         Cases for Draw : Diff between c1 and c2 is 1 AND whole board is full AND !Invalid AND !GameOwn 
        */
        public static bool IsBoardInvalid(int[,] board)
        {

        }
    }
}
