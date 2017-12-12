# Fractional Knapsack

## General
Given weights and desirability values for n number of items, put these items into a knapsack 
capable of holding weight W.

In a 0-1 knapsack problem we are not allowed to break up the items. In a fractional knapsack we are
allowed to break up the items into any fraction such that we can fit as much value as we can into
a knapsack.

Brute force solution would just try to go through all possible combinations, but an efficient solution
is a greedy algo that calculates the weight to desirability ratio of each item and tries to put in
as many of the most valuable items as possible.

## Space and Time
* Depends on the sorting function, but if we use mergesort, we can get nlogn + n runtime.

## Example
```
input: [[60, 10], [100, 20], [120, 30]], capacity: 50
pass1: [60/10, 100/20, 120/30] => we calculate the value per unit of weight
pass2: [6, 5, 4] => we would sort, but it's already sorted with max value per weight first
pass3: 10 + 20 = 30 => we get to the max weight we can get of full units, under target weight
pass4: 50 - 30 = 20 => remaining weight
pass5: 20 / 30 = 2/3 => the faction of the last item we can fit
pass6: 60 + 100 + 120 * 2/3 = 60 + 100 + 80 = 240 => max value we can carry in knapsack
```

## Links
* https://www.youtube.com/watch?v=m1p-eWxrt6g - G4G
