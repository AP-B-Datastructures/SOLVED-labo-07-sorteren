using System;
using Sort.library;

namespace Sort.tests
{
    [TestClass]
    public class MergeSort_tests
    {
        [TestMethod]
        public void MergeSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = {5, 1, 3, 2, 4};
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void MergeSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void MergeSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void MergeSort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void MergeSort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 5, 5, 5, 5, 1 }, new int[]{ 1, 5, 5, 5, 5 })]
        [DataRow(new int[]{ 5, 5, 4, 4, 1 }, new int[]{ 1, 4, 4, 5, 5 })]
        public void MergeSort_HandlesArrayWithDuplicates(int[] input, int[] expected)
        {
            // Arrange

            // Act
            MergeSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}