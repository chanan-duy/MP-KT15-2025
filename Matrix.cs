using System.Text;

namespace MP_KT15_2025;

public class Matrix
{
    private readonly double[,] _matrix;

    public Matrix(int rows, int columns, bool fillWithRandom = true)
    {
        _matrix = new double[rows, columns];

        if (fillWithRandom)
        {
            FillWithRandom();
        }
    }

    private void FillWithRandom()
    {
        const int min = 0;
        const int max = 99;

        for (var row = 0; row < _matrix.GetLength(0); row++)
        {
            for (var column = 0; column < _matrix.GetLength(1); column++)
            {
                var value = Random.Shared.Next(min, max + 1) + Random.Shared.NextDouble();
                _matrix[row, column] = value;
            }
        }
    }

    public IEnumerable<double> GetRow(int index)
    {
        if (index >= _matrix.GetLength(0))
        {
            throw new IndexOutOfRangeException();
        }

        for (var column = 0; column < _matrix.GetLength(1); column++)
        {
            yield return _matrix[index, column];
        }
    }

    public IEnumerable<double> GetColumn(int index)
    {
        if (index >= _matrix.GetLength(1))
        {
            throw new IndexOutOfRangeException();
        }

        // cache miss ;(
        for (var row = 0; row < _matrix.GetLength(0); row++)
        {
            yield return _matrix[row, index];
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append('[');

        for (var row = 0; row < _matrix.GetLength(0); row++)
        {
            var wasAny = false;
            sb.Append(Environment.NewLine);
            for (var column = 0; column < _matrix.GetLength(1); column++)
            {
                wasAny = true;

                var val = _matrix[row, column];
                sb.Append($"{val:F3}");
                sb.Append(',');
                sb.Append(' ');
            }

            if (wasAny)
            {
                sb.Length -= 2;
            }
        }

        sb.Append(Environment.NewLine);
        sb.Append(']');

        return sb.ToString();
    }
}
