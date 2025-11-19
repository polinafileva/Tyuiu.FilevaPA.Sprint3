namespace Tyuiu.FilevaPA.Sprint3.Task0.V15;
using Tyuiu.FilevaPA.Sprint3.Task0.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема: Цикл for                                                          *");
        Console.WriteLine("* Задание #0                                                            *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда    *");
        Console.WriteLine("* по формуле, при t = 0,7:                                                *");
        Console.WriteLine("* S = ∑(t^k + 2/(k+1)) * sin(t)  для k от 1 до 10                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine($"Значение t = {t}");
        Console.WriteLine($"Начальное значение k = {startValue}");
        Console.WriteLine($"Конечное значение k = {stopValue}");
        Console.WriteLine("Формула: S = ∑(t^k + 2/(k+1)) * sin(t)");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSeries(t, startValue, stopValue);

        Console.WriteLine($"Сумма ряда S = {result}");

        // Детальный вывод каждого члена ряда
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("k\t\tЧлен ряда");
        Console.WriteLine("--------------------------------");

        double detailedSum = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            double term = (Math.Pow(t, k) + (2.0 / (k + 1))) * Math.Sin(t);
            detailedSum += term;
            Console.WriteLine($"{k}\t\t{Math.Round(term, 6)}");
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Итоговая сумма: {Math.Round(detailedSum, 3)}");

        Console.ReadKey();
    }
}