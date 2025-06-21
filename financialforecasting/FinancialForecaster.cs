// See https://aka.ms/new-console-template for more information
using System;

class FinancialForecaster
{
    // Recursive approach
    public static double CalculateFutureValue(double currentValue, double growthRate, int periods)
    {
        if (periods <= 0)
            return currentValue;
        double nextValue = currentValue * (1 + growthRate);
        return CalculateFutureValue(nextValue, growthRate, periods - 1);
    }

    // Optimized iterative approach
    public static double CalculateFutureValueOptimized(double currentValue, double growthRate, int periods)
    {
        return currentValue * Math.Pow(1 + growthRate, periods);
    }

    public static void Main(string[] args)
    {
        double initialValue = 25000;    
        double growthRate = 0.10;     
        int forecastPeriods = 11;      

        // Using recursive method
        double futureValueRecursive = CalculateFutureValue(initialValue, growthRate, forecastPeriods);

        // Using optimized iterative method
        double futureValueOptimized = CalculateFutureValueOptimized(initialValue, growthRate, forecastPeriods);

        Console.WriteLine($"Initial investment: ${initialValue}");
        Console.WriteLine($"Projected value after {forecastPeriods} periods (recursive): ${futureValueRecursive:F2}");
        Console.WriteLine($"Projected value after {forecastPeriods} periods (optimized): ${futureValueOptimized:F2}");
    }
}
