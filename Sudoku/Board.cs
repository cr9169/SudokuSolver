using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class GameBoard
    {
        private string stringBoard;
        private int boardSize;
        private Cell[,] cellsBoard;
           
        public GameBoard()
        {
            this.boardSize = 0;
            this.cellsBoard = null;
            this.stringBoard = "";
        }
        public int GetBoardSize()
        {
            return boardSize;
        }
        public void SetBoardSize(int boardSize)
        {
            this.boardSize = boardSize;
        }
        public void SetStringBoardCharacter(char character)
        {
            this.stringBoard = stringBoard + character;
        }
        public string GetStringBoardValues()
        {
            return stringBoard;
        }
        public void SetBoardCell(int row,int column,Cell cell) // לעבור על המטריצה של הלוח ולשים תא לפי אינדקס
        {
        if (row > this.boardSize && row < 0 && column > this.boardSize && column < 0)
            throw new ArgumentException("Column and row index have to be bigger than 0 and smaller than the size of the board");
        else
            cellsBoard[row, column] = cell;
        }
    }
}

