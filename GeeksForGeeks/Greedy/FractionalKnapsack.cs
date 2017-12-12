using System;
namespace GeeksForGeeks.Greedy
{
    public class FractionalKnapsack
    {
        public FractionalKnapsack()
        {
        }

        public void Run(int maxWeight, int[,] items, int numberOfItems)
        {
            int currentWeight = 0;
            double valueInKnapsack = 0.0d;

            for (int i = 0; i < numberOfItems; i++)
            {
                if (currentWeight + items[i,1] <= maxWeight)
                {
                    currentWeight += items[i, 1];
                    valueInKnapsack += items[i, 0];
                }
                else 
                {
                    var remainingWeight = maxWeight - currentWeight;
                    var ratio = ((double)remainingWeight / (double)items[i, 1]);
                    valueInKnapsack += items[i, 0] * ratio;
                    break; // the knapsack is full, so we wanna break
                }
            }
            Console.WriteLine($"Max value we can fit in a knapsack is {valueInKnapsack}");
        }
    }
}
