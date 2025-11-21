namespace Tyuiu.FilevaPA.Sprint3.Task7.V30.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task7V30
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        int length = stopValue - startValue + 1;
        double[] results = new double[length];

        for (int i = 0; i < length; i++)
        {
            int x = startValue + i;
            results[i] = CalculateFunction(x);
        }

        return results;
    }

    private double CalculateFunction(int x)
    {
        double denominator = Math.Sin(x) + 2;

        // Проверка деления на ноль
        if (Math.Abs(denominator) < 1e-10)
        {
            return 0;
        }

        double result = (5 * x + 2.5) / denominator + 2 * x + 2;
        return Math.Round(result, 2);
    }
}
