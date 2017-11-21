using System;
namespace GeeksForGeeks.Sorting
{
    public class MergeSort
    {

        private void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged
            int leftHalfSize = m - l + 1;
            int rightHalfSize = r - m;
            int i, j; //declare iterator loop variables

            /* Create temp arrays */
            int[] L = new int[leftHalfSize];
            int[] R = new int[rightHalfSize];

            for (i = 0; i < leftHalfSize; ++i) // Fill out the L array
            {
                L[i] = arr[i + l]; // same location in arr, offset by left bound
            }
            for (j = 0; j < rightHalfSize; ++j) // Fill out the R array
            {
                R[j] = arr[j + m + 1]; // same location, offset by mid + 1 bound
            }


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged subarry array
            int k = l;
            while (i < leftHalfSize && j < rightHalfSize)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < leftHalfSize)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < rightHalfSize)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public void Run(int[] arr, int l, int r)
        {
            if (l < r) // as long as left pointer is smaller then right
            {
                int m = l + (r - l) / 2; // Find the middle point no overflow

                Run(arr, l, m); // Sort the right half (pre midpoint)
                Run(arr, m + 1, r); // Sort the left half (post midpoint)

                Merge(arr, l, m, r); // Merge the two sorted halves.
            }
        }
    }
}
