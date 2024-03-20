public class AdditionStrategy : IOperationStrategy
{
    public double Invoke(double x, double y)
    {
        return x + y;
    }
}
