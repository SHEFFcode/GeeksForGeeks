using System;
using GeeksForGeeks.DataStructures;

namespace GeeksForGeeks
{
    public class GraphDFS
    {
        Graph g = new Graph(4);

        public GraphDFS()
        {
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(1, 2);
			g.AddEdge(2, 0);
			g.AddEdge(2, 3);
			g.AddEdge(3, 3);
        }

        //Function to do DFS traversal. It uses recursive DFSUtil().
        public void DFS(int v)
        {
            //Mark all verticies as not visited (set as false by default)
            var visited = new bool[g.V];

            //Call the recursive helper function to print DFS traversal
            DFSUtil(v, visited);
        }

        //A function used by DFS
        private void DFSUtil(int v, bool[] visited)
        {
            //Mark current node as visited and print it
            visited[v] = true;
            Console.WriteLine(v + " ");

        }
    }
}
