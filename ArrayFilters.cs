using System;


namespace ArrayOperations
{
    public class ArrayFilters
    {
        
        public static void PrintFilteredArray(int[] array, Func<int, bool> checkMethod)
        {
            foreach (int number in array)
            {
                if (checkMethod(number))
                {
                    Console.Write(number + " ");
                }
            }
        }

        
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        
        public static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) ||
                   IsPerfectSquare(5 * number * number - 4);
        }

        
        static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }
    }
}
