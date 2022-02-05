using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains functions to check if the board elements are valid.
    /// </summary>
    /// 
    public class CheckBoardParts  {

        /// <summary>
        /// Checks if there isn't similar characters in a box in a board. Returns true if there are similar characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <param name="startRow">The first row index in the box.</param>
        /// <param name="startCol">The first column index in the box.</param>
        /// <returns>A boolean value that represents if the are similar characters in a box.</returns>
        /// 
        public static bool CheckNotTwiceInBox(GameBoard board, int startRow, int startCol) 
        {
            HashSet<char> checkDuplications = new HashSet<char>();

            for (int row = 0; row < ((int)(Math.Sqrt(board.GetBoardSize()))); row++)
            {
                for (int col = 0; col < ((int)(Math.Sqrt(board.GetBoardSize()))); col++)
                {
                    char character = board.GetCharBoardValues()[row + startRow, col + startCol];

                    if (checkDuplications.Contains(character))
                        return false;

                    if (character != '0')
                        checkDuplications.Add(character);
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if there isn't similar characters in a box all over the board. Returns true if there are similar
        /// characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <returns>A boolean value that represents if the are similar characters.</returns>
        /// 
        public static bool CheckNotTwiceInAllBoxes(GameBoard board)
        {
            bool CheckNotInAllBoxes = true;

                for (int j = 0; j < (board.GetBoardSize()); j += ((int)(Math.Sqrt(board.GetBoardSize()))))
                {
                    for (int k = 0; k < (board.GetBoardSize()); k += ((int)(Math.Sqrt(board.GetBoardSize()))))
                    {
                        if (CheckBoardParts.CheckNotTwiceInBox(board, j, k) == false)
                        CheckNotInAllBoxes = false;
                    }
                }
            return CheckNotInAllBoxes;
        }

        /// <summary>
        /// Checks if there isn't similar characters in a row in a board. Returns true if there are similar characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <param name="row">An index of the row we want to check.</param>
        /// <returns>A boolean value that represents if the are similar characters in a row.</returns>
        /// 
        public static bool NotTwiceInRow(GameBoard board, int row)
        {
            HashSet<char> checkDuplications = new HashSet<char>();

            for (int i = 0; i < board.GetBoardSize(); i++)
            {
                if (checkDuplications.Contains(board.GetCharBoardValues()[row, i]))
                    return false;

                if (board.GetCharBoardValues()[row, i] != '0')
                    checkDuplications.Add(board.GetCharBoardValues()[row, i]);
            }
            return true;
        }

        /// <summary>
        /// Checks if there isn't similar characters in a column in a board. Returns true if there are similar characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <param name="col">An index of the column we want to check.</param>
        /// <returns>A boolean value that represents if the are similar characters in a column.</returns>
        /// 
        public static bool NotTwiceInColumn(GameBoard board, int col)
        {
            HashSet<char> checkDuplications = new HashSet<char>();

            for (int i = 0; i < board.GetBoardSize(); i++)
            {

                // If already encountered before,
                // return false
                if (checkDuplications.Contains(board.GetCharBoardValues()[i, col]))
                    return false;

                // If it is not an empty cell,
                // insert value at the current
                // cell in the set
                if (board.GetCharBoardValues()[i, col] != '0')
                    checkDuplications.Add(board.GetCharBoardValues()[i, col]);
            }
            return true;
        }

        /// <summary>
        /// Checks if there isn't similar characters in a column all over the board. Returns true if there are similar
        /// characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <returns>A boolean value that represents if the are similar characters.</returns>
        /// 
        public static bool NotTwiceInAllColumns(GameBoard board)
        {
            bool check = true;
            for (int i = 0; i < board.GetBoardSize(); i++)
            {
                if(NotTwiceInColumn(board, i) == false)
                    check = false;
            }
            return check;
        }

        /// <summary>
        /// Checks if there isn't similar characters in a row all over the board. Returns true if there are similar
        /// characters and false otherwise.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <returns>A boolean value that represents if the are similar characters.</returns>
        /// 
        public static bool NotTwiceInAllRows(GameBoard board)
        {
            bool check = true;
            for (int i = 0; i < board.GetBoardSize(); i++)
            {
                if (NotTwiceInRow(board, i) == false)
                    check = false;
            }
            return check;
        }

        /// <summary>
        /// Checks if we can insert a character to a board in a specific place according to sudoku rules.
        /// </summary>
        /// <param name="board">The board we check.</param>
        /// <param name="row">The row index we check if there aren't other characters as the one we want to check
        /// if we can insert in.</param>
        /// <param name="column">The column we check if there aren't other characters as the one we want to check
        /// if we can insert in.</param>
        /// <param name="character">The character we want to check if we can insert to the specific place in the board.</param>
        /// <returns>A boolean value that represents if we can insert the character to the specific place in the board.</returns>
        /// 
        public static bool CanBeInsertedToBoard(GameBoard board, int row, int column, char character) 
        {
            int boardBoxSize = (int)(Math.Sqrt(board.GetBoardSize()));
            for (int i = 0; i < board.GetBoardSize(); i++)
            {
                //check row  
                if ((board.GetCharBoardValues()[i, column]) != '0' && (board.GetCharBoardValues()[i, column]) == character)
                    return false;
                //check column  
                if ((board.GetCharBoardValues()[row, i]) != '0' && (board.GetCharBoardValues()[row, i]) == character)
                    return false;
                //check block  
                if ((board.GetCharBoardValues()[boardBoxSize * (row / boardBoxSize) + i / boardBoxSize, boardBoxSize * (column / boardBoxSize) + i % boardBoxSize]) != '0' && (board.GetCharBoardValues()[boardBoxSize * (row / boardBoxSize) + i / boardBoxSize, boardBoxSize * (column / boardBoxSize) + i % boardBoxSize]) == character)
                    return false;
            }
            return true;
        }
    }
}
