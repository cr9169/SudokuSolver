using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// A class that represent the sudoku board.
    /// </summary>
    /// 
    public class GameBoard
    {
        private string stringBoard;
        private int boardSize;
        private char[,] charBoard;
           
        public GameBoard()
        {
            this.boardSize = 0;
            this.charBoard = null;
            this.stringBoard = "";
        }

        /// <summary>
        /// Returns the size of the board that represented by row or columbn size.
        /// </summary>
        /// <returns>An integer represent size of the board</returns>
        /// 
        public int GetBoardSize()
        {
            return boardSize;
        }

        /// <summary>
        /// Sets the board size to other size.
        /// </summary>
        /// <param name="boardSize">The previous size of the board.</param>
        /// 
        public void SetBoardSize(int boardSize)
        {
            this.boardSize = boardSize;
        }

        /// <summary>
        /// Adds a character to the string presentation of the board.
        /// </summary>
        /// <param name="character">The character that inserted to the string presentation of the boardboard.</param>
        /// 
        public void SetStringBoardCharacter(char character)
        {
            this.stringBoard = stringBoard + character;
        }

        /// <summary>
        /// Replace the char matrix presentation of the board with other char matrix.
        /// </summary>
        /// <param name="charBoard">The char replaces current char matrix presentation of the board.</param>
        /// 
        public void CreateCharBoard(char[,] charBoard) // init cells board from null to an actual matrix
        {
            this.charBoard = charBoard;
        }

        /// <summary>
        /// Returns the char matrix presentation of the board.
        /// </summary>
        /// <returns>A char matrix presentation of the board.</returns>
        /// 
        public char[,] GetCharBoardValues()
        {
            return charBoard;
        }

        /// <summary>
        /// Returns the string presentation of the board.
        /// </summary>
        /// <returns>A string presentation of the board.</returns>
        /// 
        public string GetStringBoardValues()
        {
            return stringBoard;
        }

        /// <summary>
        /// Sets a character to a specific place in the char matrix presentation of the board.
        /// </summary>
        /// <param name="row">The index of the row in the char matrix presentation of the board.</param>
        /// <param name="column">The index of the column in the char matrix presentation of the board.</param>
        /// <param name="character">The Character we want to insert to the char matrix presentation of the board.</param>
        /// <exception cref="ArgumentException">Throw exeption if the row or column the function got are invalid.</exception>
        /// 
        public void SetBoardCharacter(int row,int column,char character) // לעבור על המטריצה של הלוח ולשים תא לפי אינדקס
        {
        if (row > this.boardSize && row < 0 && column > this.boardSize && column < 0)
            throw new ArgumentException("Column and row index have to be bigger than 0 and smaller than the size of the board");
        else
            this.charBoard[row, column] = character;
        }

        /// <summary>
        /// Inits the board object to his initial values.
        /// </summary>
        /// 
        public void initBoard()
        {
            this.boardSize = 0;
            this.charBoard = null;
            this.stringBoard = "";
        }
    }
}

