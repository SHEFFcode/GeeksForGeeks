# Longest Increasing Subsequence

## General
Longest Increasing subsequence is a typical problem that can be solved using dynamic programming.
It has an optimal substructure and repeating subproblems.

## Example
The problem is solved in the follwing recursive manner:
```
                  lis(4)
                  /     \
              list(3)   lis(2) lis(1)
              /  \        /
         lis(2) lis(1)  lis(1)
          /
        lis(1)
```

You can see here that lis(1) is solved three times, and solution to below subproblems produce the correct solution for the problem as a whole.
```
_________________________________________________
|itterator|  j |  i |    |    |    |    |    |    |
|input[]  | 10 | 22 | 09 | 33 | 21 | 50 | 41 | 60 |
|LIS[]    |  1 |1,2 |  1 |  1 | 1  |  1 |  1 | 1  |
 -------------------------------------------------
Loop from j == 0 to j == i
if (input[i] > input [j] we have an increasing subsequence, and LIS[i] becomes LIS[j] + 1, provided it's bigger then LIS[i].
Note: when i == 0  LIS[i] is already 1, because each individual number is an increasing subsequence, so we start with i == 1.
on the first pass we see that 22 > 10, so LIS[1] becaomes LIS[0] + 1 = 1 + 1 = 2.
once j == i we reset j to 0 and move it to the right and repeat the process.
if LIS[j] < LIS[i] keep moving j to the right till u hit i.
```

## Runtime Complexity
* Runtime Complexity O(m * n)
* Runtie of the recursive solution is O(2^n) which is a really bad runtime

## Links
* https://www.youtube.com/watch?v=Ns4LCeeOFS4 - g4g