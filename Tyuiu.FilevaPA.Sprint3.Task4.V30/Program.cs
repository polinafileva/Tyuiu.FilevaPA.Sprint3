namespace Tyuiu.FilevaPA.Sprint3.Task4.V30;
using Tyuiu.FilevaPA.Sprint3.Task4.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл while                                                        *");
        Console.WriteLine("* Задание #4                                                             *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
        Console.WriteLine("* функции y = sin(x)/x. При х = 0 пропустить значение.                   *");
        Console.WriteLine("* Полученные значения суммировать.                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Начальное значение x = {startValue}");
        Console.WriteLine($"Конечное значение x = {stopValue}");
        Console.WriteLine("Функция: y = sin(x)/x");
        Console.WriteLine("При x = 0 значение пропускается");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(startValue, stopValue);

        Console.WriteLine($"Сумма значений функции = {result}");

        // Детальный вывод каждого значения
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("x\t\ty = sin(x)/x");
        Console.WriteLine("------------------------");

        double detailedSum = 0;
        int x = startValue;
        while (x <= stopValue)
        {
            if (x == 0)
            {
                Console.WriteLine($"{x}\t\tпропущено (деление на 0)");
            }
            else
            {
                double y = Math.Sin(x) / x;
                detailedSum += y;
                Console.WriteLine($"{x}\t\t{Math.Round(y, 6)}");
            }
            x++;
        }

        Console.WriteLine("------------------------");
        Console.WriteLine($"Сумма: {Math.Round(detailedSum, 3)}");

        Console.ReadKey();
    }
}