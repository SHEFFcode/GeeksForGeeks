# Graph
## General
Graph is a data structure that consists of the following two components:
* Finite set of vertices also called nodes
* Finite set of ordered pairs in the form of (u, v) called an edge.

A graph can be directed (di-graph) or undirected. In a directed graph (u,v) is not the same as 
(v,u). 

Graphs are used to represent networks, which can be both social networks and road networks.

There are two common representations of a graph:
* Adjacency Matrix
* Adjacency List

### Adjacency Matrix
Adj Matrix is a 2d array of size VxV where V is the number of vertecis. Adj Matrix for an undirected
graph are always symmetric.
<img src="https://www.geeksforgeeks.org/wp-content/uploads/adjacency_matrix_representation.png" height="250" />


Pros:
* Representation is easier to implement and follow
* Removing an edge takes O(1) time
* Queries can be done in O(1) time


Cons:
* Consumes more space O(V^2) even if the graph is sparse
* Adding a vertex is O(V^2) time

**Note:** If the diagonal on a graph is all zeroes, the graph does not contain a self loop.

### Adjacency List
Adj List is an array of linked lists. Size of array is equal to the number of vertices. 
<img src="https://www.geeksforgeeks.org/wp-content/uploads/adjacency_list_representation.png" height="250" />

Pros:
* Saves Space O(V + E), at worst can lead to O(V^2) space, but is usually lower for sparse graphs

Cons:
* Queries can only be done in O(V) time.