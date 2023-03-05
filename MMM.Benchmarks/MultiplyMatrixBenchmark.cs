using BenchmarkDotNet.Attributes;

namespace MMM.Benchmarks;

public class MultiplyMatrixBenchmark
{
    private AsyncPerCellMatrixCalculator _asyncPerCellMatrixCalculator = null!;
    private AsyncPerRowMatrixCalculator _asyncPerRowMatrixCalculator = null!;
    private LinearMatrixCalculator _linearMatrixCalculator = null!;
    private Matrix<int> _matrixA = null!;
    private Matrix<int> _matrixB = null!;
    [Params(5, 10, 100, 400)]
    public int N;

    [GlobalSetup]
    public void SetUp()
    {
        _linearMatrixCalculator = new LinearMatrixCalculator();
        _asyncPerCellMatrixCalculator = new AsyncPerCellMatrixCalculator();
        _asyncPerRowMatrixCalculator = new AsyncPerRowMatrixCalculator();
        _matrixA = MatrixFactory.CreateRandomMatrix(N, N);
        _matrixB = MatrixFactory.CreateRandomMatrix(N, N);
    }

    [Benchmark(Description = "Linear Multiply", Baseline = true)]
    public async Task<Matrix<int>> LinearMultiply() => await _linearMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "Async Per Cell Multiply")]
    public async Task<Matrix<int>> AsyncPerCellMultiply() =>
        await _asyncPerCellMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "Async Per Row Multiply")]
    public async Task<Matrix<int>> AsyncPerRowMultiply() =>
        await _asyncPerRowMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);
}