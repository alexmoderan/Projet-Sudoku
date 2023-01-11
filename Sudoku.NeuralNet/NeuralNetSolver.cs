using Sudoku.Shared;

namespace Sudoku.NeuralNet
{
    public class NeuralNetSolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s.CloneSudoku();
        }
    }
    

    
}