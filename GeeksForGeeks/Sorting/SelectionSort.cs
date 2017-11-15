using System;
namespace GeeksForGeeks
{
  public class SelectionSort
  {
    //The sort algorithm has a sorted and unsorted sections. Simple and most intuitive.
    //The algorithm moves through the unsorted sections and moves items from the unsorted portion to the sorted portion, until the list is sorted.


    //Time Complexity: O(n^2) because of two nested loops.
    //Auxilary Space:  O(1), it never makes more than n swaps and is used whe memory is a concern since done in place.


    //Example:
    //Input: [23, 42, 4, 16, 8, 15]

    //        |------ unsorted -----|
    //Pass 1: [23,  42, 4, 16, 8, 15] => Find the minimum number in the unsorted array, which is 4,  move to sorted portion of list, swapping element at 0 with smallest element.
    //        |srt||------unrtd-----|
    //Pass 2: [4, |42, 23, 16, 8, 15] => Find the minimum number in the unsorted portion of the array, which is 8.  
    //                                    Swap 8 with the first element in unsorted portion and move up sorted section.
    //        |-srt--| |---unsrtd----|
    //Pass 3: [4, 8 ,| 23, 16, 42, 15] => 15
    //        |----srt---| |-unsrtd--|
    //Pass 4: [4, 8, 15, | 16, 42, 23] => 16
    //        |----srted----| |unsrtd|
    //Pass 5: [4, 8, 15, 16 |, 42, 23] => 23
    //        |-------srted-----||uns|
    //Pass 6: [4, 8, 15, 16, 23,|  42] => since we are down to just one element in the unsorted section, we can skip this pass since we are already sorted.


    //Links:
    //https://www.youtube.com/watch?v=f8hXR_Hvybo - CS50 explanation
    //https://www.youtube.com/watch?v=GUDLRan2DWM - my code school explanation
    //https://www.youtube.com/watch?v=xWBP4lzkoyM - selection sort G4G
    //http://www.geeksforgeeks.org/selection-sort/ - G4G Explanation

        public void Run(int[] inputArr)
        {
            var length = inputArr.Length;

            //The unsorted region starts at the length of the array, moves on by 1
            for (int i = 0; i < length; i++) //This can run till length -1 as another way to optimize
            {
                //Let's keep track of the lowest item's index by first setting it to i as a initial value.
                var lowestItemIndex = i;

                //The loop that finds the lowest element in the unsorted region of the array.
                for (int j = i + 1; j < length; j++)
                {
                    if (inputArr[j] < inputArr[lowestItemIndex])
                    {
                        lowestItemIndex = j;
                    }
                }

                //This is an optimization to prevent swapping if lowest index is equal to i.
                //If i is equal to lowest item idex, no swap is necessary.
                if (lowestItemIndex != i)
                {
                    var temp = inputArr[lowestItemIndex];
                    inputArr[lowestItemIndex] = inputArr[i];
                    inputArr[i] = temp;
                }

            }

            foreach (var item in inputArr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
