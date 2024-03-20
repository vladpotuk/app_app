using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Парні числа:");
            ArrayFilters.PrintFilteredArray(array, ArrayFilters.IsEven);

            Console.WriteLine("\nНепарні числа:");
            ArrayFilters.PrintFilteredArray(array, ArrayFilters.IsOdd);

            Console.WriteLine("\nПрості числа:");
            ArrayFilters.PrintFilteredArray(array, ArrayFilters.IsPrime);

            Console.WriteLine("\nЧисла Фібоначчі:");
            ArrayFilters.PrintFilteredArray(array, ArrayFilters.IsFibonacci);
        }
    }
}
