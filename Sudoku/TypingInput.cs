using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to get characters of sudoku board from the user.
    /// </summary>
    ///
    public class TypingInput
    {
        /// <summary>
        /// Gets characters of sudoku board from the user.
        /// The function sets the sudoku board size and the values in a sudoku board object in string representation.
        /// The function checks if the board is valid, if it's valid the function creates the char matrix representation 
        /// of the board, otherwise it throws an exeption.
        /// </summary>
        /// <param name="destinationBoard">The board object that gets the characters from the user.</param>
        /// <exception cref="ArgumentException">Throw exeption if the board the user typed id invalid</exception>
        /// 
        public static void SetBoardPropsFromTyping(GameBoard destinationBoard)
        {
            int cellCounter = 0;
            Console.WriteLine("Enter your sudoku string:");
            Console.WriteLine("Type 'enter' when you are done:)\n");

            int bufSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
            string stringInput = Console.ReadLine();

            for (int i = 0; i < stringInput.Length; i++)
            {
                if (stringInput[i] != '\n')
                    destinationBoard.SetStringBoardCharacter(stringInput[i]);
            }

            if (CheckInput.CheckInputSizeToBoard(((destinationBoard.GetStringBoardValues()).Length)) && (CheckInput.CheckCharactersFromInputToBoard(destinationBoard.GetStringBoardValues(), ((destinationBoard.GetStringBoardValues()).Length)))
                && CheckBoardParts.CheckNotTwiceInAllBoxes(destinationBoard) && CheckBoardParts.NotTwiceInAllColumns(destinationBoard) && CheckBoardParts.NotTwiceInAllRows(destinationBoard))  
            {
                destinationBoard.SetBoardSize((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length))));
                char[,] charBoard = new char[(destinationBoard.GetBoardSize()), (destinationBoard.GetBoardSize())];
                destinationBoard.CreateCharBoard(charBoard);

                for (int row = 0; row < ((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)))); row++)
                {
                    for (int column = 0; column < ((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)))); column++)
                    {
                        destinationBoard.SetBoardCharacter(row, column, stringInput[cellCounter]);
                        cellCounter++;
                    }
                }
            }
            else
                throw new ArgumentException(message: "The board is invalid!");
        }
    }
}
