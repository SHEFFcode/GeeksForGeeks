using System;
namespace GeeksForGeeks.DynamicProgramming
{
    public class LCS
    {
        public LCS()
        {
        }

          //We then move on filling in the matrix in the following manner:
          //* If letters match, we will take the diagonal value, which represents the LCS up to the current char
          //in both strings, and increment it by 1 since we found a match.
          //* If the letters do not match, we simply need to keep count of LCS so far for that string, so we
          //tke the max of the value to the left(LCS up to before this char in the top string) and value
          //to the top(LCS up to before this char in the left string).
          //* Finally when we conclude building up the matrix(bottom up approach), the value in the bottom
          //right will be the LCS of both strings(since it will include LCS up to that last char for both
          //strings). We simply return that value.


        //LCS 0 A G G T A B => string X
        //0   0 0 0 0 0 0 0 <- this is to account for an empty string
        //G   0 0 1 1 1 1 1 <- once we get one match in string, rest will all have 1 match for overall string
        //X   0 0 1 1 1 1 1 <- again no letter match, but the overall string has 1 match, which is 1
        //T   0 0 1 1 2 2 2 <- as you can see another match, so we get a 2 all the way after
        //X   0 0 1 1 2 2 2 <- same thing, once we have 2 matches we keep 2 matches for strs that include it
        //A   0 1 1 1 2 3 3 <- we got another match here, so all matches that include it go up by 1
        //Y   0 1 1 1 2 3 3 <- no match, but the ones that already hae a match keep it
        //B   0 1 1 1 2 3 4 <- another match, same rules, and now on bottom we have 4 wich is overall LCS


        //As you can see from the graph, once a single match is found the rest of the table right or down
        //will have AT LEAST that many matches, as the matrix keeps track of how many common letters there
        //are overall between two string up to that point.Common string incremenets the amount of matches
        //up to it, if no match, we just want to keep the max of left and right since that is how many matches
        //we have up to that point if chars are different.

        public int runLCS(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1]; //initialize the matrix
            for (int i = 0; i <= m; i++) // for loops to build out the matrix as described above
            {
                for (int j = 0; j <= n; j++) // <= here because we have 0, 0 in the matrix for empty strings as described above.
                {
                    if (i == 0 || j == 0) //this basically sets up the 1st row in the table above for empty strings
                    {
                        L[i, j] = 0;
                    }
                    else if (X[i - 1] == Y[j - 1]) //characters match
                    {
                        L[i, j] = L[i - 1, j - 1] + 1; // we go diagnoal up i nthe table and increase by 1
                    }
                    else 
                    {
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]); // we take the highest of left and right
                    }
                }
            }

            return L[m, n]; //return the bottom right, which is m (length of string X), n (length of string Y).
            //This is alawys the LCS because of the structure of the matrix and the fact that this takes into
            //account every character in both strings.
        }

    }
}
