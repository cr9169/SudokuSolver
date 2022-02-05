using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that contains a function used to get path of a file that contains a characters of a sudoku board from the user.
    /// </summary>
    ///
    public class FileInput
    {
        /// <summary>
        /// Gets a path of a file that contains a characters of a sudoku board from the user.
        /// If the file path doesn't exists the function throws an exeption.
        /// The function sets the sudoku board size and the values in a sudoku board object in string representation.
        /// The function checks if the board is valid, if it's valid the function creates the char matrix representation 
        /// of the board, otherwise it throws an exeption.
        /// </summary>
        /// <param name="destinationBoard">The board object that gets the characters from the user.</param>
        /// <exception cref="ArgumentException">Throw exeption if the file contains an invalid sudoku string or
        /// if the file doesn't exists.</exception>
        public static void SetBoardPropsFromFile(GameBoard destinationBoard)   // Sets board size and values of string and
                                                                               // cells board from file input
        {
            int cellCounter = 0;
            Console.WriteLine("Enter your sudoku file path");
            string path = Console.ReadLine();
            string sourcePath = @path;

            if (File.Exists(path))
            {
                string content = File.ReadAllText(sourcePath, Encoding.UTF8);

                foreach (char inputCharacter in content)
                {
                    if(inputCharacter != '\n')
                        destinationBoard.SetStringBoardCharacter(inputCharacter);
                }

                if (CheckInput.CheckInputSizeToBoard(((destinationBoard.GetStringBoardValues()).Length)) && CheckInput.CheckCharactersFromInputToBoard(destinationBoard.GetStringBoardValues(), ((destinationBoard.GetStringBoardValues()).Length))
                    && CheckBoardParts.CheckNotTwiceInAllBoxes(destinationBoard) && CheckBoardParts.NotTwiceInAllColumns(destinationBoard) && CheckBoardParts.NotTwiceInAllRows(destinationBoard))
                {
                    destinationBoard.SetBoardSize((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length))));
                    char[,] charBoard = new char[(destinationBoard.GetBoardSize()), (destinationBoard.GetBoardSize())];
                    destinationBoard.CreateCharBoard(charBoard);

                    for (int row = 0; row < ((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)))); row++)
                    {
                        for (int column = 0; column < ((int)(Math.Sqrt(((destinationBoard.GetStringBoardValues()).Length)))); column++)
                        {
                            destinationBoard.SetBoardCharacter(row, column, destinationBoard.GetStringBoardValues()[cellCounter]);
                            cellCounter++;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException(message: "Your file contains an invalid sudoku string!"); 
                }
            }

            else
            {
                throw new ArgumentException(message: "The file doesn't exist!");
            }
            }
        }
        }
