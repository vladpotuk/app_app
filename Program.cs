using System;

class MainProgram
{
    static void Main(string[] args)
    {
        NumberChecker checker = new NumberChecker();

        Console.Write("Введіть число: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Число парне: {checker.Invoke(OperationType.Even, num)}");
        Console.WriteLine($"Число непарне: {checker.Invoke(OperationType.Odd, num)}");
        Console.WriteLine($"Число просте: {checker.Invoke(OperationType.Prime, num)}");
        Console.WriteLine($"Число Фібоначчі: {checker.Invoke(OperationType.Fibonacci, num)}");
    }
}
