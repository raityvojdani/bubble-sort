namespace BubbleSort
{
    /// <summary>
    /// Class for writing output numbers to the console.
    /// </summary>
    public class ConsoleOutputWriter : IOutputWriter
    {
        /// <summary>
        /// Writes numbers to the console output.
        /// </summary>
        /// <param name="numbers">The array of integers to be written.</param>
        public void WriteNumbers(int[] numbers)
        {
            Console.WriteLine("Sorted numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
