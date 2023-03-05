namespace Increment;

public class ThreadAtomicIncrementer : IncrementerBase
{
    public ThreadAtomicIncrementer(int threadCount) : base(threadCount)
    {
    }

    public override void DoIncrement(ref int value)
    {
        Interlocked.Increment(ref value);
    }
}