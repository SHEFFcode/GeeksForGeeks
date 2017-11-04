# Longest Common Subsequence

## Theory
Longest common subsequence wants to find out the length and order of the longest common subsequence
given two strings.  The brute force recursive solution would have us calculate the longest subsequence
of each string from their full length, breaking it down into further problems by decrementing the
string down and down until we reach a single letter and can do the comparison, then returning up
the chain.

The solution can be seen as the following graph:
```
                        lcs("AXYT", "AYZX")
                       /                 \
         lcs("AXY", "AYZX")              lcs("AXYT", "AYZ")
         /             \                 /               \     
 lcs("AX", "AYZX") lcs("AXY", "AYZ")   lcs("AXY", "AYZ") lcs("AXYT", "AY")
 ```

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

## The Graph
```
LCS 0 A G G T A B
0   0 0 0 0 0 0 0 <- this is to account for an empty string
G   0 0 1 1 1 1 1 <- once we get one match in string, rest will all have 1 match for overall string
X   0 0 1 1 1 1 1 <- again no letter match, but the overall string has 1 match, which is 1
T   0 0 1 1 2 2 2 <- as you can see another match, so we get a 2 all the way after
X   0 0 1 1 2 2 2 <- same thing, once we have 2 matches we keep 2 matches for strs that include it
A   0 1 1 1 2 3 3 <- we got another match here, so all matches that include it go up by 1
Y   0 1 1 1 2 3 3 <- no match, but the ones that already hae a match keep it
B   0 1 1 1 2 3 4 <- another match, same rules, and now on bottom we have 4 wich is overall LCS
```

As you can see from the graph, once a single match is found the rest of the table right or down
will have AT LEAST that many matches, as the matrix keeps track of how many common letters there
are overall between two string up to that point.  Common string incremenets the amount of matches
up to it, if no match, we just want to keep the max of left and right since that is how many matches
we have up to that point if chars are different.