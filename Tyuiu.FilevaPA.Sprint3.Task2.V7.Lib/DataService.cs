namespace Tyuiu.FilevaPA.Sprint3.Task2.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task2V7

{
    public double GetSumSeries(int startValue, int stopValue)
    {
        double sum = 0;
        int k = startValue;

        // Цикл do...while от startValue до stopValue
        do
        {
            double term = k + (1.0 / Math.Pow(k, 2)); // k + 1/k²
            sum += term;
            k++;
        }
        while (k <= stopValue);

        return Math.Round(sum, 3);
    }
}
