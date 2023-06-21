using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] filteredArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Оригінальний масив:");
        PrintArray(originalArray);

        Console.WriteLine("Масив для фільтрації:");
        PrintArray(filterArray);

        Console.WriteLine("Результат роботи методу:");
        PrintArray(filteredArray);

        Console.ReadLine();
    }

    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Except(filterArray).ToArray();
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
