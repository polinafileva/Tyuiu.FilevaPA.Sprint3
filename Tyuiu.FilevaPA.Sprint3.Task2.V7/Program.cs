namespace Tyuiu.FilevaPA.Sprint3.Task2.V7;
using Tyuiu.FilevaPA.Sprint3.Task2.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл do...while                                                   *");
        Console.WriteLine("* Задание #2                                                            *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму  *");
        Console.WriteLine("* ряда по формуле:                                                        *");
        Console.WriteLine("*     10                                                                  *");
        Console.WriteLine("* S = ∑ sin(1/k²)                                                         *");
        Console.WriteLine("*    k=1                                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine($"Начальное значение k = {startValue}");
        Console.WriteLine($"Конечное значение k = {stopValue}");
        Console.WriteLine("Формула: S = ∑ sin(1/k²)");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSeries(startValue, stopValue);

        Console.WriteLine($"Сумма ряда S = {result}");

        // Детальный вывод каждого члена ряда
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("k\t\t1/k²\t\t\tЧлен ряда");
        Console.WriteLine("------------------------------------------------");

        double detailedSum = 0;
        int k = startValue;
        do
        {
            double denominator = Math.Pow(k, 2);
            double argument = 1.0 / denominator;
            double term = Math.Sin(argument);
            detailedSum += term;

            Console.WriteLine($"{k}\t\t{argument:F6}\t\t{term:F6}");
            k++;
        }
        while (k <= stopValue);

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"Итоговая сумма: {Math.Round(detailedSum, 3)}");

        Console.ReadKey();
    }
}