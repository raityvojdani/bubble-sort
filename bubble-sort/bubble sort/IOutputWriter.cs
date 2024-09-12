namespace BubbleSort
{
    /// <summary>
    /// Interface for writing output numbers.
    /// </summary>
    public interface IOutputWriter
    {
        /// <summary>
        /// Writes numbers to the output destination.
        /// </summary>
        /// <param name="numbers">The array of integers to be written.</param>
        void WriteNumbers(int[] numbers);
    }
}
