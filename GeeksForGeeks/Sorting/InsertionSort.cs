using System;
namespace GeeksForGeeks
{
    public class InsertionSort
    {
        public void Run(int[] inputArr)
        {
            var length = inputArr.Length; // Just to make our lives simpler.

            //we want to start at 1 because the first element cannot be greater or less then itself.
            for (int i = 1; i < length; i++)
            {
                var key = inputArr[i]; // serves both as temp storage and as a key to compare current item with
                var j = i - 1; // index of the item to the left of the current item for comparison. This is the first item in the sorted section

                //We want to make j >= to 0 because we don't want to stop sorting at the first element, want to be able to go to the front and insert there.
                while (j >= 0 && key < inputArr[j])
                {
                    //This is the wapping section, this will grab an element to the right (which is the current element in the prev loop and move it right.
                    inputArr[j + 1] = inputArr[j];
                    j--; //then we go left one.
                }
                //when we exit the while loop it means that we found where to drop the element and we are one to the left of where that place is.
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
