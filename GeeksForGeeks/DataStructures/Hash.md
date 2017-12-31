# Hash
## General
Hashing is used when we have a large number of items which we want to find the value of very quickly,
but for which some sort of key, rather then a pot in the array is known.

For example we have a list of phone numbers, and we want to associate them with a person's name. We
know the phone number, but we do not know it's spot in the container.  We can search the phone number
container for the phone number, and then find the person at the same spot in the persons container,
but that is not very fast, logn time at best.

Even with a balanced binary search tree the best runtime for search we can get is logn.

A way we can think of imroving our results is to use a direct access table, where we make a big 
array where the spot in memory is the phone number, and the item is the person's name. But that is 
not very space efficient, but it will give us an O(1) runtime for insertion, search and deletion.

A hash will take the phone number (or some other value) and run it through a hashing function to get
a smaller number, and use that smaller number as the index of the entry in the hash table.  The key
is that the same value should **always** hash to the same index in the table.

A good hashing funciton is:
* Efficiently computable
* Distributes the keys uniformly

## Runtime
With hashing we get:
* O(1) runtime under average Conditions.
* O(n) worst case.

## Collision Handling
* Chaining: Each cell in a hash table points to a linked list of records that hashed to the same value.
* Open addressing: All elements are stored in the hash table, each table contains either a record
  or a null. Examine the table cells one by one until it is found or is clear the element is not there.
  * Linear Porbing - easty to implement, best cache performance, suffers from clustering
  * Quadratic Probing - average cahe performance, suffers less from clustering
  * Double Hashing - Poor Cache Performance, no clustering, requires more computer time.

## Links
* https://www.geeksforgeeks.org/hashing-set-1-introduction/ - hashing G4g
* https://www.geeksforgeeks.org/hashing-set-3-open-addressing/ - open address G4g

