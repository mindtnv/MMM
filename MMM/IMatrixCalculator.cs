using System.Numerics;

namespace MMM;

public interface IMatrixCalculator
{
    Task<Matrix<T>> MultiplyAsync<T>(Matrix<T> a, Matrix<T> b) where T : INumber<T>;
}