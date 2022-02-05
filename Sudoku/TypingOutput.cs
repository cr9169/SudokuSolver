using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to print a solved sudoku.
    /// </summary>
    /// 
    public class TypingOutput
    {

        /// <summary>
        /// Prints the sudoku board characters in a sudoku board form.
        /// </summary>
        /// <param name="board">The board we want to print in the sudoku board form.</param>
        /// 
        public static void printBoardAfterSolution(GameBoard board) 
        {
                SolveBoard.solve(board);        
                for (int l = 0; l < (Math.Sqrt(board.GetStringBoardValues().Length)); l++)
                {
                    Console.Write("-----");
                }
                Console.WriteLine("");
                for (int i = 0; i < (Math.Sqrt(board.GetStringBoardValues().Length)); i++)
                {
                    for (int j = 0; j < (Math.Sqrt(board.GetStringBoardValues().Length)); j++)
                    {
                        Console.Write("| " + (((board.GetCharBoardValues())[i, j])) + " |");
                    }
                    Console.WriteLine("");
                    for (int k = 0; k < (Math.Sqrt(board.GetStringBoardValues().Length)); k++)
                    {
                        Console.Write("-----");
                    }
                    Console.WriteLine("");
                }
                }
        }
    }

