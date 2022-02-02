using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class CheckInput
    {
        public static bool CheckInputToBoard(int numOfCharacters)
        {
            if (((Math.Sqrt(Math.Sqrt(numOfCharacters))) % 1 == 0))
                return true;
            return false;
        }

        public static bool CheckCharactersFromInputToBoard(string inputCharacters, int numOfCharacters) // check this function in main of another project
        {
            bool check = true;
            char[] possibeCharacters = Help.MakeArrayOfPossibeCharacters(numOfCharacters);
            for (int i = 0; i < inputCharacters.Length; i++)
            {
                if((!(Array.IndexOf(possibeCharacters, (inputCharacters.Substring(i, 1))) > -1)) || (inputCharacters[i] == '0'))
                    check = false;
            }
            return check;
        }
    }
}
