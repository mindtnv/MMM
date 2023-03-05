namespace Increment;

public abstract class IncrementerBase : IIncrementer
{
    protected Thread[] Threads = null!;
    public int Value;
    public int ThreadCount { get; }

    protected IncrementerBase(int threadCount)
    {
        ThreadCount = threadCount;
    }

    public void Prepare()
    {
        Threads = new Thread[ThreadCount];
        for (var i = 0; i < ThreadCount; i++)
            Threads[i] = new Thread(() => DoIncrement(ref Value));
    }

    public void Increment()
    {
        foreach (var thread in Threads)
            thread.Start();
        foreach (var thread in Threads)
            thread.Join();
    }

    public int GetValue() => Value;
    public abstract void DoIncrement(ref int value);
}