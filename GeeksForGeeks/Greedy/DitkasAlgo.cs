using System;
namespace GeeksForGeeks.Greedy
{
    public class DitkasAlgo
    {
		// Single source shortest path
		// Works in directed or undirected, but only with non negative weights
		// Runtime complexity is O(Elog(v)), with E being edges, and v is vertecies
		//               3
		//          s ----- c
		//        7/ \2      \
		//          3         \ 2
		//        a - b       l
		//        4\ /4     4/ \4
		//          d       i - j 6
		//        5/ \1     4\ /4
		//        f - h       k
		//          3  \2    / 5
		//              g - e
		//                2

		//      v | d       | p (vertex, distance, parent)
		// p1:  S | 0       | s     => initial state, first vertex is always 0 away from iteself
		// p2:  A | i, 7, 5 | s, b  => as we go to A, the path is 7 through vertex s, but 5 through b
		// p3:  B | i, 2    | s     => path is 2 to get to b
		// p4:  C | i, 3    | s     => path is 3 to get to c
		// p5:  D | i, 6    | s, b  => path is 3 to get to d through b

        //This continues through the graph, I don't have the patience to get through all of it.

        // Links:
		// https://www.youtube.com/watch?v=GazC3A4OQTE - computerphile
		// https://www.youtube.com/watch?v=U9Raj6rAqqs - Joe James
		// https://www.youtube.com/watch?v=qx9sJ3O3JM0 - bootstrappers

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
                    if (!sptSet[v] && graph[u][v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u][v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u][v];
                    }
                }
            }

            PrintSolution(dist, V);

        }

        //Utility function to find the vertex with the minimum distance value from
        //set of values not yet included in the shortest path tree.
        static readonly int V = 9;

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
