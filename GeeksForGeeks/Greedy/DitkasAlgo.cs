using System;
namespace GeeksForGeeks.Greedy
{
  public class DitkasAlgo
  {
    //Utility function to find the vertex with the minimum distance value from
    //set of values not yet included in the shortest path tree.
    static readonly int vertexCount = 9;

    //Implements ditkas algorithm using adjacency matrix representation of a graph.
    public void Run(int[][] graph, int src_vertex)
    {
      var min_dist = new int[vertexCount]; // the output array, dist[i] will hold shortest path from s to i.

      //sptSet[i] will be true if vertex i is included in the shortest path tree
      //or shortest distance from s to i is finalized.
      bool[] sptSet = new bool[vertexCount];

      //Initialize all distances as infinate and stpSet[] as false
      for (int i = 0; i < vertexCount; i++)
      {
        min_dist[i] = int.MaxValue;
        sptSet[i] = false;
      }

      //distance from source vertex to itself is always 0
      min_dist[src_vertex] = 0;

      //find shortest path for all vertecies
      for (int row = 0; row < vertexCount - 1; row++)
      {
        //Pick the minimum distance vertex from the set of vertecies not yet processed.
        //u is always equal to src in first iteration
        var nextMinDistVertex = MinDistance(min_dist, sptSet);

        // Mark picked vertex as processed
        sptSet[nextMinDistVertex] = true;

        //Update dist value of the adjacent vertecies of the picked vertex.
        for (int columnVertex = 0; columnVertex < vertexCount; columnVertex++)
        {
          //Update dist[v] only if not in sptSet, there is an edge from u to v,
          //and the total weight of path from src to v through u is smaller then 
          //current value of dist[v]
          if (!sptSet[columnVertex] 
                    && graph[nextMinDistVertex][columnVertex] != 0 
                    && min_dist[nextMinDistVertex] != int.MaxValue 
                    && min_dist[nextMinDistVertex] + graph[nextMinDistVertex][columnVertex] < min_dist[columnVertex])
          {
            min_dist[columnVertex] = min_dist[nextMinDistVertex] + graph[nextMinDistVertex][columnVertex];
          }
        }
      }

      PrintSolution(min_dist, vertexCount);

    }

    private int MinDistance(int[] dist, bool[] sptSet)
    {
      //Initialize min value
      var min = int.MaxValue;
      var min_index = -1;

      for (int vertex = 0; vertex < vertexCount; vertex++)
      {
        if (sptSet[vertex] == false && dist[vertex] <= min)
        {
          min = dist[vertex];
          min_index = vertex;
        }
      }
      return min_index;

    }

    //Utility function to print the final solution
    private void PrintSolution(int[] dist, int n)
    {
      Console.WriteLine("Vertex distance from source ");
      for (int i = 0; i < vertexCount; i++)
      {
        Console.WriteLine($"{i} tt {dist[i]}");
      }
    }
  }
}
