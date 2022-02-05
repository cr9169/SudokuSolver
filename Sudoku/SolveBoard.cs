using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to solve a sudoku.
    /// </summary>
    /// 
    public class SolveBoard
    {
        /// <summary>
        /// Runs throw an unsolved sudoku board and solve it.
        /// </summary>
        /// <param name="board">The sudoku board we solve.</param>
        /// 
        public static bool solve(GameBoard board)
        {
            char[] possibeCharacters = MakeArrayOfPossibeCharacters.MakeAnArrayOfPossibeCharacters(board.GetBoardSize());
            for (int i = 0; i < board.GetBoardSize(); i++)
            {
                for (int j = 0; j < board.GetBoardSize(); j++)
                {
                    if ((board.GetCharBoardValues()[i, j]) == '0')
                    {
                        for (char character = '1'; character <= possibeCharacters[(possibeCharacters.Length)-1]; character++) 
                        {
                            if (CheckBoardParts.CanBeInsertedToBoard(board, i, j, character))
                            {
                                board.SetBoardCharacter(i, j, character);

                                if (solve(board))
                                    return true;
                                else
                                    board.SetBoardCharacter(i, j, '0');
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        
    }
}
