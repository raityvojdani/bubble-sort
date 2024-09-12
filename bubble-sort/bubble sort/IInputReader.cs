namespace BubbleSort
{
    /// <summary>
    /// Interface for reading input numbers.
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// Reads numbers from the input source.
        /// </summary>
        /// <returns>An array of integers read from the input source.</returns>
        int[] ReadNumbers();
    }
}
