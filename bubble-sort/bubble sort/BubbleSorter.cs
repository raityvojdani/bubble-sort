namespace BubbleSort
{
    /// <summary>
    /// Class for sorting numbers using the bubble sort algorithm.
    /// </summary>
    public class BubbleSorter : ISorter
    {
        /// <summary>
        /// Sorts an array of integers using the bubble sort algorithm.
        /// </summary>
        /// <param name="numbers">The array of integers to be sorted.</param>
        public void Sort(int[] numbers)
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
        private void Swap(int[] numbers, int firstIndex, int secondIndex)
        {
            (numbers[secondIndex], numbers[firstIndex]) = (numbers[firstIndex], numbers[secondIndex]);
        }
    }
}
