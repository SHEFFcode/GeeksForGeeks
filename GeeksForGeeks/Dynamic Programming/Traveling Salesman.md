# Traveling Salesman

## General
* You are given a graph with certain cities and the distances between them. You are asked for a 
  the shortest way to visit each city exactly once and return to the starting city.

### Naive Solution:
* Consider city 1 as the starting point. 
* Generate all (n-1)! permutations of cities
* Calcuate the cost of each permutation and keep track of the min permutation
* Return permutation with the minimum cost.
* Runtime: O(n!)

### DP Solution
* TODO

## Links
* https://www.youtube.com/watch?time_continue=148&v=hvDx7q6vcWM - g4g