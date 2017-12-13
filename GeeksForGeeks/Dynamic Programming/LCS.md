# Longest Common Subsequence

## General

Longest common subsequence has us find the length longest common subsequnce between two sequences.
Subsequence appears in the same relative order, but not necessarily contiguous.

# Example

Input: "AGGTAB" & "GXTXAYB"

We will begin by filling in the matrix in the following manner:
* If letters match, we will take the diagonal value, which represents the LCS up to the current char
  in both strings, and increment it by 1 since we found a match.
* If the letters do not match, we simply need to keep count of LCS so far for that string, so we
  the the max of the value to the left(LCS up to before this char in the top string) and value
  to the top(LCS up to before this char in the left string).
* Finally when we conclude building up the matrix(bottom up approach), the value in the bottom
  right will be the LCS of both strings(since it will include LCS up to that last char for both
  strings). We simply return that value.

```
LCS 0 A G G T A B => string X
0   0 0 0 0 0 0 0 <- this is to account for an empty string
G   0 0 1 1 1 1 1 <- once we get one match in string, rest will all have 1 match for overall string
X   0 0 1 1 1 1 1 <- again no letter match, but the overall string has 1 match, which is 1
T   0 0 1 1 2 2 2 <- as you can see another match, so we get a 2 all the way after
X   0 0 1 1 2 2 2 <- same thing, once we have 2 matches we keep 2 matches for strs that include it
A   0 1 1 1 2 3 3 <- we got another match here, so all matches that include it go up by 1
Y   0 1 1 1 2 3 3 <- no match, but the ones that already hae a match keep it
B   0 1 1 1 2 3 4 <- another match, same rules, and now on bottom we have 4 wich is overall LCS
```

* As you can see from the graph, once a single match is found the rest of the table right or down
  will have AT LEAST that many matches, as the matrix keeps track of how many common letters there
  are overall between two string up to that point.Common string incremenets the amount of matches
  up to it, if no match, we just want to keep the max of left and right since that is how many matches
  we have up to that point if chars are different.

## Links
* https://www.youtube.com/watch?v=HgUOWB0StNE - g4g