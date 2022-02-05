using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to copy to a text file a solved sudoku.
    /// </summary>
    ///
    public class FileOutput
    {
        /// <summary>
        /// The function gets a file path from the user, if the file exists the function copies the sudoku 
        /// string representation to the text file or throw exeption otherwise.
        /// </summary>
        /// <param name="board">The board we want to copy his characters to the text file.</param>
        /// <exception cref="ArgumentException">Throw exeption if the file doesn't exists.</exception>
        public static void WriteBoardToFileAfterSolution(GameBoard board)
        {
            {
                Console.WriteLine("Enter your solution file path");
                string path = Console.ReadLine();
                string destinationPath = @path;
                FileStream fileStram;
                SolveBoard.solve(board);    
                    if (File.Exists(destinationPath))
                    {
                        File.WriteAllText(destinationPath, String.Empty);
                        fileStram = new FileStream(destinationPath,
                                            FileMode.Append,
                                            FileAccess.Write);


                        StreamWriter writer = new StreamWriter(fileStram);

                        for (int i = 0; i < (Math.Sqrt(board.GetStringBoardValues().Length)); i++)
                        {
                            for (int j = 0; j < (Math.Sqrt(board.GetStringBoardValues().Length)); j++)
                            {
                                writer.Write((((board.GetCharBoardValues())[i, j])));
                            }
                        }

                        writer.Close();
                        fileStram.Close();
                    }
                    else
                    {
                        throw new ArgumentException(message: "The file doesn't exist!");
                    }
            }
            }
        }
    }

