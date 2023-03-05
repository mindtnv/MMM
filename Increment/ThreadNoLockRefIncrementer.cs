namespace Increment;

public class ThreadNoLockRefIncrementer : IncrementerBase
{
    public ThreadNoLockRefIncrementer(int threadCount) : base(threadCount)
    {
    }

    public override void DoIncrement(ref int value)
    {
        value += 1;
    }
}