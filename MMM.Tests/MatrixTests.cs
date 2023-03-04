namespace MMM.Tests;

using MMM;

public class MatrixTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void CreateTest()
    {
        var items = new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
        };
        var matrix = Matrix<int>.Create(items);
        Assert.AreEqual(2, matrix.RowsCount);
        Assert.AreEqual(3, matrix.ColumnsCount);
    }

    [Test]
    public void GetItemTest()
    {
        var items = new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
            new[] {7, 8, 9},
        };
        var matrix = Matrix<int>.Create(items);
        for (var i = 0; i < items.Length; i++)
            for (var j = 0; j < items[i].Length; j++)
                Assert.AreEqual(items[i][j], matrix.GetItem(i, j));
    }
    
    [Test]
    public void GetRowTest()
    {
        var items = new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
        };
        var matrix = Matrix<int>.Create(items);
        var row = matrix.GetRow(1).ToArray();
        
        for (var i = 0; i < items[1].Length; i++)
            Assert.AreEqual(items[1][i], row[i]);
    }
    
    
    [Test]
    public void GetColumnTest()
    {
        var items = new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
        };
        var matrix = Matrix<int>.Create(items);
        var column = matrix.GetColumn(1).ToArray();
        
        for (var i = 0; i < items.Length; i++)
            Assert.AreEqual(items[i][1], column[i]);
    }

}