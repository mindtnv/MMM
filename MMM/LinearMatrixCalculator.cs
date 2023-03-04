using System.Numerics;

namespace MMM;

public class LinearMatrixCalculator : IMatrixCalculator
{
    public Matrix<T> Multiply<T>(Matrix<T> a, Matrix<T> b) where T : INumber<T>
    {
        var rows = a.RowsCount;
        var columns = b.ColumnsCount;
        var items = new T[rows][];
        for (var i = 0; i < rows; i++)
        {
            items[i] = new T[columns];
            for (var j = 0; j < columns; j++)
            {
                var r = a.GetRow(i).ToArray();
                var c = b.GetColumn(j).ToArray();
                var sum = T.Zero;
                for (var k = 0; k < r.Length; k++)
                    sum += r[k] * c[k];
                items[i][j] = sum;
            }
        }

        return Matrix<T>.Create(items);
    }
}