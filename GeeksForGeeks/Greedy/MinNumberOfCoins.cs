using System;
using System.Collections.Generic;

namespace GeeksForGeeks.Greedy
{
    public class MinNumberOfCoins
    {
        public void Run(int[] currency, int changeToGive)
        {
            List<int> coinsUsed = new List<int>();  // This will contain the result

            for (int i = currency.Length - 1; i > -1; i--)
            {
                while (changeToGive >= currency[i])  // while we still have some change to give out
                {
                    changeToGive -= currency[i]; // reduce the amount of change we still need to give
                    coinsUsed.Add(currency[i]);  // add the coin use to the solution
                }
            }

            foreach (var coin in coinsUsed)
            {
                Console.WriteLine(coin);
            }
        }
    }
}
