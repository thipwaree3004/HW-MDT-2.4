using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the total number of road segments (N) and the range (K):");
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        Console.WriteLine("Enter the population in each road segment:");
        int[] population = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxCustomers = FindMaxCustomers(population, N, K);
        Console.WriteLine("Maximum number of customers: " + maxCustomers);
    }

    static int FindMaxCustomers(int[] population, int N, int K)
    {
        int maxCustomers = 0;

        for (int i = 0; i <= N - K; i++)
        {
            int sum = 0;
            for (int j = i; j < i + K; j++)
            {
                sum += population[j];
            }
            maxCustomers = Math.Max(maxCustomers, sum);
        }

        return maxCustomers;
    }
}
