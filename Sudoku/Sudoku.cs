using System.Text;

namespace Sudoku;

public class Sudoku
{
    private readonly int?[,] _values;

    public Sudoku(int?[,] values)
    {
        if (values.GetLength(0) != 9 || values.GetLength(1) != 9)
        {
            throw new ArgumentOutOfRangeException(
                nameof(values),
                "Given sudoku does not have 9 rows and 9 columns"
            );
        }
        if (values.Cast<int?>().Any(value => value is < 1 or > 9))
        {
            throw new ArgumentOutOfRangeException(
                nameof(values),
                "Given sudoku does not consist solely of the digits 1 to 9"
            );
        }
        _values = values;
    }

    public bool IsComplete()
    {
        return _values.Cast<int?>().All(value => value.HasValue);
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        for (var rowIndex = 0; rowIndex < 9; rowIndex++)
        {
            for (var colIndex = 0; colIndex < 9; colIndex++)
            {
                stringBuilder.Append(
                    _values[rowIndex, colIndex].HasValue
                        ? _values[rowIndex, colIndex].ToString()
                        : '.'
                );
                stringBuilder.Append(colIndex < 8 ? ' ' : '\n');
            }
        }
        return stringBuilder.ToString();
    }

    public int? this[int rowIndex, int colIndex]
    {
        get => _values[rowIndex, colIndex];
        set => _values[rowIndex, colIndex] = value;
    }
}
