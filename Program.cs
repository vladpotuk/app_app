using System;

class MainProgram
{
    static void Main(string[] args)
    {
        
        IOperationStrategy additionStrategy = new AdditionStrategy();
        IOperationStrategy subtractionStrategy = new SubtractionStrategy();
        IOperationStrategy multiplicationStrategy = new MultiplicationStrategy();

        
        Calculator calculator = new Calculator(additionStrategy);

        double num1 = 10;
        double num2 = 5;

        
        double sum = calculator.ExecuteStrategy(num1, num2);
        double difference = calculator.ExecuteStrategy(num1, num2);
        double product = calculator.ExecuteStrategy(num1, num2);

        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Різниця: {difference}");
        Console.WriteLine($"Добуток: {product}");
    }
}
