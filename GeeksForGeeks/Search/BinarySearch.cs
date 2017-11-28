using System;
namespace GeeksForGeeks
{
    public class BinarySearch
    {
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

            var mid = (L + R) / 2; //Midpoint can also be found using (L + ((R-L)/2) so as not to overflow the 32 bit integer see (https://stackoverflow.com/questions/27167943/why-leftright-left-2-will-not-overflow)

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
