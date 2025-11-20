namespace Tyuiu.FilevaPA.Sprint3.Task5.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task5V10
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double sum = 0;

        // Внешний цикл по i от startValue1 до stopValue1
        for (int i = startValue1; i <= stopValue1; i++)
        {
            // Внутренний цикл по k от startValue2 до stopValue2
            for (int k = startValue2; k <= stopValue2; k++)
            {
                // Вычисляем (x³ * k) + 2
                double term = (Math.Pow(x, 3) * k) + 2;
                sum += term;
            }
        }

        return sum;
    }
}
