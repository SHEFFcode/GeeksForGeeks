# Longest Common Subsequence

## Theory
Longest common subsequence wants to find out the length and order of the longest common subsequence
given two strings.  The brute force recursive solution would have us calculate the longest subsequence
of each string from their full length, breaking it down into further problems by decrementing the
string down and down until we reach a single letter and can do the comparison, then returning up
the chain.

The solution can be seen as the following graph:

                        lcs("AXYT", "AYZX")
                       /                 \
         lcs("AXY", "AYZX")              lcs("AXYT", "AYZ")
         /             \                 /               \     
lcs("AX", "AYZX") lcs("AXY", "AYZ")   lcs("AXY", "AYZ") lcs("AXYT", "AY")

We can see that the lcs("AXY", "AYZ") gets computed twice, just in this limited recursion.

This means we have two conditions ripe for dynamic programming:
  a) Optimal substrucutre, as the result of the individual solution is the best overall result.
  b) Repeating subproblems, as we can see that subproblems are repeating from the diagram above.

## Dynamic Programming Approach
Instead of thinking of this problem in terms of strings, we can think of it in terms of a matrix,
where we have one string going across the top and one string going top down.  This matrix will
actually be one longer then the lenght of the string because we need to account for an empty string.
Luckily in the case of empty string, LCS will be 0, as nothing cannot match with anything, including
itself, so we fill those rows with zeroes.

We then move on filling in the matrix in the following manner:
  * If letters match, we will take the diagonal value, which represents the LCS up to the current char
  in both strings, and increment it by 1 since we found a match.
  * If the letters do not match, we simply need to keep count of LCS so far for that string, so we 
  tke the max of the value to the left (LCS up to before this char in the top string) and value
  to the top (LCS up to before this char in the left string).
  * Finally when we conclude building up the matrix (bottom up approach), the value in the bottom
  right will be the LCS of both strings (since it will include LCS up to that last char for both
  strings). We simply return that value.

See the graph:

![LCS Graph](http://www.geeksforgeeks.org/wp-content/uploads/Longest-Common-Subsequence.png "LCS Graph")