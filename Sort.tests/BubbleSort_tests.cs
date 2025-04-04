using System;
using Sort.library;

namespace Sort.tests
{
    [TestClass]
    public class BubbleSort_tests
    {
        [TestMethod]
        public void BubbleSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = { 5, 2, 9, 1, 5, 6 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = { 1, 2, 5, 5, 6, 9 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = { 9, 6, 5, 5, 2, 1 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesArrayWithDuplicates()
        {
            // Arrange
            int[] input = { 1, 5, 5, 5, 6, 5 };
            int[] expected = { 1, 5, 5, 5, 5, 6 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
        
        [TestMethod]
        public void BubbleSort_SortsDoublesArrayInAscendingOrder()
        {
            // Arrange
            double[] input = { 5, 2, 9, 1, 5, 6 };
            double[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}