using System;
namespace GeeksForGeeks.Search
{
    public class InterpolationSearch
    {
        public int Run(int[] A, int e)
        {
            int start, end, pos;

            start = 0;
            end = A.Length - 1;

            while(start <= end && e >= A[start] && e <= A[end]) // here we want to make sure not to keep looking if e is smaller then start or bigger then end
            {
                pos = start + start + ((end - start) / (A[end] - A[start]) * (e - A[start])); //use the interpolation furmula here to guess the position

                if (A[pos] == e) {
                    return pos;
                }
                else if (e > A[pos])
                {
                    start = pos + 1;
                }
                else 
                {
                    end = pos - 1;
                }
            }

            return -1; // if we don't find the value we return -1
        }
	}
}
