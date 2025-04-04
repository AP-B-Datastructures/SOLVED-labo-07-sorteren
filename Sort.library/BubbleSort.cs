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
            for (int i = input.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    int current = input[j];
                    int next = input[j + 1];
                    if (current > next)
                    {
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }
            }
        }

        public static void SortAdaptive(int[] input)
        {
            for (int i = input.Length - 1; i > 0; --i)
            {
                bool canStop = true;

                for (int j = 0; j < i; ++j)
                {
                    int current = input[j];
                    int next = input[j + 1];
                    if (current > next)
                    {
                        canStop = false;
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }

                if (canStop == true)
                {
                    break;
                }
            }
        }

        public static void Sort(double[] input)
        {
            //Todo: implement the bubble sort algorithm
            //see also the pseudo-code in the gitbook
            for (int i = input.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    double current = input[j];
                    double next = input[j + 1];
                    if (Compare(current, next) > 0)
                    {
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }
            }
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
        

        public static void Sort(Car[] input)
        {
            for (int i = input.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Car current = input[j];
                    Car next = input[j + 1];
                    if (Compare(current, next) > 0)
                    {
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }
            }
        }

        private static int Compare(Car c1, Car c2)
        {
            if (c1.Year < c2.Year)
                return -1;
            if (c1.Year > c2.Year)
                return 1;
            if (c1.Kilometers > c2.Kilometers)
                return -1;
            if (c1.Kilometers < c2.Kilometers)
                return 1;
            return 0;
        }

    }
}
