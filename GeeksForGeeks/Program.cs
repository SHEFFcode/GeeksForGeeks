using System;
using GeeksForGeeks.DataStructures;
using GeeksForGeeks.DynamicProgramming;
using GeeksForGeeks.Greedy;
using GeeksForGeeks.Sorting;

namespace GeeksForGeeks
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //var travelingSalesman = new TravelingSalesman();
            //travelingSalesman.minCost(new int[,] {
            //    {  0, 1, 15,  6 },
            //    {  2, 0,  7,  3 },
            //    {  9, 6,  0, 12 },
            //    { 10, 4,  8,  0 }
            //});

            //var fractionalKnapsack = new FractionalKnapsack();
            //fractionalKnapsack.Run(50, new int[,] { { 60, 10 }, { 100, 20 }, { 120, 30 } }, 3);




            //var mergeSort = new MergeSort();
            //var arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            //mergeSort.Run(arr, 0, arr.Length - 1);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //var minNumberOfCoins = new Greedy.MinNumberOfCoins();
            //minNumberOfCoins.Run(new int[] { 1, 2, 5, 10, 20, 50, 100 }, 121);

            //var minNumberOfPlatforms = new MinNumPlatforms();
            //var result = minNumberOfPlatforms.Run(new float[] { 9.00f, 9.40f, 9.50f, 11.00f, 15.00f, 18.00f }, new float[] { 9.10f, 12.00f, 11.20f, 11.30f, 19.00f, 20.00f });
            //Console.WriteLine($"Min number of platforms needed is {result}.");

            //var selectionSort = new SelectionSort();
            //selectionSort.Run(new int[] { 23, 42, 4, 16, 8, 15 });

            //var stableSelectionSort = new StableSelectionSort();
            //stableSelectionSort.Run(new int[] { 4, 5, 3, 2, 4, 1 });

            //var swap = new Swap();
            //swap.Run(5, 10);

            //var selectionSort = new SelectionSort();
            //selectionSort.Run(new int[] {64, 25, 12, 22, 11});

            //var insertionSort = new InsertionSort();
            //insertionSort.Run(new int[]{ 23, 42, 4, 16, 8, 15 });

            //var binarySearch = new BinarySearch();
            //binarySearch.RunRecursive(new int[] { 0, 2, 3, 4, 10, 40, 44 }, 2, 0, 6);
            //binarySearch.RunIterative(new int[] { 0, 2, 3, 4, 10, 40, 44 }, 2);

            //var quickSort = new Quicksort();
            //var inputArray = new int[] { 7, 2, 1, 6, 8, 5, 3, 4 };
            //quickSort.QuicksortWrapper(inputArray, 0, inputArray.Length - 1);
            //foreach (var item in inputArray)
            //{
            //    Console.WriteLine(item);
            //}

            //var interpolationSearch = new Search.InterpolationSearch();
            //var result = interpolationSearch.Run(new int[] { 1, 2, 4, 6, 7, 10, 11, 14, 15 }, 4);
            //Console.WriteLine(result);




            //var BFSGraph = new BFSGraph();
            //BFSGraph.BFS(2);

            //var activitySelection = new ActivitySelection();
            //activitySelection.Run(new int[] {10, 12, 20}, new int[] {20, 25, 30});

            //var ditka = new DitkasAlgo();
            //ditka.Run(new int[][]{new int[] {0,  4, 0,  0,  0,  0, 0,  8, 0},
            //                      new int[] {4,  0, 8,  0,  0,  0, 0, 11, 0},
            //                      new int[] {0,  8, 0,  7,  0,  4, 0,  0, 2},
            //                      new int[] {0,  0, 7,  0,  9, 14, 0,  0, 0},
            //                      new int[] {0,  0, 0,  9,  0, 10, 0,  0, 0},
            //                      new int[] {0,  0, 4, 14, 10,  0, 2,  0, 0},
            //                      new int[] {0,  0, 0,  0,  0,  2, 0,  1, 6},
            //                      new int[] {8, 11, 0,  0,  0,  0, 1,  0, 7},
            //                      new int[] {0,  0, 2,  0,  0,  0, 6,  7, 0}
            //}, 0);

            //var memoization = new Memoization();
            //Console.WriteLine(memoization.RunRecursive(6));
            //Console.WriteLine(memoization.RunMemoization(6));
            //Console.WriteLine(memoization.RunTabulation(6));


            //var lis = new LIS();
            //Console.WriteLine(lis.runLIS(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 }, 8));

            //var lcs = new LCS();
            //var result = lcs.runLCS(new char[] {'A', 'G', 'G', 'T', 'A', 'B'}, new char[] {'G', 'T', 'X', 'T', 'X', 'A', 'Y', 'B'}, 6, 8);
            //Console.WriteLine(result);


            //var lps = new LPS();
            //var result = lps.RunLPS("BBABCBCAB");
            //Console.WriteLine($"The longest pallindrome subsequence is {result}.");

            //var wwp = new WWP();
            //wwp.RunWWPGreedy("aaa bb cc dddd");

            //var linkedList = new CustomLinkedList();
            //linkedList.AddNode(1);
            //linkedList.AddNode(2);
            //linkedList.AddNode(3);
            //linkedList.TraverseLinkedList();

            //var customStack = new CustomStack<int>();
            //customStack.Push(10);
            //customStack.Push(20);
            //customStack.Push(30);
            //Console.WriteLine(customStack.Pop());

            //var customStackList = new CustomStackList<int>();
            //customStackList.Push(10);
            //customStackList.Push(20);
            //customStackList.Push(30);
            //Console.WriteLine(customStackList.Pop());

            //var customQ = new CustomQueue(1000);
            //customQ.Enqueue(10);
            //customQ.Enqueue(20);
            //customQ.Enqueue(30);
            //customQ.Enqueue(40);
            //Console.WriteLine(customQ.Dequeue());
            //Console.WriteLine(customQ.Front());
            //Console.WriteLine(customQ.Rear());

            //var customHash = new CustomHash();
            //customHash.Insert("Hello", 3);
            //Console.WriteLine(customHash.Retrieve("Hello"));

            var bst = new CustomBinarySearchTree();
            bst.Insert(5);
            bst.Insert(3);
            bst.Insert(4);
            bst.Insert(10);
            bst.Insert(12);
            bst.Delete(12);
        }
    }
}
