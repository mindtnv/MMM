namespace MMM.Tests;

[TestFixture]
public class MatrixCalculatorTests
{
    [Test]
    public async Task MultiplyTest()
    {
        var a = Matrix<int>.Create(new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
        });
        var b = Matrix<int>.Create(new[]
        {
            new[] {7, 8},
            new[] {9, 1},
            new[] {2, 3},
        });
        var calculators = new IMatrixCalculator[]
        {
            new LinearMatrixCalculator(),
            new AsyncPerCellMatrixCalculator(),
            new AsyncPerRowMatrixCalculator(),
            new ThreadPerRowMatrixCalculator(4),
            new ThreadPerRowMatrixCalculator(2),
            new ThreadPerRowMatrixCalculator(3),
            new ThreadPerRowMatrixCalculator(1),
        };
        foreach (var calculator in calculators)
        {
            var resultMatrix = await calculator.MultiplyAsync(a, b);
            Assert.Multiple(() =>
            {
                Assert.That(resultMatrix.RowsCount, Is.EqualTo(2));
                Assert.That(resultMatrix.ColumnsCount, Is.EqualTo(2));
                Assert.That(resultMatrix.GetItem(0, 0), Is.EqualTo(31));
                Assert.That(resultMatrix.GetItem(0, 1), Is.EqualTo(19));
                Assert.That(resultMatrix.GetItem(1, 0), Is.EqualTo(85));
                Assert.That(resultMatrix.GetItem(1, 1), Is.EqualTo(55));
            });
        }
    }
}