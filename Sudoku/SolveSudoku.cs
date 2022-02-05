using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function that sets the ui of the program and uses other classes to solve the sudoku.
    /// </summary>
    /// 
    public class SolveSudoku
    {
        /// <summary>
        /// The function sets instructions to the user on how to use the program.
        /// It gets a file path or a string representation of a sudoku from the user and solve it.
        /// The function keeps going until the user decide otherwise.
        /// </summary>
        public static void Solve()
        {
            int format = 0;
            bool continueProgram = true;
            string continueOrExit;
            GameBoard myBoard = new GameBoard();
            while (continueProgram == true)
            {
                myBoard.initBoard();
                try
                {
                    format = TypeOfInputDeclaration.GetInputFormatFromUser();
                }
                catch (Exception exeption)
                {
                    Console.WriteLine();
                    Console.WriteLine(exeption.Message);
                    Solve();
                }


                if (format == 2)
                {
                    try
                    {
                        TypingInput.SetBoardPropsFromTyping(myBoard);
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine();
                        Console.WriteLine(exeption.Message);
                        Console.WriteLine();
                        Solve();
                    }
                    TypingOutput.printBoardAfterSolution(myBoard);
                }
                if (format == 1)
                {
                    try
                    {
                        FileInput.SetBoardPropsFromFile(myBoard);
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine();
                        Console.WriteLine(exeption.Message);
                        Console.WriteLine();
                        Solve();
                    }
                    try
                    {
                        FileOutput.WriteBoardToFileAfterSolution(myBoard);
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine();
                        Console.WriteLine(exeption.Message);
                        Console.WriteLine();
                        Solve();
                    }
                }
                Console.WriteLine("To continue type 'c' any other keys or words to exit");
                Console.WriteLine("Don't forget to type 'enter' afterwards :)");
                Console.WriteLine();
                continueOrExit = Console.ReadLine();
                continueProgram = false;
                if (continueOrExit == "c")
                    continueProgram = true;
            }
            Console.WriteLine("\nThanks for using sudoku solver!!!");
        }
    }
}
