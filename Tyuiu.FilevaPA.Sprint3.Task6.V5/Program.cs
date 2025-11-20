namespace Tyuiu.FilevaPA.Sprint3.Task6.V5;
using Tyuiu.FilevaPA.Sprint3.Task6.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
        Console.WriteLine("* числовому отрезку [15, 22] сумму всех делителей                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int startValue = 15;
        int stopValue = 22;

        Console.WriteLine($"Начало отрезка: {startValue}");
        Console.WriteLine($"Конец отрезка: {stopValue}");
        Console.WriteLine($"Отрезок: [{startValue}, {stopValue}]");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetSumTheDivisors(startValue, stopValue);

        Console.WriteLine($"Сумма всех делителей всех чисел на отрезке = {result}");

        // Детальный вывод расчета
        Console.WriteLine();
        Console.WriteLine("Детальный расчет:");
        Console.WriteLine("Число\tДелители\t\t\tСумма делителей");
        Console.WriteLine("----------------------------------------------------------------");

        int totalSum = 0;
        for (int num = startValue; num <= stopValue; num++)
        {
            string divisors = "";
            int sumDivisors = 0;

            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    sumDivisors += divisor;
                    divisors += divisor + " ";
                }
            }

            totalSum += sumDivisors;
            Console.WriteLine($"{num}\t{divisors.PadRight(25)}\t{sumDivisors}");
        }

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"Общая сумма: {totalSum}");

        Console.ReadKey();
    }
}