namespace Increment;

public class ThreadNoLockIncrementer : IIncrementer
{
    protected Thread[] Threads = null!;
    public int Value { get; set; }
    public int ThreadCount { get; }

    public ThreadNoLockIncrementer(int threadCount)
    {
        ThreadCount = threadCount;
    }

    public void Prepare()
    {
        Threads = new Thread[ThreadCount];
        for (var i = 0; i < ThreadCount; i++)
            Threads[i] = new Thread(() => Value++);
    }

    public void Increment()
    {
        foreach (var thread in Threads)
            thread.Start();
        foreach (var thread in Threads)
            thread.Join();
    }

    public int GetValue() => Value;
}