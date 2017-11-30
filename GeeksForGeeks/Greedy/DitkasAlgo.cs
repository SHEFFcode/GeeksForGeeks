using System;
namespace GeeksForGeeks.Greedy
{
  public class DitkasAlgo
  {
    //Utility function to find the vertex with the minimum distance value from
    //set of values not yet included in the shortest path tree.
    static readonly int V = 9;

    //Implements ditkas algorithm using adjacency matrix representation of a graph.
    public void Run(int[][] graph, int src)
    {
      var dist = new int[V]; // the output array, dist[i] will hold shortest path from s to i.

      //sptSet[i] will be true if vertex i is included in the shortest path tree
      //or shortest distance from s to i is finalized.
      bool[] sptSet = new bool[V];

      //Initialize all distances as infinate and stpSet[] as false
      for (int i = 0; i < V; i++)
      {
        dist[i] = int.MaxValue;
        sptSet[i] = false;
      }

      //distance from source vertex to itself is always 0
      dist[src] = 0;

      //find shortest path for all vertecies
      for (int count = 0; count < V - 1; count++)
      {
        //Pick the minimum distance vertex from the set of vertecies not yet processed.
        //u is always equal to src in first iteration
        var u = MinDistance(dist, sptSet);

        // Mark picked vertex as processed
        sptSet[u] = true;

        //Update dist value of the adjacent vertecies of the picked vertex.
        for (int v = 0; v < V; v++)
        {
          //Update dist[v] only if not in sptSet, there is an edge from u to v,
          //and the total weight of path from src to v through u is smaller then 
          //current value of dist[v]
          if (!sptSet[v] 
                    && graph[u][v] != 0 
                    && dist[u] != int.MaxValue 
                    && dist[u] + graph[u][v] < dist[v])
          {
            dist[v] = dist[u] + graph[u][v];
          }
        }
      }

      PrintSolution(dist, V);

    }

    private int MinDistance(int[] dist, bool[] sptSet)
    {
      //Initialize min value
      var min = int.MaxValue;
      var min_index = -1;

      for (int v = 0; v < V; v++)
      {
        if (sptSet[v] == false && dist[v] <= min)
        {
          min = dist[v];
          min_index = v;
        }
      }
      return min_index;

    }

    //Utility function to print the final solution
    private void PrintSolution(int[] dist, int n)
    {
      Console.WriteLine("Vertex distance from source ");
      for (int i = 0; i < V; i++)
      {
        Console.WriteLine($"{i} tt {dist[i]}");
      }
    }
  }
}
