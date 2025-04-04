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
            int[] result = BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BubbleSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesAlreadySortedArray()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesReverseSortedArray()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesArrayWithDuplicates()
        {
            throw new NotImplementedException();
        }
    }
}