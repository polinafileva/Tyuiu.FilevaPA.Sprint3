namespace Tyuiu.FilevaPA.Sprint3.Task0.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task0V15
{
    public double GetSumSeries(double value, int startValue, int stopValue)
    {
        double sum = 0;

        // Цикл for от startValue до stopValue
        for (int k = startValue; k <= stopValue; k++)
        {
            double term = (Math.Pow(value, k) + (2.0 / (k + 1))) * Math.Sin(value);
            sum += term;
        }

        return Math.Round(sum, 3);
    }
}

