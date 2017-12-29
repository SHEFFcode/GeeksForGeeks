using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.DynamicProgramming
{
    public class TravelingSalesman
    {
        public struct Index
        {
            public int currentVertex; // [*2*, [1, 3]]
            public HashSet<int> vertexSet;  // [2, **[1, 3]**]

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
                result = 31 * result + (this.vertexSet.Count != 0 ? this.vertexSet.Count * 13 / 5 : 0);

                return result;
            }
        }


        /// <summary>
        /// Main Driver function for sorting the traveling salesman solution.
        /// </summary>
        /// <returns>Traveling salesman solution</returns>
        /// <param name="graph">Graph.</param>
        public int minCost(int[,] graph) 
        {
            
            Dictionary<Index, int> minCostDictionary = new Dictionary<Index, int>(); // Dictionary that contains min cost path for each index.
            Dictionary<Index, int> parentNodeDictionary = new Dictionary<Index, int>(); // Dictionary that contains parent node for each index.

            List<HashSet<int>> allSets = GenerateCombination(graph.GetLength(0) - 1); // This will contain all the hash sets posisble for this graph size.

            foreach (var singleSet in allSets) // so this would be for each [], [1], [1,2], [1,3], [2], [2,3], [3]
            {
                for (int currentVertex = 1; currentVertex < graph.GetLength(0); currentVertex++) // we do not care about the 0 vertex at this stage.
                {
                    if (singleSet.Contains(currentVertex)) // in other words say we are on vertex 1 and we get set [1,3]
                    {
                        continue; // we continue, cause u can't got from 1 to 1, or it really does not make any sense to calculate that.
                    }

                    // Set up the index struct for current vertex and set
                    Index index = new Index(currentVertex, singleSet);
                    int minCostValue = int.MaxValue; // initial cost will be max
                    int minPreviousIndex = 0; // initial previous vertex index will be 0

                    HashSet<int> copySet = new HashSet<int>(singleSet); //make a copy of the set to get around any modification errors.

                    foreach (var prevVertex in singleSet) // iterate over the vertecies in the set, picking one to be the previous vertex, rest will be the key for the dict
                    {
                        //  Cost =        distance(x, y)            +              Cost(y, [x, z, k])
                        int cost = graph[prevVertex, currentVertex] + GetCost(copySet, prevVertex, minCostDictionary); // this just comes from the min cost dictionary

                        if (cost < minCostValue) // if the cost here is less then the min cost value, we want to update the min cost values
                        {
                            minCostValue = cost;  // we update the cost
                            minPreviousIndex = prevVertex; // we update the prev vertex
                        }
                    }

                    if (singleSet.Count == 0)
                    {
                        minCostValue = graph[0, currentVertex]; //graph[prevVertex, currentVertex] above, but with prev vertex being 0
                    }

                    minCostDictionary.Add(index, minCostValue); // after we have gone through each vertex in the set, we add the values for min cost and min parent
                    parentNodeDictionary.Add(index, minPreviousIndex); // to the respective dictionaries for retrieval later
                }
            }


            /* =============================================================================================================================    
             *                                       This updates the paths with values back to vertex 0
             ==============================================================================================================================*/
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

            Console.WriteLine($"Traveling salesman distance is {min}");

            return min;

        }

        /// <summary>
        /// Function to print out the traveling salesman path.
        /// </summary>
        /// <param name="parentNodeDictionary">Parent node dictionary.</param>
        /// <param name="totalVertecies">Total vertecies.</param>
        private void PrintTour(Dictionary<Index, int> parentNodeDictionary, int totalVertecies)
        {
            HashSet<int> singleSet = new HashSet<int>();
            for (int i = 0; i < totalVertecies; i++)
            {
                singleSet.Add(i);
            }

            int start = 0; // just a starting value, we know we will start at 0 in my setup, but this can be dynamic too
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                stack.Push(start); // we push the vertecies on the stack,
                singleSet.Remove(start); // but remove from the set

                var key = new Index(start, singleSet); // create a key to check against the dictionary

                if (parentNodeDictionary.ContainsKey(key)) // check the dictionary
                {
                    start = parentNodeDictionary[key]; // update the start based on the value of the key
                }
                else
                {
                    break;
                }
            }

            StringBuilder output = new StringBuilder(); // we use stringbuilder for easier modification as opposed to string.

            foreach (var item in stack)
            {
                output.Append(item + "->"); 
            }

            Console.WriteLine(output.Remove(output.Length - 2, 2)); //logic to not append that last arrow.

        }


        /// <summary>
        /// Calculates the cost of the twip based off previousely known values
        /// </summary>
        /// <returns>The cost.</returns>
        /// <param name="copySet">Copy set.</param>
        /// <param name="prevVertex">Previous vertex.</param>
        /// <param name="minCostDictionary">Minimum cost dictionary.</param>
        private int GetCost(HashSet<int> copySet, int prevVertex, Dictionary<Index, int> minCostDictionary)
        {
            copySet.Remove(prevVertex); // we take out the preceding vertex, as we don't wanna use it for retrieving the cost from the dictionary

            Index index = new Index(prevVertex, copySet); // we create the index key to check the dictionary against
            int cost = 0; // set up initial cost
            if (minCostDictionary.ContainsKey(index)) // check the dictionary
            {
                cost = minCostDictionary[index]; // retrieve the key
            }

            copySet.Add(prevVertex); // add back the index we took out earlier just in case.
            return cost; // return the cost
        }

        /// <summary>
        /// Initial overloadded function to generate set combinations based on size of graph
        /// </summary>
        /// <returns>The combination.</returns>
        /// <param name="n">Size of graph</param>
        public List<HashSet<int>> GenerateCombination(int n)
        {
            int[] input = new int[n];
            int[] result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i + 1; // we do not want to count vertex 0 in our combinations
            }

            List<HashSet<int>> allSets = new List<HashSet<int>>();

            GenerateCombination(input, 0, 0, allSets, result); // start and position start off being 0

            allSets.Sort((x, y) => x.Count - y.Count);

            return allSets;

        }

        /// <summary>
        /// Recursive function that seeks to create all possible sets for a given graph size
        /// </summary>
        /// <param name="input">Input.</param>
        /// <param name="start">Start.</param>
        /// <param name="pos">Position.</param>
        /// <param name="allSets">All sets.</param>
        /// <param name="result">Result.</param>
        private void GenerateCombination(int[] input, int start, int pos, List<HashSet<int>> allSets, int[] result)
        {
            if (pos == input.Length) // we've reached the end of the list we are trying to make
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

        /// <summary>
        /// Creates the actual hash set for this position
        /// </summary>
        /// <returns>The set.</returns>
        /// <param name="result">Result.</param>
        /// <param name="pos">Position.</param>
        private HashSet<int> CreateSet(int[] result, int pos)
        {
            // this is for [1, null], [2, null] etc
            // where it will return a single empty set for all three
            // so the sets we will get out of this in order are:
            // 1. []
            // 2. [1]
            // 3. [1, 2]
            // 4. [1, 3]
            // 5. [2]
            // 6. [2, 3]
            // 7. [3]
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
