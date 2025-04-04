using System;

namespace Sort.library
{
    public class InsertionSort
    {
        public static void Sort(int[] input)
        {
            
            /*
            // de start index van het niet-gesorteerde deel
            startIndex = 1

            while startIndex < mijnLijst.length
                key = mijnLijst[startIndex]
                
                for i = startIndex; i >= 0; --i
                    if i > 0 AND key < mijnLijst[i-1]
                        mijnLijst[i] = mijnLijst[i-1]
                    else
                        mijnLijst[i] = key
                        break
                    endif
                endfor
                
                startIndex++
            endwhile
            
            */

            int unsortedIndex = 1;

            while (unsortedIndex < input.Length)
            {
                int key = input[unsortedIndex];

                for (int i = unsortedIndex; i >= 0; --i)
                {
                    if (i > 0 && key < input[i - 1])
                    {
                        input[i] = input[i - 1];
                    }
                    else
                    {
                        input[i] = key;
                        break;
                    }
                }
                unsortedIndex++;
            }
        }

        public static void Sort(string[] input)
        {
            int unsortedIndex = 1;

            while (unsortedIndex < input.Length)
            {
                string key = input[unsortedIndex];

                for (int i = unsortedIndex; i >= 0; --i)
                {
                    if (i > 0 && Compare(key, input[i - 1]) < 0)
                    {
                        input[i] = input[i - 1];
                    }
                    else
                    {
                        input[i] = key;
                        break;
                    }
                }
                unsortedIndex++;
            }
        }

        /// <summary>
        /// Compare the 2 strings and return a value that indicates their sort order.
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>
        /// Return -1 if n1 is shorter than n2
        /// Return +1 of n1 is longer than n2 
        /// if both strings are equal in length, return -1 if n1 comes before n2 (alfabetical)
        /// if both strings are equal in length, return +1 if n1 comes after n2 (alfabetical)
        /// if both strings are equal, return 0
        /// </returns>
        private static int Compare(string n1, string n2)
        {
            if (n1.Length < n2.Length)
                return -1;
            if (n1.Length > n2.Length)
                return 1;
            return n1.CompareTo(n2);
        }
    }
}
