using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sudoku;

namespace SudokuTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "1";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }

        [TestMethod]
        public void Test2()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "0";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test3()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "1000200030004000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test4()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "0000000000000000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test5()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "1200000000000034";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test6()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "350100280000370050470052030000230000120500800083000000690010008002000300000907000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test7()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test8()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "00000000000000<00000@000000090000000000000;00>000:0000000000000000000000000000000000500000000000000000005000000000000000000000500002000000000000000000000000000000000000000000000000000@00:00000000004000000200000000000000000000@003000004000000000000000000000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test9()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
        [TestMethod]
        public void Test10()
        {
            // ARRANGE
            int stringCounter = 0;
            string sudoku = "0000000000000000000;000000>000000010000>00000000000000000000000000000000000000400000000070000?000000000002800000000000000000000000000000000000>0000000000000000000000000000740000021000000000000000000010000230000000000;000700@00020070000000600>00000000000000";
            GameBoard board = new GameBoard();

            // ACT
            board.SetBoardSize((int)(Math.Sqrt(sudoku.Length)));
            char[,] sudokuCharMatrix = new char[board.GetBoardSize(), board.GetBoardSize()];
            board.CreateCharBoard(sudokuCharMatrix);
            for (int i = 0; i < (board.GetBoardSize()); i++)
            {
                for (int j = 0; j < (board.GetBoardSize()); j++)
                {
                    board.SetBoardCharacter(i, j, sudoku[stringCounter]);
                    stringCounter++;
                }
            }

            //ASSERT
            SolveBoard.solve(board);
        }
    }
}
