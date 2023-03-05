using System.Diagnostics;
using Increment;

const int n = 30000;
Console.WriteLine($"Incrementing 0 to {n}...");

var incrementers = new IIncrementer[]
{
    new ThreadNoLockIncrementer(n),
    new ThreadNoLockRefIncrementer(n),
    new ThreadWithLockIncrementer(n),
    new ThreadAtomicIncrementer(n),
};

foreach (var incrementer in incrementers)
{
    incrementer.Prepare();
    var sw = Stopwatch.StartNew();
    incrementer.Increment();
    sw.Stop();
    Console.WriteLine($"{incrementer.GetType()}:\t{incrementer.GetValue()}\t[{sw.Elapsed}]");
}