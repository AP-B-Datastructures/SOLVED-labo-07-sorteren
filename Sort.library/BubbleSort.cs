using System;
using Sort.Helpers.Library;

namespace Sort.library
{
    /// <summary>
    /// This class contains the Bubble sort algorithm.
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Sort the given input (list of integers) in ascending order 
        /// (from smallest to the largest number)
        /// The list is sorted 'in-place' and since an array is passed
        /// 'by-reference' there is no return value
        /// </summary>
        /// <param name="input">list of numbers</param>
        public static void Sort(int[] input)
        {
            //Todo: implement the bubble sort algorithm
            //see also the pseudo-code in the gitbook
            throw new NotImplementedException();
        }

        public static int[] SortAdaptive(int[] input)
        {
            throw new NotImplementedException();
        }

        public static double[] Sort(double[] input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compare the 2 numbers and return a value that indicates their sort order.
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>
        /// Return -1 if n1 is smaller than n2
        /// Return +1 of n1 is larger than n2 
        /// Return 0 if both numbers are equal.
        /// </returns>
        private static int Compare(double n1, double n2)
        {
            return 0;
        }
        

        public static Car[] Sort(Car[] input)
        {
            throw new NotImplementedException();
        }

        private static int Compare(Car c1, Car c2)
        {
            return 0;
        }

    }
}
