using System;

delegate double ArithmeticOperation(double x, double y);

class Program
{
   
    static double Add(double x, double y)
    {
        return x + y;
    }

    
    static double Subtract(double x, double y)
    {
        return x - y;
    }

    
    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        
        ArithmeticOperation add = Add;
        ArithmeticOperation subtract = Subtract;
        ArithmeticOperation multiply = Multiply;

        
        Console.Write("Введіть перше число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = double.Parse(Console.ReadLine());

        
        Console.WriteLine($"Сума: {add(num1, num2)}");
        Console.WriteLine($"Різниця: {subtract(num1, num2)}");
        Console.WriteLine($"Добуток: {multiply(num1, num2)}");
    }
}
