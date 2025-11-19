namespace Tyuiu.FilevaPA.Sprint3.Task1.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task1V14
{
    public DataService()
    {
    }

    public double GetSumSeries(double value, int startValue, int stopValue)
    {
        double sum = 0;
        int k = startValue;

        // Цикл while от startValue до stopValue
        while (k <= stopValue)
        {
            double term = (Math.Pow(value, k) + (1.0 / (k + 1))) * Math.Cos(value);
            sum += term;
            k++;
        }

        return Math.Round(sum, 3);
    }
}

