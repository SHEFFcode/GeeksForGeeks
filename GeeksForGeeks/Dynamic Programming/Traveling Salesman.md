# Traveling Salesman

## General
* You are given a graph with certain cities and the distances between them. You are asked for a 
  the shortest way to visit each city exactly once and return to the starting city.
* Graph: <img src="http://www.geeksforgeeks.org/wp-content/uploads/Euler12.png" height="250" />

### Naive Solution:
* Consider city 1 as the starting point. 
* Generate all (n-1)! permutations of cities
* Calcuate the cost of each permutation and keep track of the min permutation
* Return permutation with the minimum cost.
* Runtime: O(n!)

### DP Solution
* First we will translate the graph above to a matrix:
```
   1  2  3  4
1  0 10 15 20
2 10  0 35 15
3 15 35  0 30
4 20 25 30  0
```
* We then start recusing down, keeping track of previousely stored results C(S, i) = d(1, i)
```
p1: [1,2] => i = 2 => d(1, 2) = 10
    [1,3] => i = 3 => d(1, 3) = 15
    [1,4] => i = 4 => d(1, 4) = 20
```
* We then move on to where the set length is more then 2 and use C(S, i) = C(S - 1, j) + d(i, j)
```
p2: [1, 2, 3] => i = 2, j = 3 => C(1, 3) + d(2, 3)
    [1, 2, 3] => i = 3, j = 2 => C(1, 2) + d(3, 2)
    [1, 2, 4] => i = 2, j = 4 => C(1, 4) + d(2, 4)
    [1, 2, 4] => i = 4, j = 2 => C(1, 2) + d(4, 2)
    [1, 3, 4] => i = 3, j = 4 => C(1, 4) + d(3, 4)
    [1, 3, 4] => i = 4, j = 3 => C(1, 3) + d(4, 3)
```
* We we continue expanding the set
```
p3 : [1, 2, 3, 4] => i = 2, j = 3 => C([1, *4*], 3) + d(2, 3) => here C(1, 3) is known already
     [1, 2, 3, 4] => i = 2, j = 4 => C([1, *3*], 4) + d(2, 4) => here C(1, 4) is known already
     [1, 2, 3, 4] => i = 3, j = 2 => C([1, *4*], 2) + d(3, 2) => here C(1, 4) is known already
     [1, 2, 3, 4] => i = 3, j = 4 => C([1, *2*], 4) + d(3, 4) => here C(1, 2) is known already
     [1, 2, 3, 4] => i = 4, j = 3 => C([1, *2*], 3) + d(4, 3) => here C(1, 2) is known already
     [1, 2, 3, 4] => i = 4, j = 2 => C([1, *3*], 2) + d(4, 2) => here C(1, 3) is known already
```
* We then take the min between the distances of likeminded Costs min(C([1, **4**], 3) && C([1, **3**], 4))
  * cost of 4, 3 and cost of 3, 4
  * this number is then assigned to the general cost between those numbers


## Links
* https://www.youtube.com/watch?time_continue=148&v=hvDx7q6vcWM - g4g
* https://www.youtube.com/watch?v=-JjA4BLQyqE - amazon guy