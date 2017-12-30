# Caching

## General
Caching is used to speed up operations that require information retrieval that is costly:
* Going out to the server over the network for browser cache
* Doing a DB query for DB cache
* Making a trip down the motherboard to the RAM module for CPU cache

In those scenarios we want to cache things on sume super fast medium, and do it usually in such a 
way that the least recently used item gets overriden in the cahe when more space needs to be made.

This is a common scenario as space in the cache is usually very expensive and therefore very limited.

## Implementation
Generally it works in the following way. We first set up the cache:

```
Item | LRU
     | 0
     | 1
     | 2
     | 3
```
We then cache any new incoming item into the 0th spot.

```
Item | LRU
  A  | 0
     | 1
     | 2
     | 3
```
As we insert an item, we update it's LRU number, with 0 being the least recently used. We also
decrement all the other counters down towards 0.
```
Item | LRU
  A  | 3
     | 0
     | 1
     | 2
```
We keep repeating the process while we fill up the cache.
```
Item | LRU
  A  | 2
  B  | 3
     | 0
     | 1
```
Item | LRU
  A  | 1
  B  | 2
  C  | 3
     | 0
```
Item | LRU
  A  | 0
  B  | 1
  C  | 2
  D  | 3
```
We now don't have any empty spots in memory, but no matter, our least recently used item is A and
it has the appropriate LRU of 0. So we can keep adding E in into the 0th spot.
```
Item | LRU
  E  | 3
  B  | 0
  C  | 1
  D  | 2
```
Now say we access B again. We will turn B into 3, and follow our standard procedure with the other
counters.
```
Item | LRU
  E  | 2
  B  | 3
  C  | 0
  D  | 1
```
If B gets accessed again, no problem, its counter will remain as is. No other changes.

Now say D is accessed again, this is a bit trickier.  D's counter is now 3, but we don't lower all
the other counters a notch down, we take the ones above the value of the counter, and do a notch down,
but the ones below D stay the same.
```
Item | LRU
  E  | 1
  B  | 2
  C  | 0
  D  | 3
```
This process is pretty memory intensive nlogn to store the counters, and we need to update n counters 
on every change.

## Links
https://www.youtube.com/watch?v=bq6N7Ym81iI - Udacity