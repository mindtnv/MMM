namespace MMM.Tests;

[TestFixture]
public class LinearMatrixCalculatorTests
{
    [Test]
    public void MultiplyTest()
    {
        var a = Matrix<int>.Create(new[]
        {
            new[] {1, 2 ,3},
            new[] {4, 5, 6},
        });
        var b = Matrix<int>.Create(new[]
        {
            new[] {7, 8},
            new[] {9, 1},
            new[] {2, 3},
        });
        var c = new LinearMatrixCalculator().Multiply(a, b);
        Assert.AreEqual(2, c.RowsCount);
        Assert.AreEqual(2, c.ColumnsCount);
        Assert.AreEqual(31, c.GetItem(0, 0));
        Assert.AreEqual(19, c.GetItem(0, 1));
        Assert.AreEqual(85, c.GetItem(1, 0));
        Assert.AreEqual(55, c.GetItem(1, 1));
    }
}