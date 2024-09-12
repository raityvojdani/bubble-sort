namespace BubbleSort
{
    /// <summary>
    /// Class for reading input numbers from the console.
    /// </summary>
    public class ConsoleInputReader : IInputReader
    {
        /// <summary>
        /// Reads numbers from the console input.
        /// </summary>
        /// <returns>An array of integers read from the console input.</returns>
        public int[] ReadNumbers()
        {
            Console.Write("Enter numbers separated by commas: ");
            return Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        }
    }
}
