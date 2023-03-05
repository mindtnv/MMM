using System.Numerics;

namespace MMM;

public class AsyncPerCellMatrixCalculator : IMatrixCalculator
{
    public async Task<Matrix<T>> MultiplyAsync<T>(Matrix<T> a, Matrix<T> b) where T : INumber<T>
    {
        var rows = a.RowsCount;
        var columns = b.ColumnsCount;
        var items = new T[rows][];
        var tasks = new List<Task>();
        for (var i = 0; i < rows; i++)
        {
            items[i] = new T[columns];
            for (var j = 0; j < columns; j++)
            {
                var i1 = i;
                var j1 = j;
                var task = Task.Run(() =>
                {
                    var r = a.GetRow(i1).ToArray();
                    var c = b.GetColumn(j1).ToArray();
                    var sum = T.Zero;
                    for (var k = 0; k < r.Length; k++)
                        sum += r[k] * c[k];
                    items[i1][j1] = sum;
                });
                tasks.Add(task);
            }
        }

        await Task.WhenAll(tasks);
        return Matrix<T>.Create(items);
    }
}