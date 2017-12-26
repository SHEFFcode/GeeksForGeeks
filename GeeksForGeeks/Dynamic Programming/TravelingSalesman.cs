using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.DynamicProgramming
{
    public class TravelingSalesman
    {
        public class Index
        {
            private readonly int currentVertex; // [*2*, [1, 3]]
            private readonly HashSet<int> vertexSet;  // [2, **[1, 3]**]

            public Index(int vertex, HashSet<int> vertexSetPassed)
            {
                currentVertex = vertex;
                vertexSet = vertexSetPassed;
            }


            // We have to override equals because this index will be used as a key
            // in our data structure that will contain all the possible
            // indecies. Basically helps prevent duplicates.
            public override bool Equals(object obj)
            {
                if (this == obj) { 
                    return true; 
                } // objects point to same spot in memory

                if (obj == null) // one object is null, or of diff types
                {
                    return false;
                }

                Index indexToBeAdded = (Index)obj; // unbox the object into index type that it is

                if (currentVertex != indexToBeAdded.currentVertex) {
                    return false;  
                } // if vertecies mismatch, they are not equal

                // if vertex set is not null, compare if it equals the new objects vertex set, if it is null,
                // see if hte new objects vertex set is also null.

                if (vertexSet.Count != 0 ? vertexSet.SetEquals(indexToBeAdded.vertexSet) : indexToBeAdded.vertexSet.Count == 0) {
                    return true;
                }

                return false;

            }

            // Get hash code will be used to group items into buckets, and we want
            // to make sure that the logic in the eqlas method corresponds to the
            // logic in the GetHashCode method.  If 2 things are in the same "bucket"
            // equals will be called to confirm equality.
            public override int GetHashCode()
            {

                int result = this.currentVertex;

                //we just general a hashcode here basically, random number 31, * result + some 
                // sort of hash code that vertexset can general for us automatically.
                //result = 31 * result + (this.vertexSet.Count != 0 ? this.vertexSet.GetHashCode() : 0);

                return result;
            }
        }


        public int minCost(int[,] graph) 
        {
            Dictionary<Index, int> minCostDictionary = new Dictionary<Index, int>();
            Dictionary<Index, int> parentNodeDictionary = new Dictionary<Index, int>();

            List<HashSet<int>> allSets = GenerateCombination(graph.GetLength(0) - 1);

            foreach (var singleSet in allSets)
            {
                for (int currentVertex = 1; currentVertex < graph.GetLength(0); currentVertex++)
                {
                    if (singleSet.Contains(currentVertex))
                    {
                        continue;
                    }

                    Index index = new Index(currentVertex, singleSet);
                    int minCostValue = int.MaxValue;
                    int minPreviousIndex = 0;

                    HashSet<int> copySet = new HashSet<int>(singleSet);

                    foreach (var prevVertex in singleSet)
                    {
                        int cost = graph[prevVertex, currentVertex] + GetCost(copySet, prevVertex, minCostDictionary);

                        if (cost < minCostValue)
                        {
                            minCostValue = cost;
                            minPreviousIndex = prevVertex;
                        }
                    }

                    if (singleSet.Count == 0)
                    {
                        minCostValue = graph[0, currentVertex];
                    }

                    minCostDictionary.Add(index, minCostValue);
                    parentNodeDictionary.Add(index, minPreviousIndex);
                }
            }


            HashSet<int> anotherSingleSet = new HashSet<int>();
            for (int i = 1; i < graph.GetLength(0); i++)
            {
                anotherSingleSet.Add(i);
            }

            int min = int.MaxValue;
            int anotherPrevVertex = -1;

            HashSet<int> anotherCopySet = new HashSet<int>(anotherSingleSet);
            foreach (var vertex in anotherSingleSet)
            {
                int cost = graph[vertex, 0] + GetCost(anotherCopySet, vertex, minCostDictionary);
                if (cost < min)
                {
                    min = cost;
                    anotherPrevVertex = vertex;
                }
            }

            parentNodeDictionary.Add(new Index(0, anotherSingleSet), anotherPrevVertex);
            PrintTour(parentNodeDictionary, graph.GetLength(0));

            return min;

        }

        private void PrintTour(Dictionary<Index, int> parentNodeDictionary, int totalVertecies)
        {
            HashSet<int> singleSet = new HashSet<int>();
            for (int i = 0; i < totalVertecies; i++)
            {
                singleSet.Add(i);
            }

            int start = 0;
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                stack.Push(start);
                singleSet.Remove(start);

                var key = new Index(start, singleSet);

                if (parentNodeDictionary.ContainsKey(key))
                {
                    start = parentNodeDictionary[key];
                }
                else
                {
                    break;
                }
            }

            StringBuilder output = new StringBuilder();

            foreach (var item in stack)
            {
                output.Append(item + "->");
            }

            Console.WriteLine(output);

        }


        private int GetCost(HashSet<int> copySet, int prevVertex, Dictionary<Index, int> minCostDictionary)
        {
            copySet.Remove(prevVertex);

            Index index = new Index(prevVertex, copySet);
            int cost = 0;
            if (minCostDictionary.ContainsKey(index))
            {
                cost = minCostDictionary[index];
            }

            copySet.Add(prevVertex);
            return cost;
        }

        public List<HashSet<int>> GenerateCombination(int n)
        {
            int[] input = new int[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i + 1; // we do not want to count vertex 0 in our combinations
            }

            List <HashSet<int>> allSets = new List <HashSet<int>>();

            int[] result = new int[input.Length];

            GenerateCombination(input, 0, 0, allSets, result);

            allSets.Sort((x, y) => x.Count - y.Count);

            return allSets;

        }

        private void GenerateCombination(int[] input, int start, int pos, List<HashSet<int>> allSets, int[] result)
        {
            if (pos == input.Length)
            {
                return;
            }

            HashSet<int> set = CreateSet(result, pos);

            allSets.Add(set);

            for (int i = start; i < input.Length; i++)
            {
                result[pos] = input[i];
                GenerateCombination(input, i + 1, pos + 1, allSets, result);
            }
        }

        private HashSet<int> CreateSet(int[] result, int pos)
        {
            // this is for [1, null], [2, null] etc
            if (pos == 0)
            {
                return new HashSet<int>();
            }

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < pos; i++)
            {
                set.Add(result[i]);
            }

            return set;
        }

    }
}
