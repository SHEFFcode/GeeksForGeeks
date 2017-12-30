# Linked List
## General
Like arrays, linked lists are linear data structures. Unlike arrays, linked lists are not stored in
a contigious location, the elements are linked using pointers.

<img src="https://www.geeksforgeeks.org/wp-content/uploads/gq/2013/03/Linkedlist.png" height="250" />

### Why Linked Lists
Arrays have the following limitations:
* Size of array is fixed, we must know the upper limit in advance, or deal with creating a new array
  and copying over the values if it gets too big.
  * Generally the amount of memory allocated is the same regardless of utilization
* Inserting a new element into an array is expensive because previousely located elements have to be
  shifted around.
* deletion is also expensive

Linked lists have the following advantages over arrays:
* Dynamic size
* Ease of insertion / deletion

Drawbacks:
* Random access is not allowed.
* Extra memory for the pointer.

### Structure of a linked list
Each list consists of nodes that have a value and a pointer to the next node.

The first node is called the head node. The last node has a pointer pointed to null, indicating the
completion of linked list.

If linked list is empty, and has no data, the data element of the node will be null.