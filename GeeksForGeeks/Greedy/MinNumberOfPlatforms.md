# Minimum Number of Platforms

## Basics

* Given arrival and departure times of all trains that reach the railway station, find the minimum
  number of platforms required for the railway station so that no train waits. We are given two
  arrays which represent arrival and departure times of trains that stop.
* The idea is just sort the two given arrays and iterate over each and keep track of the peak # of 
  platforms needed.

## Example
```
input: arr [9:00,  9:40,  9:50, 11:00, 15:00, 18:00]
       dep [9:10, 12:00, 11:20, 11:30, 19:00, 20:00]

sorted: arr [9:00,  9:40,  9:50, 11:00, 15:00, 18:00]
        dep [9:10, 11:20, 11:30, 12:00, 19:00, 20:00]

Time  | Event Type  | # of Platroms |
 9:00   arr           1             | => arr[0] :  9:00 < dep[0] : 9:10
 9:10   dep           0             | => dep[0] :  9:10 < arr[1] : 9:40
 9:40   arr           1             | => arr[1] :  9:40 < dep[1] : 12:00
 9:50   arr           2             | => arr[2] :  9:50 < dep[1] : 12:00
11:00   arr           3             | => arr[3] : 11:00 < dep[1] : 12:00
11:20   dep           2             | => dep[1] : 11:20 < arr[4] : 15:00 
11:30   dep           1             | => dep[2] : 11:30 < arr[4] : 15:00
12:00   dep           0             | => dep[3] : 12:00 < arr[4] : 15:00
15:00   arr           1             | => arr[4] : 15:00 < dep[4] : 19:00
18:00   arr           2             | => arr[5] : 18:00 < dep[4] : 19:00
19:00   dep           1             | => dep[5] : 19:00, no arrivals left, could be optimized
20:00   dep           0             | => dep[5] : 20:00, no arrivals left, could be optimized
```

## Links
* http://www.geeksforgeeks.org/minimum-number-platforms-required-railwaybus-station/ - g4g