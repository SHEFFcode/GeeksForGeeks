# Stack
## General
Stack is a linear data structure which follows a LIFO method when operations are performed.
The following are the most common operations performed with a stack:
* Push: Adds an item to a stack. If full causes stack overflow exception to be thrown.
* Pop: Removes an item from a stack. Items are popped in the reverse order from the one they came in.
* Peek: Returns the top element in the stack
* isEmpty: Returns bool as to whether there is any data in the stack.

<img src="https://www.geeksforgeeks.org/wp-content/uploads/gq/2013/03/stack.png" height="250">

Stack is sort of like a pringles can. And operates in much the same way.

Stack is used for browser navigation functionality, or undo. Also used for function execution. 
Stack vs Heap

## Time complexity:
* push, pop isEmpty and peak are all O(1) operations

## Applications:
* Balancing of symbols
* Undo / redo
* Forward / backward in the browser

## Implementations:
* Using an array
  * Pros:
    * Easy to implement
    * Memory is saved because we don't need pointers
  * Cons:
    * Not dynamic, does not grow and shrink at runtime
* Using a linked list
  * Pros:
    * Dynamic, can grow and shrink in size at runtime
  * Cons:
    * Requires a bit more memory for the pointer.

