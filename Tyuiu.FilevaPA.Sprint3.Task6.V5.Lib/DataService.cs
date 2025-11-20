namespace Tyuiu.FilevaPA.Sprint3.Task6.V5.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task6V5
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int totalSum = 0;

        // Цикл по всем числам от startValue до stopValue
        for (int num = startValue; num <= stopValue; num++)
        {
            // Находим сумму делителей для текущего числа
            int sumDivisors = 0;

            // Проверяем все возможные делители от 1 до num
            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    sumDivisors += divisor;
                }
            }

            totalSum += sumDivisors;
        }

        return totalSum;
    }
}
