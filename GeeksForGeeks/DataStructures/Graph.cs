using System;
using System.Collections.Generic;

namespace GeeksForGeeks.DataStructures
{
    public class Graph
    {
        //This class represents a directed graph using adjacency list representation.
        public int V; //Number of vertecies
        public LinkedList<int>[] adj; //Adjacency lists.

        public Graph(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        //Function to add an edge into a graph
        public void AddEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }
    }
}
