using System;
namespace GeeksForGeeks.Sorting
{
    public class StableSelectionSort
    {
        public void Run(int[] inputArr)
        {
            var length = inputArr.Length; //to make life easier

            //The unsorted region starts at the length of the array, moves on by 1
            for (int i = 0; i < length - 1; i++) //This can run till length - 1 as another way to optimize
            {
                //Let's keep track of the lowest item's index by first setting it to i as a initial value.
                var lowestItemIndex = i;

                //The loop that finds the lowest element in the unsorted region of the array.
                for (int j = i + 1; j < length; j++)
                {
                    if (inputArr[j] < inputArr[lowestItemIndex])
                    {
                        lowestItemIndex = j; // current passes's lowest item
                    }
                }

                var key = inputArr[lowestItemIndex]; // keep track of the min key
                while (lowestItemIndex > i) // while loop to shift items to the right
                {
                    inputArr[lowestItemIndex] = inputArr[lowestItemIndex - 1]; // actual shift to right
                    lowestItemIndex--; // move on till u hit i
                }

                inputArr[i] = key; //place key in the new "opened up slot"


            } //once we are done with this loop we have a table sorted array.

            foreach (var item in inputArr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
