using System;

public class NumberChecker
{
    public bool Invoke(OperationType operationType, int num)
    {
        switch (operationType)
        {
            case OperationType.Even:
                return IsEven(num);
            case OperationType.Odd:
                return IsOdd(num);
            case OperationType.Prime:
                return IsPrime(num);
            case OperationType.Fibonacci:
                return IsFibonacci(num);
            default:
                throw new ArgumentException("Invalid operation type");
        }
    }

    private bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    private bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    private bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    private bool IsFibonacci(int num)
    {
        return IsPerfectSquare(5 * num * num + 4) || IsPerfectSquare(5 * num * num - 4);
    }

    private bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}
