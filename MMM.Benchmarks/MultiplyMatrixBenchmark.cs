using BenchmarkDotNet.Attributes;

namespace MMM.Benchmarks;

public class MultiplyMatrixBenchmark
{
    private AsyncPerCellMatrixCalculator _asyncPerCellMatrixCalculator = null!;
    private AsyncPerRowMatrixCalculator _asyncPerRowMatrixCalculator = null!;
    private LinearMatrixCalculator _linearMatrixCalculator = null!;
    private Matrix<int> _matrixA = null!;
    private Matrix<int> _matrixB = null!;
    private ThreadPerRowMatrixCalculator _threadPerRowMatrixCalculatorWithHalfThreads = null!;
    private ThreadPerRowMatrixCalculator _threadPerRowMatrixCalculatorWithNThreads = null!;
    private ThreadPerRowMatrixCalculator _threadPerRowMatrixCalculatorWithOneThread = null!;
    [Params(2, 5, 10, 100, 200)]
    public int N;

    [GlobalSetup]
    public void SetUp()
    {
        _matrixA = MatrixFactory.CreateRandomMatrix(N, N);
        _matrixB = MatrixFactory.CreateRandomMatrix(N, N);
        _linearMatrixCalculator = new LinearMatrixCalculator();
        _asyncPerCellMatrixCalculator = new AsyncPerCellMatrixCalculator();
        _asyncPerRowMatrixCalculator = new AsyncPerRowMatrixCalculator();
        _threadPerRowMatrixCalculatorWithOneThread = new ThreadPerRowMatrixCalculator(1);
        _threadPerRowMatrixCalculatorWithHalfThreads = new ThreadPerRowMatrixCalculator(N / 2);
        _threadPerRowMatrixCalculatorWithNThreads = new ThreadPerRowMatrixCalculator(N);
    }

    [Benchmark(Description = "Linear Multiply", Baseline = true)]
    public async Task<Matrix<int>> LinearMultiply() => await _linearMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "Async Per Cell Multiply")]
    public async Task<Matrix<int>> AsyncPerCellMultiply() =>
        await _asyncPerCellMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "Async Per Row Multiply")]
    public async Task<Matrix<int>> AsyncPerRowMultiply() =>
        await _asyncPerRowMatrixCalculator.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "[Threads = 1] Thread Per Row Multiply")]
    public async Task<Matrix<int>> ThreadPerRowMultiplyWithOneThread() =>
        await _threadPerRowMatrixCalculatorWithOneThread.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "[Threads = N / 2] Thread Per Row Multiply")]
    public async Task<Matrix<int>> ThreadPerRowMultiplyWithHalfThreads() =>
        await _threadPerRowMatrixCalculatorWithHalfThreads.MultiplyAsync(_matrixA, _matrixB);

    [Benchmark(Description = "[Threads = N] Thread Per Row Multiply")]
    public async Task<Matrix<int>> ThreadPerRowMultiplyWithNThreads() =>
        await _threadPerRowMatrixCalculatorWithNThreads.MultiplyAsync(_matrixA, _matrixB);
}