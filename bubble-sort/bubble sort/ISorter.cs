namespace BubbleSort
{
    /// <summary>
    /// Interface for sorting numbers.
    /// </summary>
    public interface ISorter
    {
        /// <summary>
        /// Sorts an array of integers.
        /// </summary>
        /// <param name="numbers">The array of integers to be sorted.</param>
        void Sort(int[] numbers);
    }
}
