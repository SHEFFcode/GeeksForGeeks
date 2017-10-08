﻿using System;
using GeeksForGeeks.Greedy;

namespace GeeksForGeeks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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

            var ditka = new DitkasAlgo();
            ditka.Run(new int[][]{new int[] {0, 4, 0, 0, 0, 0, 0, 8, 0},
                                  new int[]{4, 0, 8, 0, 0, 0, 0, 11, 0},
                                  new int[]{0, 8, 0, 7, 0, 4, 0, 0, 2},
                                  new int[]{0, 0, 7, 0, 9, 14, 0, 0, 0},
                                  new int[]{0, 0, 0, 9, 0, 10, 0, 0, 0},
                                  new int[]{0, 0, 4, 14, 10, 0, 2, 0, 0},
                                  new int[]{0, 0, 0, 0, 0, 2, 0, 1, 6},
                                  new int[]{8, 11, 0, 0, 0, 0, 1, 0, 7},
                                  new int[]{0, 0, 2, 0, 0, 0, 6, 7, 0}
            }, 0);
        }
    }
}
