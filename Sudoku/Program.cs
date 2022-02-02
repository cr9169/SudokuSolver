using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public interface IValidation
    {
        char[,] MakeInputMatrix(int input); // makes the input from user a matrix
        bool IsValidByAmountOfCharacters(int input);
        bool IsValidByInputType(int input);
        bool CanBeSolved(int[,] input);

        // לממש במחלקות של סוגי הקלט
    }

    public interface ICheckSudokuParts
    {
        char[] FindSymbolsNotInSquare(char[,] matrix);
        char[] FindSymbolsNotInRow(char[] row);
        char[] FindSymbolsNotInColumn(char[] column);
    }

    public class Cell // ******************************************************************************** לבדוק אם מספר שורה ומספר טור תקינים לפי גודל לוח
    {
        private char character;
        private int rowIndex;
        private int columnIndex;
        //private char[] possibleValues;

        public Cell(int rowIndex, int columnIndex, char character) // char[] possibleValues
        {
            this.rowIndex = rowIndex;
            this.columnIndex = columnIndex;
            //this.possibleValues = possibleValues;
            this.character = character;
        }

        public int GetRowIndex() { return rowIndex; }
        public int GetColumnIndex() { return columnIndex; }

        public char GetCharacter() { return character; }
        //public char[] GetPossibleValues() { return possibleValues; }

    }

    public class CheckIfValid // קלאס של פונקציות ואלידציה של דברים
    {
        public static bool IsFileValid()
        {
            return true; // change (the function checks if a file is written in one line) 
        }
    }
    public class Input
    { 
        protected int WhichFormat(char format)
        {
            //Console.WriteLine("Type S to type board values or F to get board from a file");
            //char format = char.Parse(Console.ReadLine());
            if (format == 'F')
                return 1;
            if (format == 'S')
                return 2;
            else throw new ArgumentException("format can't be recognized");
        }
     
        ////public abstract int GetIntegerValueFromInput();
    }

    


    }

    public class FileInput
    {
        // create a function that finds a file in computer and reads it (returns string with spaces), the function will throw exeption if the 
        //file is not written in one line (using a function from CheckIfValid class)
        public string GetBoardValuesFromFile(string boardValues)
        {
            return boardValues;                                         // change in order to get the string from file
            //return TypingInput.GetBoardValuesFromTyping(boardValues); // change in order to get the string from file
        }
        //public override int[,] MakeInputMatrix(int input)
        //{
        //    return new int[1, 1];// change
        //}

    }

    public class Output
    {
        public void PrintSolution(char[,] solution)
        {

            for (int l = 0; l < solution.GetLength(0); l++)
            {
                Console.Write("-----");
            }
            Console.WriteLine("");
            for (int i = 0; i < solution.GetLength(0); i++)
            {
                for (int j = 0; j < solution.GetLength(0); j++)
                {
                    Console.Write("| " + solution[i, j] + " |");
                }
                Console.WriteLine("");
                for (int k = 0; k < solution.GetLength(0); k++)
                {
                    Console.Write("-----");
                }
                Console.WriteLine("");
            }
        }
    }

internal class Program
{
    static void Main(string[] args)
    {
        char a = '1';
        a++;
        Console.WriteLine(a);


        //boardValuesList = GetBoardValuesFromTyping();

        //char[,] solution = { { '1', '2', '3' }, { '4', '5', '6' }, { '6', '7', '8' } };

        //for (int l = 0; l < solution.GetLength(0); l++)
        //{
        //    Console.Write("-----");
        //}
        //Console.WriteLine("");
        //for (int i = 0; i < solution.GetLength(0); i++)
        //{
        //    for (int j = 0; j < solution.GetLength(0); j++)
        //    {
        //        Console.Write("| " + solution[i, j] + " |");
        //    }
        //    Console.WriteLine("");
        //    for (int k = 0; k < solution.GetLength(0); k++)
        //    {
        //        Console.Write("-----");
        //    }
        //    Console.WriteLine("");
        //}

        Console.ReadKey();
    }
}
    

