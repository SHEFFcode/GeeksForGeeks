using System;
namespace GeeksForGeeks.Greedy
{
    public class MinNumPlatforms
    {
        public int Run(float[] arrival, float[] departure)
        {
            //Assume arrays are given to us sorted, or we have a sort function available in nlogn

            int platformsNeeded = 1, result = 1, i = 1, j = 0, n = arrival.Length; // set up some variables

            while (i < n && j < n) // set up an iteration look over the two arrays
            {
                if (arrival[i] < departure[j]) // we go another arival before a departure
                {
                    platformsNeeded++;
                    i++;
                    if (platformsNeeded > result)
                    {
                        result = platformsNeeded; // update the result variable to max value of platforms needed
                    }
                }
                else // we got a departure before an arrival
                {
                    platformsNeeded--;
                    j++;
                }
            }

            return result;
        }
    }
}
