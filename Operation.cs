using System;

public static class Operations
{
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    public static bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    public static bool IsPrime(int num)
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

    public static bool IsFibonacci(int num)
    {
        return IsPerfectSquare(5 * num * num + 4) || IsPerfectSquare(5 * num * num - 4);
    }

    private static bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}
