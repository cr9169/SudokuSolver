using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Help // This class contains functions that help other functions do their role
    {
        public static char[] MakeArrayOfPossibeCharacters(int numOfCharacters) // makes an array of possible characters
                                                                               // according to the size of the board
        {
            char character = '1';
            char[] possibeCharacters = new char[numOfCharacters];
            for (int i = 0; i < ((int)(Math.Sqrt(numOfCharacters))); i++)
            {
                possibeCharacters[i] = character;
                character++;
            }
            return possibeCharacters;
        }

    }
}
