/// <summary>
/// The main class containing the entry point of the program and various utility methods.
/// </summary>
internal class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    private static void Main()
    {
        int[] numbers = ReadNumbersFromInput();
        BubbleSort(numbers);
        DisplaySortedNumbers(numbers);
    }

    /// <summary>
    /// Reads a line of input from the console, splits it by commas, and converts it to an array of integers.
    /// </summary>
    /// <returns>An array of integers parsed from the input string.</returns>
    /// <exception cref="FormatException">Thrown when the input string contains non-numeric values.</exception>
    /// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
    private static int[] ReadNumbersFromInput()
    {
        Console.Write("Enter numbers separated by commas: ");
        return Console.ReadLine().Split(',').Select(int.Parse).ToArray();
    }

    /// <summary>
    /// Sorts an array of integers using the bubble sort algorithm.
    /// </summary>
    /// <param name="numbers">The array of integers to be sorted.</param>
    private static void BubbleSort(int[] numbers)
    {
        int length = numbers.Length;
        bool swapped;
        for (int pass = 0; pass < length - 1; pass++)
        {
            swapped = false;
            for (int index = 0; index < length - pass - 1; index++)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    Swap(numbers, index, index + 1);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break; // Exit early if no swaps were made
            }
        }
    }

    /// <summary>
    /// Swaps the elements at the specified indices in the array.
    /// </summary>
    /// <param name="numbers">The array of integers.</param>
    /// <param name="firstIndex">The index of the first element to swap.</param>
    /// <param name="secondIndex">The index of the second element to swap.</param>
    private static void Swap(int[] numbers, int firstIndex, int secondIndex)
    {
        (numbers[secondIndex], numbers[firstIndex]) = (numbers[firstIndex], numbers[secondIndex]);
    }

    /// <summary>
    /// Displays the sorted array of integers to the console.
    /// </summary>
    /// <param name="numbers">The array of sorted integers to be displayed.</param>
    private static void DisplaySortedNumbers(int[] numbers)
    {
        Console.WriteLine("Sorted numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
