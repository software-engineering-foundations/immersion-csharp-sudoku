using Sudoku;

var sudoku = new Sudoku.Sudoku(
    new int?[,]
    {
        { null, null, null, 2, 6, null, 7, null, 1 },
        { 6, 8, null, null, 7, null, null, 9, null },
        { 1, 9, null, null, null, 4, 5, null, null },
        { 8, 2, null, 1, null, null, null, 4, null },
        { null, null, 4, 6, null, 2, 9, null, null },
        { null, 5, null, null, null, 3, null, 2, 8 },
        { null, null, 9, 3, null, null, null, 7, 4 },
        { null, 4, null, null, 5, null, null, 3, 6 },
        { 7, null, 3, null, 1, 8, null, null, null },
    }
);
Console.WriteLine("Before:");
Console.Write(sudoku);
Console.WriteLine();

SudokuSolver.Solve(sudoku);

Console.WriteLine("After:");
Console.Write(sudoku);
