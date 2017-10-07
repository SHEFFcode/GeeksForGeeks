using System;
namespace GeeksForGeeks.Greedy
{
  public class ActivitySelection
  {
    // Approach: Sort the input by end time.  Print the first activity.  Print all subsiquent activities whose start time is greater then
    // or equal to previous activity's end time.

    //Input start[10, 12, 20]; end[20, 25, 30];  Find max number of activities one person can attend.

    //  i: start[10, 12, 20]; end[20, 25, 30];
    // p1: print [10, 20] => we always print the first activity
    // p2: skip 12, 25 => skip because 12 is < 20 (start less then prev finish)
    // p3: print 20, 30 => print because 2- == 20 (start >= prev finish)

    public void Run(int[] start, int[] finish)
    {

      // Here we assume that array given to us will always be sorted.
      // For sorting, see sorting algo section.
      Console.WriteLine($"{start[0]}, {finish[0]}");

      var i = 0;

      for (int j = 1; j < start.Length; j++)
      {
        if (start[j] >= finish[i])
        {
          Console.WriteLine($"{start[j]}, {finish[j]}");
          i = j;
        }
      }

    }

  }
}
