using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class TypingInput 
    {

        public static void SetBoardPropsFromTyping(GameBoard destinationBoard)   // Sets board size and values of string and
                                                                                 // cells board from typing input
        {
            Console.WriteLine("Enter your sudoku string:");
            Console.WriteLine("Type 'enter' when you are done\n");
            int cellCounter = 0;
            string stringInput = Console.ReadLine();

            for(int i = 0; i < stringInput.Length; i++)
            {
                destinationBoard.SetStringBoardCharacter(stringInput[i]);
            }

            if (CheckInput.CheckInputToBoard(((destinationBoard.GetStringBoardValues()).Length)) && CheckInput.CheckCharactersFromInputToBoard(destinationBoard.GetStringBoardValues(), ((destinationBoard.GetStringBoardValues()).Length)))  ////++++++++++++++++++++++
            {
                for (int row = 0; row < Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)); row++)
                {
                    for (int column = 0; column < Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)); column++)  
                    {
                        Cell cell = new Cell(row, column, stringInput[cellCounter]);
                        destinationBoard.SetBoardCell(row, column, cell);  
                        cellCounter++;
                    }
                }
                destinationBoard.SetBoardSize((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length))));
            }
            else
                throw new ArgumentException("You typed too many characters"); // ask how to change that it will
                                                                              // throw it and fix the other exceptions
                // לעשות פה שהפונקציה חוזרת על עצמה, כאילו שאם הקלט לא היה תקין זה חוזר עוד פעם לקלוט ערכים מחדש ללוח המשחק
        }
    }
}
