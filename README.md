# Bubble Sort Program

## Overview

This project implements a simple Bubble Sort algorithm in C#. The program reads a series of integers from the console, sorts them using the Bubble Sort algorithm, and then displays the sorted integers back to the console.

## Features

- Reads a list of integers from user input.
- Implements the Bubble Sort algorithm to sort the integers.
- Displays the sorted list of integers.

## Prerequisites

- .NET SDK (version 5.0 or later)

## How to Run the Program

1. **Clone the Repository**

   Clone this repository to your local machine using:

   ```sh
   git clone https://github.com/yourusername/bubble-sort.git
   cd bubble-sort
   ```

2. **Build the Project**

   Navigate to the project directory and build the project using the .NET CLI:

   ```sh
   dotnet build
   ```

3. **Run the Program**

   Run the application using the .NET CLI:

   ```sh
   dotnet run
   ```

4. **Input the Numbers**

   When prompted, enter a series of integers separated by commas. For example:

   ```sh
   Enter numbers separated by commas: 5,3,8,4,2
   ```

5. **View the Output**

   The program will display the sorted numbers:

   ```sh
   Sorted numbers:
   2
   3
   4
   5
   8
   ```

## Code Explanation

### `Program` Class

#### `Main` Method

```csharp
private static void Main()
{
    int[] numbers = ReadNumbersFromInput();
    BubbleSort(numbers);
    DisplaySortedNumbers(numbers);
}
```

The `Main` method is the entry point of the program. It calls methods to read the numbers from input, sort them, and display the sorted numbers.

#### `ReadNumbersFromInput` Method

```csharp
private static int[] ReadNumbersFromInput()
{
    Console.Write("Enter numbers separated by commas: ");
    return Console.ReadLine().Split(',').Select(int.Parse).ToArray();
}
```

This method reads a line of input from the console, splits the input string by commas, and converts it into an array of integers.

#### `BubbleSort` Method

```csharp
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
```

This method sorts an array of integers using the Bubble Sort algorithm. It repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order.

#### `Swap` Method

```csharp
private static void Swap(int[] numbers, int firstIndex, int secondIndex)
{
    (numbers[secondIndex], numbers[firstIndex]) = (numbers[firstIndex], numbers[secondIndex]);
}
```

This helper method swaps the elements at the specified indices in the array.

#### `DisplaySortedNumbers` Method

```csharp
private static void DisplaySortedNumbers(int[] numbers)
{
    Console.WriteLine("Sorted numbers:");
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
```

This method displays the sorted array of integers to the console.

## Contributing

If you wish to contribute to this project, please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
