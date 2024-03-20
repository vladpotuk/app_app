public class Calculator
{
    private IOperationStrategy _strategy;

    public Calculator(IOperationStrategy strategy)
    {
        _strategy = strategy;
    }

    public double ExecuteStrategy(double x, double y)
    {
        return _strategy.Invoke(x, y);
    }
}
