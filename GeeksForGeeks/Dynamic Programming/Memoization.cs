using System;

namespace GeeksForGeeks.DynamicProgramming
{
    public class Memoization
    {
        public Memoization()
        {
        }

        public int RunRecursive(int desiredFib)
        {
            if (desiredFib == 0 || desiredFib == 1)
            {
                return desiredFib;
            }
            else
            {
                return RunRecursive(desiredFib - 1) + RunRecursive(desiredFib - 2);
            }
        }

        public int RunMemoization(int desiredFib, int[] memoizationArr = null)
        {
            //initialize the memoization array on our first path where it's set ot null as default.
            if (memoizationArr == null)
            {
                memoizationArr = new int[desiredFib + 1];
            }

            //base case
            if (desiredFib == 0 || desiredFib == 1)
            {
                return desiredFib;
            }

            //memoization
            if (memoizationArr[desiredFib] != 0) 
            {
                //This will happen when we run into repeating subproblems.
                return memoizationArr[desiredFib];
            }
            else
            {
                //Fill in the memoization table
                memoizationArr[desiredFib] = RunMemoization(desiredFib - 1, memoizationArr) + RunMemoization(desiredFib - 2, memoizationArr);
                //Once we are done filling we return the result from the table, so that the recursion can continue during first repeating subproblem as well as returns the final result.
                return memoizationArr[desiredFib];
            }
        }

        public int RunTabulation(int desiredFib, int[] tabulationArr = null)
        {
            //initialize the memoization array on our first path where it's set ot null as default.
            if (tabulationArr == null)
            {
                tabulationArr = new int[desiredFib + 1];
            }

            //tabulation
            tabulationArr[0] = 0;
            tabulationArr[1] = 1;
            for (int i = 2; i <= desiredFib; i++)
            {
                tabulationArr[i] = tabulationArr[i - 2] + tabulationArr[i - 1];
            }

            //return result from the tabulation table.
            return tabulationArr[desiredFib];
        }
    }
}
