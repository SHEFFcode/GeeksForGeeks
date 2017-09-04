using System;

namespace GeeksForGeeks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var swap = new Swap();
            swap.Run(5, 10);

            var selectionSort = new SelectionSort();
            selectionSort.Run(new int[] {64, 25, 12, 22, 11});

            var insertionSort = new InsertionSort();
            insertionSort.Run(new int[]{7, 8, 5, 2, 4, 6, 3 });
        }
    }
}
