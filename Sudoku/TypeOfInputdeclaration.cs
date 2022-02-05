using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function that gets the sudoku input format from the user.
    /// </summary>
    ///
    public class TypeOfInputDeclaration
    {
        /// <summary>
        /// Gets the sudoku input format from the user in order to know if the user will type an integer 
        /// represents the sudoku or have a file that contains the sudoku characters.
        /// </summary>
        /// <returns>An integer value of '2' if the user chose the typing format or '1' if he chose the file format.</returns>
        /// <exception cref="ArgumentException">Throw exeption if the user didn't type '1' or '2'</exception>
        public static int GetInputFormatFromUser()
        {
            Console.WriteLine("Hi, welcome to sudoku solver!");
            Console.WriteLine("Choose the format to get the sudoku:");
            Console.WriteLine("Type S to enter a string of board values or F to get board from a text file");
            string format = Console.ReadLine();
            if (format == "F")
                return 1;
            if (format == "S")
                return 2;
            else throw new ArgumentException("format can't be recognized"); // ask how to change that it will
                                                                            // throw it and fix the other exceptions
        }
    }
}
