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
        }
    }
}
