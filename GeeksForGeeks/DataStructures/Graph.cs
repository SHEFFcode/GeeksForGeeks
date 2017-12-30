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
            adj[w].AddLast(v); //since the graph is undirected
        }

        public void RemoveEdge(int v, int w)
        {
            adj[v].Remove(w);
            adj[w].Remove(v); // since graph is undirected
        }
    }

    class GraphMatrix
    {
        public int V; // number of vertices
        public int[,] graphContainer; // Adjacency Matrix

        public GraphMatrix(int v) {
            V = v;
            graphContainer = new int[v, v];
        }

        public void AddEdge(int v, int w)
        {
            graphContainer[v, w] = 1;
            graphContainer[w, v] = 1; // since graph is undirected
        }

        public void RemoveEdge(int v, int w)
        {
            graphContainer[v, w] = 0;
            graphContainer[w, v] = 0; // since graph is undirected
        }
    }
}
