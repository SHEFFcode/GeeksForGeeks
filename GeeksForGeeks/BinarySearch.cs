using System;
namespace GeeksForGeeks
{
    public class BinarySearch
    {
        //Always deals with a sorted set, where are are tasked to find a specific item (does it exist, and what is its position?
        //Runtime Complexity: log(n)
        //Auxilary Space is O(1)
        //Algorithmic paradigm: divide and conquer

        //Example:

        //Input:  [0, 2, 3, 4, 10, 40, 44], look for 2

        //Pass 1: [0, 2, 3, |4|, 10, 40, 44] => Split sorted array in half, if 4 is what we are looking for, we are done, if not split again.
        //Pass 2: [0, |2|, 3] => Since we are looking for 2 and 2 is less then 4 we can look to the left only, we found 2.

        //Important aside - log is the power to which a number must be raised to get some other number.  ex: log(100) = 2, because 10^2 = 100


        /// <summary>
        /// Binary Search Implemented Recursively.
        /// </summary>
        /// <param name="inputArr">Given input array</param>
        /// <param name="L">Left bound</param>
        /// <param name="R">Right bound</param>
        /// <param name="x">Element we are looking for</param>
        public void RunRecursive(int[] inputArr, int x, int L, int R)
        {
            if (L >= R)
            {
                //Base case, we did not find an element in the array
                Console.WriteLine($"{x} is not in the list.");
            }

            var mid = (L + R) / 2;

            if (inputArr[mid] == x)
            {
                Console.WriteLine($"Found element {x} at position {mid + 1}");
            } 
            else if (inputArr[mid] > x)
            {
                R = mid - 1;
                RunRecursive(inputArr, x, L, R);
            } 
            else 
            {
                L = mid + 1;
                RunRecursive(inputArr, x, L, R);
            }

        }

        /// <summary>
        /// Binary Search Implemented Iteratively.
        /// </summary>
        /// <param name="inputArr">Given input array</param>
        /// <param name="x">Element we are looking for</param>
        public void RunIterative(int[] inputArr, int x)
        {
            var L = 0;
            var R = inputArr.Length;
            var mid = (L + R) / 2;

            while(R >= L)
            {
                mid = (L + R) / 2;

				if (inputArr[mid] == x)
				{
					Console.WriteLine($"Found element {x} at position {mid + 1}");
                    return;
				}
                else if (inputArr[mid] > x)
                {
                    R = mid - 1;
                }
                else 
                {
                    L = mid + 1;
                }

            }

            if (L >= R)
            {
				Console.WriteLine($"{x} is not in the list.");
			}

        }

    }
}
