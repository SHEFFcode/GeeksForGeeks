using System;
using System.Collections.Generic;
using GeeksForGeeks.DataStructures;

namespace GeeksForGeeks
{
    public class BFSGraph
    {
        //C# Program to print BFS traversal from a given source vertex.
        //BFS(int s) traverses all verticies reachable from s.

        Graph g = new Graph(4); 

        public BFSGraph()
        {
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 2);
			g.AddEdge(2, 0);
			g.AddEdge(2, 3);
			g.AddEdge(3, 3);
        }

        //Prints BFS traversal from a given source s.
        public void BFS(int s)
        {
            //mark all verticies as visited (C# auto instanciates as false)
            bool[] visited = new bool[g.V];

            //Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            //Mark current node as visited and enqueue it
            visited[s] = true;
            queue.AddLast(s);

            //Traverse all the nodes we have in the graph.
            while (queue.Count > 0)
            {
                //Get value, dequeue a vertex and print it
                s = queue.First.Value;
                queue.RemoveFirst();
                Console.WriteLine(s + " ");

                var CurrentNodePath = g.adj[s];
                var lenght = CurrentNodePath.Count;
                var currentNode = CurrentNodePath.First;

                while (lenght > 0)
                {
                    
                    var n = currentNode.Value;
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.AddLast(n);
                    }
                    currentNode = currentNode.Next;
                    lenght--;
                }

            }
        }
    }
}
