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


    }
}
