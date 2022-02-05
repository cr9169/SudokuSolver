using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class CheckInput
    {
        /// <summary>
        /// Checks if the number of characters in a board is valid.
        /// Checks if a the square root of a number of characters in a board is an integer and if the number isn't zero. 
        /// </summary>
        /// <param name="numOfCharacters">The number of characters in a board.</param>
        /// <returns>A boolean value that represents if the board size is valid.</returns>
        public static bool CheckInputSizeToBoard(int numOfCharacters) // בודק האם גודל הלוח תקין לפי מספר התווים שנכנסו בקלט
        {
            if(numOfCharacters == 0)
                return false;
            if (((Math.Sqrt(Math.Sqrt(numOfCharacters))) % 1 == 0))
                return true;
            return false;
        }

        /// <summary>
        /// Checks if all the characters in a string are valid according to the board size.
        /// </summary>
        /// <param name="inputCharacters">The string represents the sudoku board characters.</param>
        /// <param name="numOfCharacters">The number of the sudoku characters</param>
        /// <returns>A boolean value that represents if the board characters are valid.</returns>
        /// 
        public static bool CheckCharactersFromInputToBoard(string inputCharacters, int numOfCharacters) // check this function in main of another project
                                                                                                        // checks if all the chars in input are valid
        {
            bool check = true;
            char[] possibeCharacters = MakeArrayOfPossibeCharacters.MakeAnArrayOfPossibeCharacters((int)(Math.Sqrt(numOfCharacters)));
            for (int i = 0; i < inputCharacters.Length; i++)
            {
                if(!((possibeCharacters.Contains(inputCharacters[i])) || (((char)(inputCharacters[i])) == '0')))
                    check = false;
            }
            return check;
        }
    }
}
