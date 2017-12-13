using System;
namespace GeeksForGeeks.DynamicProgramming
{
    public class LPS
    {
        public LPS()
        {
        }
        public int RunLPS(string seq)
        {
            int n = seq.Length; //just take down the length of the sequence given.
            int i, j, cl; //some variables we will use later on.
            int[,] L = new int[n,n]; //this is the matrix we will use as our data structure for dynamic programming

            for (i = 0; i < n; i++) //loop to fill out the middle matrix across with 1s, like shown above.
            {
                L[i, i] = 1; //since each character in a sequence is a pallindrom by itself by definition
            }

            //cl: cl here is the current length of the substring. j will be based off it, and we will use it to see
            //when we should stop, specifically when its length equalizes with the length of the given sequence, which
            //is why the loop is from 2 to <= n. It starts at 2 because we have done all subsequences of length 1 with
            // the for loop directly above, per definition, and we stop when cl > n (ie we reach the end of the string
            //with the last character included.

            for (cl = 2; cl <= n; cl++) //we set up cl = 2 because we already did cl = 1 per above
            {
                for (i = 0; i < n - cl + 1; i++) // we run i from i = 0 to n - j since there would not be
                                                 // enought string to move on.
                                                 // because i needs to be a certain cl - 1 distance from
                                                 // j we need to get all values for i = 0 to i = n - j
                                                 // which will be n - ((i = 0) +cl - 1) or n - cl + 1
                {
                    j = i + cl - 1; //j will be a certain length away from i. Specifically
                                    // it will be cl away from i, but since cl is 1 based counting
                                    // and for loop is 0 based counting, we have to deduct 1.
                                    // u can also think of it that an inclusing substring from 
                                    // i == 0 and j == 1 is 2 characters long.

                    if (seq[i] == seq[j] && cl == 2) // chars same, but see catch from theory or under diagram above.
                    {
                        L[i, j] = 2;
                    }
                    else if (seq[i] == seq[j]) //characters are same and we do not have a catch.
                    {
                        L[i, j] = L[i + 1, j - 1] + 2; //we add the two common letters to total between chars so far.
                    }
                    else //here the characters don't match at all
                    {
                        L[i, j] = Math.Max(L[i, j - 1], L[i + 1, j]); //This is the max from start to current letter
                                                                      // either including the first letter or current
                                                                      // since chars are not the same we want max we
                                                                      // can get with either one of them.
                    }
                }
            }

            return L[0, n - 1]; //we return the value in the top right corner, as that will always be the highest value.

        }

    }
}
