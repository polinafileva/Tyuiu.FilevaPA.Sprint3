namespace Tyuiu.FilevaPA.Sprint3.Task5.V10;
using Tyuiu.FilevaPA.Sprint3.Task5.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение выражения:                                          *");
        Console.WriteLine("* y = ∑∑(x³ * k) + 2  для i=1..3, k=1..10 при X=5                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int x = 5;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 10;

        Console.WriteLine($"Значение X = {x}");
        Console.WriteLine($"Внешний цикл: i от {startValue1} до {stopValue1}");
        Console.WriteLine($"Внутренний цикл: k от {startValue2} до {stopValue2}");
        Console.WriteLine("Формула: y = ∑∑(x³ * k) + 2");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        Console.WriteLine($"Результат: y = {result}");

        // Детальный вывод расчета
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("i\tk\tx³\tx³ * k\t(x³ * k) + 2");
        Console.WriteLine("------------------------------------------------");

        double xCubed = Math.Pow(x, 3); // 5³ = 125
        double totalSum = 0;

        for (int i = startValue1; i <= stopValue1; i++)
        {
            for (int k = startValue2; k <= stopValue2; k++)
            {
                double term = (xCubed * k) + 2;
                totalSum += term;
                Console.WriteLine($"{i}\t{k}\t{xCubed}\t{xCubed * k}\t{term}");
            }
            if (i < stopValue1)
            {
                Console.WriteLine("------------------------------------------------");
            }
        }

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Общая сумма: {totalSum}");

        // Проверка расчета
        Console.WriteLine();
        Console.WriteLine("Проверка:");
        Console.WriteLine($"x³ = {x}³ = {xCubed}");

        int sumK = 0;
        for (int k = startValue2; k <= stopValue2; k++)
        {
            sumK += k;
        }

        int countK = stopValue2 - startValue2 + 1;
        int countI = stopValue1 - startValue1 + 1;

        Console.WriteLine($"Сумма k от {startValue2} до {stopValue2} = {sumK}");
        Console.WriteLine($"Сумма (x³ * k) для k={startValue2}..{stopValue2} = {xCubed} * {sumK} = {xCubed * sumK}");
        Console.WriteLine($"Сумма (x³ * k) + 2 для k={startValue2}..{stopValue2} = {xCubed * sumK} + {2 * countK} = {xCubed * sumK + 2 * countK}");
        Console.WriteLine($"Для i={startValue1}..{stopValue1}: {countI} * ({xCubed * sumK + 2 * countK}) = {countI * (xCubed * sumK + 2 * countK)}");

        Console.ReadKey();
    }
}