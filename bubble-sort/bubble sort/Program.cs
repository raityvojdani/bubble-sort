using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by commas: ");
        int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        BubbleSort(numbers);

        Console.WriteLine("Sorted numbers:");
        foreach (int a in numbers)
        {
            Console.WriteLine(a);
        }
    }

    static void BubbleSort(int[] numbers)
    {
        int n = numbers.Length;
        for (int j = 0; j < n - 1; j++)
        {
            for (int i = 0; i < n - j - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                }
            }
        }
    }
}
