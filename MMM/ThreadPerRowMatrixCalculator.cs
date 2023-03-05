using System.Numerics;

namespace MMM;

public class ThreadPerRowMatrixCalculator : IMatrixCalculator
{
    public int ThreadCount { get; }

    public ThreadPerRowMatrixCalculator(int threadCount)
    {
        ThreadCount = threadCount;
    }

    public Task<Matrix<T>> MultiplyAsync<T>(Matrix<T> a, Matrix<T> b) where T : INumber<T>
    {
        var rows = a.RowsCount;
        var columns = b.ColumnsCount;
        var items = new T[rows][];
        var threads = new Thread[ThreadCount];
        for (var k = 0; k < ThreadCount; k++)
        {
            var k1 = k;
            threads[k] = new Thread(() =>
            {
                for (var i = k1 % ThreadCount; i < rows; i += ThreadCount)
                {
                    items[i] = new T[columns];
                    for (var j = 0; j < columns; j++)
                    {
                        var r = a.GetRow(i).ToArray();
                        var c = b.GetColumn(j).ToArray();
                        var sum = T.Zero;
                        for (var m = 0; m < r.Length; m++)
                            sum += r[m] * c[m];
                        items[i][j] = sum;
                    }
                }
            });
            threads[k].Start();
        }

        foreach (var thread in threads)
            thread.Join();

        return Task.FromResult(Matrix<T>.Create(items));
    }
}