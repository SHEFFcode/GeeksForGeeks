using System;
namespace GeeksForGeeks
{
    public class SelectionSort
    {
		//The sort algorithm has a sorted and unsorted sections.
		//The algorithm moves through the unsorted sections and moves the minimum element to the front


        //Example:
		//Input: [64, 25, 12, 22, 11]

		//Pass 1: [11, 25, 12, 22, 64]
		//Pass 2: [11, 12, 25, 22, 64]
		//Pass 3: [11, 12, 22, 25, 64]
        //Pass 4: [11, 12, 22, 25, 64] => You can see this is redundant, could be optimized

        //Time complexity is O(n^2) because of two nested loops.
        //Auxilary space is O(1), it never makes more than n swaps and is used when
        //memory write is a costly operation.

		public void Run(int[] inputArr)
        {
            var length = inputArr.Length;

			//The unexplored region starts at the length of the array
			for (int i = 0; i < length; i++)
            {
                //We move explored region forward by 1 every iteration by moving along the i
                var lowestItemIndex = i;

				//Explored region moves ahead by 1 item along with the i.
				for (int j = i + 1; j < length; j++)
                {
					if (inputArr[j] < inputArr[lowestItemIndex])
                    {
                        var temp = inputArr[j];
                        inputArr[j] = inputArr[lowestItemIndex];
                        inputArr[lowestItemIndex] = temp;
                    }
                }
            }

            foreach (var item in inputArr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
