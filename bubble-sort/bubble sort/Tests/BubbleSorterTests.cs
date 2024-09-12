using System;
using Xunit;

namespace BubbleSort.Tests
{
    public class BubbleSorterTests
    {
        [Fact]
        public void Sort_SortsArrayOfIntegers()
        {
            // Arrange
            var sorter = new BubbleSorter();
            int[] numbers = { 5, 3, 8, 4, 2 };

            // Act
            sorter.Sort(numbers);

            // Assert
            Assert.Equal(new int[] { 2, 3, 4, 5, 8 }, numbers);
        }

        [Fact]
        public void Sort_SortsArrayWithNegativeNumbers()
        {
            // Arrange
            var sorter = new BubbleSorter();
            int[] numbers = { -3, -1, -2, -5, -4 };

            // Act
            sorter.Sort(numbers);

            // Assert
            Assert.Equal(new int[] { -5, -4, -3, -2, -1 }, numbers);
        }

        [Fact]
        public void Sort_SortsArrayWithDuplicates()
        {
            // Arrange
            var sorter = new BubbleSorter();
            int[] numbers = { 3, 1, 2, 3, 2 };

            // Act
            sorter.Sort(numbers);

            // Assert
            Assert.Equal(new int[] { 1, 2, 2, 3, 3 }, numbers);
        }

        [Fact]
        public void Sort_SortsEmptyArray()
        {
            // Arrange
            var sorter = new BubbleSorter();
            int[] numbers = { };

            // Act
            sorter.Sort(numbers);

            // Assert
            Assert.Equal(new int[] { }, numbers);
        }

        [Fact]
        public void Sort_SortsSingleElementArray()
        {
            // Arrange
            var sorter = new BubbleSorter();
            int[] numbers = { 1 };

            // Act
            sorter.Sort(numbers);

            // Assert
            Assert.Equal(new int[] { 1 }, numbers);
        }
    }
}
