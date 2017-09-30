using System;
namespace GeeksForGeeks
{
    public class Quicksort
    {
		//Type of algorithm: divide and conquer
		//Picks and element as a pivot and partitions the given array around the picked pivot.

		// Runtime Complexity: O(n^2), but Θ(nlogn).  We can be pretty sure that it will not hit it's worst time complexity if we randomize.
        // Space Complexity: O(1), algorithm is done in place, and does not require any extra memory. But because it creates recursive calls, it will have O(n) extra space for stack frames
        // Doing tail recursion optimization can limit that auxilary space to O(logn).
		// The algorithm is tail recursive.
		// Quicksort is not a stable sort.
		// Quicksort is implemented for sort for most languages

		//The pivot is usually one of the following:
		//First element | Last element | Random element | Median
		//Sorts the elements in such a way that elements to the left are smaller then pivot, and on the right are larger then pivot


		// input: [|7, 2, 1, 6, 8, 5, 3, 4] => first we pick a pivot element position, in this case it will be the last element. i is the first element right of wall
		//                              ^ pivot

		// [2, |7, 1, 6, 8, 5, 3, 4] => 2 is smaller then 4, so we swap first element to the right of the wall with it, and increase i. i is now 1
		// [2, 1, |7, 6, 8, 5, 3, 4] => 1 is smaller then 4, so we swap it and the first element to the irght of the wall, and increase i, i is now 2.
		// [2, 1, |7, 6, 8, 5, 3, 4] => 6 is bigger then 4, so we continue
		// [2, 1, |7, 6, 8, 5, 3, 4] => 8 is bigger then 4, so we continue
		// [2, 1, |7, 6, 8, 5, 3, 4] => 5 is bigger then 4, so we continue
		// [2, 1, |7, 6, 8, 5, 3, 4] => 3 is smaller then 4, so we swap with first element to the right of the wall, which is still 7, and increase i, i is now 3.
		// [2, 1, 3, |6, 8, 5, 7, 4] => now we get to 4 itself, so we swap 4 and first element to the right of the wall, and we have 2 sub problems to look at.
		// [2, 1, 3][4][6, 8, 5, 7] => we pick the two indecies, 3 and 7
		// [|2, 1, 3] => 2 is smaller then 3, so we swap it with itself, and increase i.
		// [2, |1, 3] => 1 issmaller then 3, so we swap it with first element, so we swap it with itself, increase i
		// [2, 1, |3] => we swap 3 with first el to the right of wall, which is itself, so we move on to its subproblem
		// [|2, 1] => 1 is the pivot, 2 is bigger then 1, so we continue
		// [2, |1] => 1 is itself, so we swap with the element to the right of the pivot, which is itself and continue tp the subproblem
		// [2] => 2 is a subproblem, but onely has one element, so we end the recursion here. Similar thing happens in the other side of the array at first pivot.

        // Recursion wrapper
        public void QuicksortWrapper (int[] A, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(A, start, end); // we partition the array such that elements smaller are on the right and elements higher are on the left, and return pi
                QuicksortWrapper(A, start, partitionIndex - 1); // Run recursion on the left side of the array
                QuicksortWrapper(A, partitionIndex + 1, end); // Run recursion on the right side of the array
            }
        }

        // Partition logic
        private int Partition(int[] A, int start, int end)
        {
            var pivot = A[end]; // pick a pivort as the last element
            var i = start - 1; // i is a wall here, so at first the wall is to the irght of the array at i = -1
            for (int j = start; j < end; j++)
            {
                if (A[j] < pivot) // let's compare the the jth element in the array with our pivot, to see if it's smaller then pivot
                {
                    i++; // move the wall to the right, and by doing it create a selector for element to right of wall where it was before
                    //swap array i with the first element to the right of the wall
                    var tempj = A[j];
                    A[j] = A[i];
                    A[i] = tempj;
                }
            }

			//Once we reach the end of the array, we want to swap the last element (pivot) with the element to the right of the wall (i+1)
			var tempi = A[i + 1];
			A[i + 1] = A[end];
            A[end] = tempi;

            return i + 1; //Return the position of the wall after the swap.

        }


		//PS: See this article for space optimization: http://www.geeksforgeeks.org/quicksort-tail-call-optimization-reducing-worst-case-space-log-n/


		//Linkes:
		//https://www.youtube.com/watch?v=COk73cpQbFQ - mycodeschool
		//https://www.youtube.com/watch?v=aQiWF4E8flQ - CS50
		//http://www.geeksforgeeks.org/quick-sort/ - G4G written explanation
		//https://www.youtube.com/watch?v=PgBzjlCcFvc - G4g video explanation
	}
}
