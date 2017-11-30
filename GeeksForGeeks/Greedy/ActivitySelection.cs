using System;
namespace GeeksForGeeks.Greedy
{
  public class ActivitySelection
  {
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
