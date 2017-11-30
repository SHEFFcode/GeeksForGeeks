# Activity Selection

## General

* Approach: Sort the input by activity end time.  
* Print the first activity.  
* Print all subsiquent activities whose start time is greater then or equal to previous
  activity's end time.

## Time and Space
* Depends on the sorting algo, if nlogn we can achieve nlogn runtime
* Aux Space is O(1) it is an inplace algorithm

## Example
* Input start[10, 20, 12]; end[20, 30, 25];  Find max number of activities one person can attend.
```
i: start[10, 12, 20]; end[20, 25, 30] => Sort by end time
p1: print [10, 20] => we always print the first activity
p2: skip 12, 25 => skip because 12 is < 20 (start less then prev finish)
p3: print 20, 30 => print because 2- == 20 (start >= prev finish)
```

## Links
* https://www.youtube.com/watch?time_continue=260&v=poWB2UCuozA - G4G