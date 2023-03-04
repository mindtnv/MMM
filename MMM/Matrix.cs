using System.Collections;
using System.Numerics;

namespace MMM;

public class Matrix<T> where T : INumber<T>
{
    private T[][] _values;
    public int RowsCount { get; }
    public int ColumnsCount { get; }

    protected Matrix(T[][] values)
    {
        _values = values;
        RowsCount = values.Length;
        ColumnsCount = RowsCount > 0 ? _values[0].Length : 0;
    }

    public T GetItem(int row, int column)
    {
        if (row >= _values.Length || row < 0)
            throw new ArgumentException(nameof(row));
        
        if (column >= _values[row].Length || column < 0)
            throw new ArgumentException(nameof(column));

        return _values[row][column];
    }

    public IEnumerable<T> GetRow(int row)
    {
        if (row >= _values.Length || row < 0)
            throw new ArgumentException(nameof(row));

        return _values[row];
    }

    public IEnumerable<T> GetColumn(int column)
    {
        if (ColumnsCount > 0 && column >= _values[0].Length || column < 0)
            throw new ArgumentException(nameof(column));

        return new ColumnEnumerator<T>(this, column);
    }

    public static Matrix<T> Create(IEnumerable<IEnumerable<T>> rows)
    {
        var r = rows.ToArray();
        var values = new T[r.Length][];
        var columns = -1;
        for (var i = 0; i < r.Length; i++)
        {
            var c = r[i].ToArray();
            if (columns != c.Length && columns > -1)
                throw new ArgumentException(nameof(rows));

            columns = columns == -1 ? c.Length : columns;
            values[i] = c;
        }

        return new Matrix<T>(values);
    }

    private class ColumnEnumerator<T> : IEnumerator<T>, IEnumerable<T> where T: INumber<T>
    {
        private int _row = -1;
        private int _column = 0;
        private Matrix<T> _matrix;

        public ColumnEnumerator(Matrix<T> matrix, int column)
        {
            _matrix = matrix;
            _column = column;
        }

        public T Current => _matrix.GetItem(_row, _column);
        object IEnumerator.Current => Current;

        public bool MoveNext() => ++_row < _matrix.RowsCount;

        public void Reset()
        {
            _row = 0;
        }

        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator() => new ColumnEnumerator<T>(_matrix, _column);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}