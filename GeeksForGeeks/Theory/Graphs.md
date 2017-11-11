# Graph Theory

## General
A graph is a data structure that consists of the following two components:
* A finite set of vertecies called nodes.
* A finite set of ordered pairs of the form (u, v) called an edge.
  * The pair is ordered because in a directed graph (u, v) is not the same as (v, u)
  * Edges may contain weight, value, cost.

Graphs are used to represent many real life applications of networks. Social networks, road 
networks, data networks etc.

Below is an example of a graph with 5 vertecies:

![Graph](http://www.geeksforgeeks.org/wp-content/uploads/graph_representation12.png, "Graph")

## Representation

There are two common ways to represent graphs:
* Adjacency Matrix
* Adjacency List

### Adjacency Matrix

Adjacency Matrix is a 2D array of size V x V, where V is the number of vertecies in a graph.

If a graph is represented by a matrix ad[,], then ad[i, j] = 1 means there is a vertex from i to j.
If a graph is directed, then ad[i, j] = w, w is the weight of the vertex from i to j.

Below is an example of an adjacency Matrix for the graph above:

![AdjMatrix](http://www.geeksforgeeks.org/wp-content/uploads/adjacency_matrix_representation.png, "Adj Matrix")

Pros:
* Representation is easier to implement and follow
* Removing and edge takes O(1)
* Queries like whether there is an edge from u to v are efficient and can be done O(1)

Cons:
* Consumes more space O(V^2)
* Consumes same amount of space even if the graph is really sparce
* Adding a vertex is a O(V^2) operation.

### Adjacency List

An array of linked lists is used to represent a graph as an adjacency list.
Size of array is equal to number of vertecies

If an array arr[] is used to contain linked lists, then arr[i] will represent a linked list of 
vertecies adjacent to the ith vetex. Weights can be stored in the nodes of linked lists.

Below is a representation of adjacency list graph:

![AdjList](http://www.geeksforgeeks.org/wp-content/uploads/adjacency_list_representation.png, "Adj List")

Pros:
* Saves space O(V + E), but in the worst case still O(V^2)
* Adding a vertex is easier

Cons:
* Queries like whether there is an edge from vertex u to vertex v are not efficient and can be done in O(V)

## Search Direction

There are two common approaches to traversing a graph during search:

* Bredth First Search - traverse the graph one rung removed at a time.
* Depth First Search - traverese as many rungs down until you hit the end of the graph.