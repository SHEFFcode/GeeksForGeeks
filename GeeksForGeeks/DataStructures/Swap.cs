using System;
namespace GeeksForGeeks
{
    public class Swap
    {
        //Swap just swaps two integers in conastant O(1) time complexity.

        public void Run(int x, int y)
        {
            Console.WriteLine($"x was {x}, y was {y}");

            //var temp = x;
            //x = y;
            //y = temp;

            //x = x + y;
            //y = x - y;
            //x = x - y;

            (x,y) = (y, x); // the touple method

            Console.WriteLine($"x is now {x}, y is now {y}");
        }
    }
}
