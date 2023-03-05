namespace Increment;

public class ThreadWithLockIncrementer : IncrementerBase
{
    private readonly Mutex _mutex = new();

    public ThreadWithLockIncrementer(int threadCount) : base(threadCount)
    {
    }

    public override void DoIncrement(ref int value)
    {
        _mutex.WaitOne();
        Value += 1;
        _mutex.ReleaseMutex();
    }
}