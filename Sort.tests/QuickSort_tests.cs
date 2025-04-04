using System;
using Sort.library;

namespace Sort.tests
{
    [TestClass]
    public class QuickSort_tests
    {
        [TestMethod]
        public void QuickSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = {5, 1, 3, 2, 4};
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 5, 5, 5, 5, 1 }, new int[]{ 1, 5, 5, 5, 5 })]
        [DataRow(new int[]{ 5, 5, 4, 4, 1 }, new int[]{ 1, 4, 4, 5, 5 })]
        public void QuickSort_HandlesArrayWithDuplicates(int[] input, int[] expected)
        {
            // Arrange

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
        
        [TestMethod]
        public void QuickSort_SortsDoublesArrayInAscendingOrder()
        {
            // Arrange
            double[] input = { 5, 2, 9, 1, 5, 6 };
            double[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            QuickSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}