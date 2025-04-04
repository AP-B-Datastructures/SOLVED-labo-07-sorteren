using System;
using Sort.library;

namespace Sort.tests
{
    [TestClass]
    public class SelectionSort_tests
    {
        [TestMethod]
        public void SelectionSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = {5, 1, 3, 2, 4};
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void SelectionSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void SelectionSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void SelectionSort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void SelectionSort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 5, 5, 5, 5, 1 }, new int[]{ 1, 5, 5, 5, 5 })]
        [DataRow(new int[]{ 5, 5, 4, 4, 1 }, new int[]{ 1, 4, 4, 5, 5 })]
        public void SelectionSort_HandlesArrayWithDuplicates(int[] input, int[] expected)
        {
            // Arrange

            // Act
            SelectionSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}