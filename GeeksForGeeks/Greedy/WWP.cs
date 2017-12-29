using System;
using System.Text;

namespace GeeksForGeeks.DynamicProgramming
{
    public class WWP
    {
        public WWP()
        {
        }

        //This is the greedy implementation rather then DP. See theory for more
        public void RunWWPGreedy(string input, int max = 6)
        {
            var line = new StringBuilder(); //set up a string builder to contain the line
            var words = input.Split(' '); // split the string into [] of words based on spaces

            foreach (var word in words) //iterate over the words
            {
                if ((word + line).Length < max) //if we are < max here, we can put a space
                {
                    line.Append(word + ' '); // append word and space
                }
                else if ((word + line).Length == max) // if we are == to max, we can't put a space
                {
                    line.Append(word);
                    Console.WriteLine(line); //print out the line bcause we have reached the max
                    line.Clear(); //clear out the stringbuilder to accept new lines.
                }
                else //line becomes too long here
                {
                    Console.WriteLine(line);
                    line.Clear(); //clear it out since its full
                    line.Append(word);
                }
            }

            if (line.Length > 0) //this is some final cleanup in case we finished in a state where line has not been printed.
            {
                Console.WriteLine(line); //we print the line
                line.Clear(); //we clear it to release memory
            }
        }
    }
}
