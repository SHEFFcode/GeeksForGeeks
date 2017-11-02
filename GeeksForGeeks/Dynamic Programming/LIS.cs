using System;
namespace GeeksForGeeks.DynamicProgramming
{
    public class LIS
    {
        public LIS()
        {
        }

        //Longest Increasing subsequence is a typical problem that can be solved using dynamic programming.
        //It has an optimal substructure and repeating subproblems.

        //The problem is solved in the follwing recursive manner:

        //                  lis(4)
        //                  /     \
        //              list(3)   lis(2) lis(1)
        //              /  \        /
        //         lis(2) lis(1)  lis(1)
        //          /
        //        lis(1)

        //You can see here that lis(1) is solved three times, and solution to below subproblems produce the correct solution for the problem as a whole.

        // _________________________________________________
        //|itterator|  j |  i |    |    |    |    |    |    |
        //|input[]  | 10 | 22 | 09 | 33 | 21 | 50 | 41 | 60 |
        //|LIS[]    |  1 |1,2 |  1 |  1 | 1  |  1 |  1 | 1  |
        // -------------------------------------------------

        //Loop from j == 0 to j == i
        // if (input[i] > input [j] we have an increasing subsequence, and LIS[i] becomes LIS[j] + 1, provided it's bigger then LIS[i].
        // Note: when i == 0  LIS[i] is already 1, because each individual number is an increasing subsequence, so we start with i == 1.
        // on the first pass we see that 22 > 10, so LIS[1] becaomes LIS[0] + 1 = 1 + 1 = 2.
        // once j == i we reset j to 0 and move it to the right and repeat the process.
        // if LIS[j] < LIS[i] keep moving j to the right till u hit i.




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
