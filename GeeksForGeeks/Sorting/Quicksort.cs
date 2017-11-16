using System;
namespace GeeksForGeeks
{
    public class Quicksort
    {
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
