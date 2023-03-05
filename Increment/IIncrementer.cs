namespace Increment;

public interface IIncrementer
{
    void Prepare();
    void Increment();
    int GetValue();
}