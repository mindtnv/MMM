namespace MMM;

public static class MatrixFactory
{
    public static Matrix<int> CreateRandomMatrix(int width, int height)
    {
        var values = new int[width][];
        for (var i = 0; i < width; i++)
        {
            values[i] = new int[height];
            for (var j = 0; j < height; j++)
                values[i][j] = Random.Shared.Next(0, 500);
        }

        return Matrix<int>.Create(values);
    }
}