# Sudoku

Your task is to write a simple Sudoku solver. If you haven't come across this type of puzzle before, it is recommended to do some online research to familiarise yourself.

## Main goal

You should implement the `Solve` method of the `SudokuSolver` class. This method is designed to solve a Sudoku in-place - there is no need to create a copy of the passed-in Sudoku. You may create any helper methods you deem necessary.

Note that the `Sudoku` class already comes with some helpful features:

- Its constructor disallows any Sudoku with invalid dimensions or invalid values
- It contains a method called `IsComplete` which checks whether the grid is full (but doesn't check whether it is valid)
- It overrides the default `ToString` method with an implementation that allows for the Sudoku to be viewed in an easily-readable form
- It contains an indexer which allows extraction of any particular value in a Sudoku in the following manner: `mySudoku[rowIndex, colIndex]`

You should not edit the `Sudoku` class, only the `SudokuSolver` class.

You may work on the basis that every Sudoku passed into the `SudokuSolver` class has a unique solution.

## Stretch goals

- What happens if a passed-in Sudoku has no solutions, or multiple solutions? Try to handle these cases gracefully.
- Create a `SudokuGenerator` class. This should have a method called `Generate`, which will generate an incomplete Sudoku at random. Each generated Sudoku should have a unique solution.
