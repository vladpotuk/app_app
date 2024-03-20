using System;
public class MainProgram
{
    static void Main(string[] args)
    {
        Predicate<int> isEven = Operations.IsEven;
        Predicate<int> isOdd = Operations.IsOdd;
        Predicate<int> isPrime = Operations.IsPrime;
        Predicate<int> isFibonacci = Operations.IsFibonacci;

        Console.Write("Введіть число: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Число парне: {isEven(num)}");
        Console.WriteLine($"Число непарне: {isOdd(num)}");
        Console.WriteLine($"Число просте: {isPrime(num)}");
        Console.WriteLine($"Число Фібоначчі: {isFibonacci(num)}");
    }
}
