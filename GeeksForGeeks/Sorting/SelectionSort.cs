using System;
namespace GeeksForGeeks
{
  public class SelectionSort
  {
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
                    // var temp = inputArr[lowestItemIndex];
                    // inputArr[lowestItemIndex] = inputArr[i];
                    // inputArr[i] = temp;
                    inputArr[lowestItemIndex] = inputArr[lowestItemIndex] + inputArr[i];
                    inputArr[i] = inputArr[lowestItemIndex] - inputArr[i];
                    inputArr[lowestItemIndex] = inputArr[lowestItemIndex] - inputArr[i];
                }

            }

            foreach (var item in inputArr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
