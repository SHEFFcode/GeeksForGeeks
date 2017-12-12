using System;
namespace GeeksForGeeks.DynamicProgramming
{
    public class LIS
    {
        public LIS()
        {
        }

        public int runLIS(int[] arr, int n)
        {
            int[] lis = new int[n]; // initialize the lis array.
            int i, j, max = 0; // initialize vars

            for (i = 0; i < n; i++)
            {
                lis[i] = 1; // init lis arr to 1s per theory above.
            }

            for (i = 1; i < n; i++) // begin for loop logic with i = 1 per logic above.
            {
                for (j = 0; j < i; j++) // bigin for loop logic with j = 0 and continue while j < i per logic above.
                {
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1) // if we have an increasing subsequence and its length is longer then it currently is
                    {
                        lis[i] = lis[j] + 1; // increase the longest subsequence number.  So we keep track of the longest subsiquence this number is part of.
                    }
                }
            }

            for (i = 0; i < n; i++) //once we have gone through the whole loop and found the longest subsequnce for every number
            {
                if (max < lis[i]) // we look for the maximu increasing subsequnce.
                {
                    max = lis[i]; // we set the longest increasing subsequence up to this point to max.
                }
            }


            return max; // we return the final longest incresing subsequence number.
        }

    }
}
