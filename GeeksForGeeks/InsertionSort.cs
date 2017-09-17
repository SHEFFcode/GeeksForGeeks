using System;
namespace GeeksForGeeks
{
    public class InsertionSort
    {
		//Insertion sort works in a similar way to how we sort playing cards in our hands.
		//We divide our input into a sorted portion and an unsorted portion.

		//Time Complexity: O(n^2).
		//Auxilary Space:  O(1).

		//Max time when items are sorted in reverse order.  Minimum time when the items are fully sorted O(n).
		//Often used when the number of items is small, and when they are already almost fully sorted.
		//It is a little more efficient then selection sort or bubble sort in "practical" scenarios.


		//Example:

		//Input: [23, 42, 4, 16, 8, 15] => Since we haven't started sorting yet, the whole list is unsorted.

		//        |srtd| |---- unsrtd----|
		//Pass 1: [23, | 42, 4, 16, 8, 15] => Let's consider the first element to be the begining of our sorted region.
		//        |-- srtd-| |-- unsrtd--|
		//Pass 2: [23, 42, | 4, 16, 8, 15] => We look at the first number in the sorted section, and try to place it into the sorted region.
		//        |-- srtd ---| |-usrtd--|    We do this by comparing the first number in unsorted seciton and the inserting it into the right place in sorted region.
		//Pass 3: [4, 23, 42,|  16, 8, 15] => Here we take 4, and see where to place it, then move srted region members to the right if they are larger then 4. Then drop in 4.
		//        |--- srtd ------| |unsr|
		//Pass 4: [4, 16, 23, 42, | 8, 15] => here we take 16, move the soted elements greater then it to the irght and then dorp it into the approriate area.
		//        |---- srted -------||us|
		//Pass 5: [4, 8, 16, 23, 42, | 15] => 8
		//        |-------- sorted ----|
		//Pass 6: [4, 8, 15,  16, 23, 42] => array is fully sorted so our algorithm ends.


		//Links:
		//https://www.youtube.com/watch?v=DFG-XuyPYUQ - CS50
		//https://www.youtube.com/watch?v=i-SKeOcBwko - my code school video
		//https://www.youtube.com/watch?v=OGzPmgsI-pQ - G4G Video
		//http://www.geeksforgeeks.org/insertion-sort/ - G4G written explanation


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
