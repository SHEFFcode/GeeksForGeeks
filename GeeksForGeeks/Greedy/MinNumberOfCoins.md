# Minimum Number of Coins

## General
* Given a certain amount of change that we have to give back to a customer, find the lowest #
of items of currence we can use to give the exact change.
* The idea is to start with the largest denominated currency item that is not larger then the 
amount of change we are trying to give, and work back in smaller items till we are done giving 
change.
* When the amount of change left to give reaches 0, we print out the result.

## Example

```
input: [1, 2, 5, 10, 20, 50, 100] => currency array, give change for 121
p1:    [1, 2, 5, 10, 20, 50, *100*] => start with largest denomination, or use binary search to find
                                       largest currency below the amount of change we are giving
                                       121 - 100 = 21, still left to give out
                                       Check if we have the exact remained in arr, if not and 
                                       left to give is not 0, we look for the next largest bill
p2:    [1, 2, 5, 10, *20*, 50, 100] => traverse or binary search to find next item 21 - 20 = 1
                                       check if we have that denomination to hand out, we do so
                                       we hand out 1, and reach 0 left to give. We end and print 
                                       result.
```

## Links
* http://www.geeksforgeeks.org/greedy-algorithm-to-find-minimum-number-of-coins/ - g4g
* https://www.youtube.com/watch?time_continue=265&v=KTaEeTWRwgg - g4g