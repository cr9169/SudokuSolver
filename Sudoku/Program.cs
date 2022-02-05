using Sudoku;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// Main class.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            SolveSudoku.Solve();
            Console.ReadKey();
        }
    }
}

