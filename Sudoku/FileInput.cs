using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class FileInput
    {
        public static void SetBoardPropsFromFile(GameBoard destinationBoard)   // Sets board size and values of string and
                                                                               // cells board from file input
        {
            Console.WriteLine("Enter your sudoku file path");
            int cellCounter = 0;
            List<char> boardValuesList = new List<char>();
            string path = Console.ReadLine();
            path = @path;

            string content = File.ReadAllText(path, Encoding.UTF8);
           
            foreach (char inputCharacter in content)
            {
                destinationBoard.SetStringBoardCharacter(inputCharacter);
            }
            if (CheckInput.CheckInputToBoard(((destinationBoard.GetStringBoardValues()).Length)) && CheckInput.CheckCharactersFromInputToBoard(destinationBoard.GetStringBoardValues(), ((destinationBoard.GetStringBoardValues()).Length)))
            {
                for (int row = 0; row < Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)); row++)
                {
                    for (int column = 0; column < Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)); column++)  
                    {
                        Cell cell = new Cell(row, column, (destinationBoard.GetStringBoardValues())[cellCounter]);
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
