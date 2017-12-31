# Queue
## General
Q is a linear data structure that follows FIFO order of operations.  This is similar to a q of 
customers waiting in line for something.

Operations of a q:
* Enqueue: Adds an item
* Dequeue: Removes an item
* Front: Gets item from the front of the queue
* Rear: Gets item from the back of the queue

<img src="https://www.geeksforgeeks.org/wp-content/uploads/gq/2014/02/Queue.png" height="250">

## Applications of a Q
* Used when thing's don't have to be processed right away, but can wait in line until the load on the
system is lighter (say at night).
* Breadth first search will use a q. 
* CPU scheduling
* Async data communication

## Time Complexity
* Enqueue, dequeue, isFull, isEmpty, front and rear are all O(1).

## Links
* https://www.geeksforgeeks.org/queue-set-1introduction-and-array-implementation/ - g4g