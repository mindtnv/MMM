using System.Numerics;

namespace MMM;

public interface IMatrixCalculator
{
    Matrix<T> Multiply<T>(Matrix<T> a, Matrix<T> b) where T : INumber<T>;
}