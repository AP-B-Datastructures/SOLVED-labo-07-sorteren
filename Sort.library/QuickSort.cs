using System;

namespace Sort.library
{
    public class QuickSort
    {
        public static void Sort(int[] input)
        {
            Sort(input, 0, input.Length - 1);
        }

        public static void Sort(int[] input, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int pivotIndex = Partition(input, startIndex, endIndex);
            // pivot is already in the right place, so we don't need to include it in either sort function
            // sort the part before the pivot
            Sort(input, startIndex, pivotIndex - 1);
            // sort the part after the pivot
            Sort(input, pivotIndex + 1, endIndex);
        }

        // this function will split the array in 3 parts:
        // - the pivot (a single element)
        // - the elements smaller than the pivot
        // - the elements larger than the pivot
        // at the end of the function, we will put the pivot in between those two parts 
        public static int Partition(int[] input, int startIndex, int endIndex)
        {
            // e.g. [5, 2, 9, 1, 5, 6]
            // we choose the first element as our pivot
            int pivot = input[startIndex]; // e.g. 5
            int lastSmallerIndex = startIndex; // e.g. 0

            // now we rearrange the array in 3 parts:
            // - the pivot (a single element)
            // - the elements smaller than the pivot
            // - the elements larger than the pivot
            for (int i = startIndex + 1; i <= endIndex; ++i)
            {
                // if an element should be moved to the "smaller than" part
                if (input[i] < pivot)
                {
                    // increase the index of the last smaller element
                    lastSmallerIndex++;
                    // then put the current element in that spot
                    (input[lastSmallerIndex], input[i]) = (input[i], input[lastSmallerIndex]);
                }
            }

            // now the array is sorted in three parts:
            // - a pivot-part
            // - a smaller-than-pivot-part
            // - a larger-than-pivot-part
            // [(5),( 2, 1), (9, 5, 6)] (brackets added for clarity)

            // now we put the pivot between the "smaller" and "larger" part
            // by swapping the last element that is smaller with the pivot (which is still at the startindex)
            (input[lastSmallerIndex], input[startIndex]) = (input[startIndex], input[lastSmallerIndex]);

            // the pivot is now located at the spot where the last smaller element used to be
            // (because we swapped the on the line before this one)
            // note: this step is purely for clarification, but could be skipped
            int pivotIndex = lastSmallerIndex;

            // return the index of the pivot
            return pivotIndex;
        }

        public static void Sort(double[] input)
        {
            Sort(input, 0, input.Length - 1);
        }

        public static void Sort(double[] input, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int pivotIndex = Partition(input, startIndex, endIndex);
            // pivot is already in the right place, so we don't need to include it in either sort function
            // sort the part before the pivot
            Sort(input, startIndex, pivotIndex - 1);
            // sort the part after the pivot
            Sort(input, pivotIndex + 1, endIndex);
        }

        // this function will split the array in 3 parts:
        // - the pivot (a single element)
        // - the elements smaller than the pivot
        // - the elements larger than the pivot
        // at the end of the function, we will put the pivot in between those two parts 
        public static int Partition(double[] input, int startIndex, int endIndex)
        {
            double pivot = input[startIndex]; // e.g. 5
            int lastSmallerIndex = startIndex; // e.g. 0

            for (int i = startIndex + 1; i <= endIndex; ++i)
            {
                if (Compare(input[i], pivot) < 0)
                {
                    lastSmallerIndex++;
                    (input[lastSmallerIndex], input[i]) = (input[i], input[lastSmallerIndex]);
                }
            }

            (input[lastSmallerIndex], input[startIndex]) = (input[startIndex], input[lastSmallerIndex]);

            return lastSmallerIndex;
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
            if (n1 < n2)
                return -1;
            if (n1 > n2)
                return 1;
            return 0;
        }
    }
}
