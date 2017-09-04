using System;
namespace GeeksForGeeks
{
    public class InsertionSort
    {
        //Insertion sort works in a similar way to how we sort playing cards in our hands
        //Run time complexity is O(n^2).
        //Max time when items are sorted in reverse order.  Minimum time when the items are fully sorted
        //Often used when the number of items is small, and when they are already almost fully sorted


        //Example:

        //Input:  [7, 8, 5, 2, 4, 6, 3]

        //Pass 1: [7, 8, 5, 2, 4, 6, 3]
        //Pass 2: [5, 7, 8, 2, 4, 6, 3]
        //Pass 3: [2, 5, 7, 8, 4, 6, 3]
        //Pass 4: [2, 4, 5, 7, 8, 6, 3]
        //Pass 5: [2, 4, 5, 6, 7, 8, 3]
        //Pass 6: [2, 3, 4, 5, 6, 7, 8]

        public void Run(int[] inputArr)
        {
            var length = inputArr.Length;

            //we want to start at 1 because the first element cannot be greater or less then itself.
            for (int i = 1; i < length; i++)
            {
                var key = inputArr[i]; // serves both as temp storage and as a key to compare current item with
                var j = i - 1;

                //We want to make j >= to 0 because we don't want to stop sorting at the first element, want to go to the end.
                while (j >= 0 && key < inputArr[j])
                {
                    //The reason why we go ++ is that we want to move the value to the right there before examining the next item with --
                    inputArr[j + 1] = inputArr[j];
                    j--;
                }
                //The reason why we do ++ here is because we want to return to previous poisition from going back one i j-- above.
                inputArr[j + 1] = key;
            }

            Console.WriteLine("Insertion sort results:");
            foreach (var item in inputArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
