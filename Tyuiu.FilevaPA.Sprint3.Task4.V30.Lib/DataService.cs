namespace Tyuiu.FilevaPA.Sprint3.Task4.V30.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task4V30
{
    public double Calculate(int startValue, int stopValue)
    {
        double sum = 0;
        int x = startValue;

        while (x <= stopValue)
        {
            if (x == 0)
            {
                x++;
                continue;
            }

            double y = Math.Sin(x) / x;
            sum += y;
            x++;
        }

        return Math.Round(sum, 3);
    }
}
