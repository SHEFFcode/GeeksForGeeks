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
            if (desiredFib <= 0)
            {
                return 0;
            }
            else if (desiredFib == 1)
            {
                return 1;
            }
            else
            {
                return RunRecursive(desiredFib - 1) + RunRecursive(desiredFib - 2);
            }
        }

        public int RunMemoization(int desiredFib, int[] memoizationArr)
        {
            if (desiredFib <= 0)
            {
                return 0;
            }
            else if (desiredFib == 1)
            {
                return 1;
            }
            else if (memoizationArr[desiredFib] != 0) 
            {
                return memoizationArr[desiredFib];
            }
            else
            {
                memoizationArr[desiredFib] = RunMemoization(desiredFib - 1, memoizationArr) + RunMemoization(desiredFib - 2, memoizationArr);
                return memoizationArr[desiredFib];
            }
        }
    }
}
