using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class TypeOfInputdeclaration
    {
        protected static int GetInputFormatFromUser()
        {
            Console.WriteLine("Hi, welcome to sudoku solver!\n\n");
            Console.WriteLine("Choose the format to get the sudoku:\n");
            Console.WriteLine("Type S to enter a string of board values or F to get board from a text file");
            char format = char.Parse(Console.ReadLine());
            if (format == 'F')
                return 1;
            if (format == 'S')
                return 2;
            else throw new ArgumentException("format can't be recognized"); // ask how to change that it will
                                                                            // throw it and fix the other exceptions
        }
    }
}
