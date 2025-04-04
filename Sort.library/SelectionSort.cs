using System;

namespace Sort.library
{
    public class SelectionSort
    {
        // Selection sort voor integers
        public static void Sort(int[] input)
        {

            var startIndex = 0;

            while (startIndex < input.Length - 1)
            {
                var smallestIndex = startIndex;
                for (var i = startIndex; i < input.Length; ++i)
                {
                    if (input[i] < input[smallestIndex])
                    {
                        smallestIndex = i;
                    }
                }

                (input[smallestIndex], input[startIndex]) = (input[startIndex], input[smallestIndex]);
                startIndex++;
            }

        }

        // Selection sort voor strings
        public static void Sort(string[] input)
        {
            var startIndex = 0;

            while (startIndex < input.Length - 1)
            {
                var smallestIndex = startIndex;
                for (var i = 0; i < input.Length; ++i)
                {
                    if (input[i].CompareTo(input[smallestIndex]) > 0)
                    {
                        smallestIndex = i;
                    }
                }

                (input[smallestIndex], input[startIndex]) = (input[startIndex], input[smallestIndex]);
                startIndex++;
            }
        }
    }
}
