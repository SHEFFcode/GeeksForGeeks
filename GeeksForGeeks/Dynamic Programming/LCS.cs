using System;
namespace GeeksForGeeks.DynamicProgramming
{
    public class LCS
    {
        public LCS()
        {
        }

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
