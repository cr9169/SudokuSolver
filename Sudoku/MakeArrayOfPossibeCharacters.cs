using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to make an array of possible characters to sudoku board.
    /// </summary>
    /// 
    public class MakeArrayOfPossibeCharacters // This class contains functions that help other functions do their role
    {
        /// <summary>
        /// The function creates an array of characters that can appear in a sudoku board according to the
        /// number of characters in the board.
        /// </summary>
        /// <param name="numOfCharacters">The number of characters in the board.</param>
        /// <returns>A character array of the characters that can appear in the sudoku board.</returns>
        /// 
        public static char[] MakeAnArrayOfPossibeCharacters(int numOfCharacters) // makes an array of possible characters
                                                                               // according to the size of the board
        {
            char character = '1';
            char[] possibeCharacters = new char[numOfCharacters];
            for (int i = 0; i < (numOfCharacters); i++)
            {
                possibeCharacters[i] = character;
                character++;
            }
            return possibeCharacters;
        }

    }
}
