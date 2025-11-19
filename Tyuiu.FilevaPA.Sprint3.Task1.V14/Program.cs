namespace Tyuiu.FilevaPA.Sprint3.Task1.V14;
using Tyuiu.FilevaPA.Sprint3.Task1.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл while                                                        *");
        Console.WriteLine("* Задание #1                                                            *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда  *");
        Console.WriteLine("* по формуле, при t = 0:                                                  *");
        Console.WriteLine("* S = ∑(t^k + 1/(k+1)) * cos(t)  для k от 1 до 14                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double t = 0;
        int startValue = 1;
        int stopValue = 14;

        Console.WriteLine($"Значение t = {t}");
        Console.WriteLine($"Начальное значение k = {startValue}");
        Console.WriteLine($"Конечное значение k = {stopValue}");
        Console.WriteLine("Формула: S = ∑(t^k + 1/(k+1)) * cos(t)");

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
        int k = startValue;
        while (k <= stopValue)
        {
            double term = (Math.Pow(t, k) + (1.0 / (k + 1))) * Math.Cos(t);
            detailedSum += term;
            Console.WriteLine($"{k}\t\t{Math.Round(term, 6)}");
            k++;
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Итоговая сумма: {Math.Round(detailedSum, 3)}");

        // Особый случай при t=0
        Console.WriteLine();
        Console.WriteLine("Особый случай при t=0:");
        Console.WriteLine("t^k = 0^k = 0 для любого k > 0");
        Console.WriteLine("cos(t) = cos(0) = 1");
        Console.WriteLine("Каждый член ряда: (0 + 1/(k+1)) * 1 = 1/(k+1)");

        Console.ReadKey();
    }
}