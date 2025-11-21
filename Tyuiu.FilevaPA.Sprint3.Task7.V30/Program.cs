namespace Tyuiu.FilevaPA.Sprint3.Task7.V30;
using Tyuiu.FilevaPA.Sprint3.Task7.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
        Console.WriteLine("* F(x) = (5x + 2.5)/(sin(x) + 2) + 2x + 2                                *");
        Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль.   *");
        Console.WriteLine("* При делении на ноль вернуть значение 0.                                *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой.                       *");
        Console.WriteLine("* Значения занести в массив!                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine($"Начало отрезка: {startValue}");
        Console.WriteLine($"Конец отрезка: {stopValue}");
        Console.WriteLine($"Отрезок: [{startValue}, {stopValue}]");
        Console.WriteLine($"Шаг: 1");
        Console.WriteLine($"Функция: F(x) = (5x + 2.5)/(sin(x) + 2) + 2x + 2");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызов метода GetMassFunction
        double[] resultArray = ds.GetMassFunction(startValue, stopValue);

        // Вывод таблицы значений
        Console.WriteLine("Таблица значений функции:");
        Console.WriteLine("------------------------");
        Console.WriteLine("   x   |   F(x)   ");
        Console.WriteLine("------------------------");

        for (int i = 0; i < resultArray.Length; i++)
        {
            int x = startValue + i;
            Console.WriteLine($"  {x,3}  |  {resultArray[i],7:F2}  ");
        }

        Console.WriteLine("------------------------");

        // Вывод массива
        Console.WriteLine("\nМассив значений (результат работы метода GetMassFunction):");
        Console.Write("double[] result = { ");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i].ToString("F2"));
            if (i < resultArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");

        // Информация о массиве
        Console.WriteLine($"\nИнформация о массиве:");
        Console.WriteLine($"Количество элементов: {resultArray.Length}");
        Console.WriteLine($"Первый элемент: {resultArray[0]:F2}");
        Console.WriteLine($"Последний элемент: {resultArray[resultArray.Length - 1]:F2}");

        Console.ReadKey();
    }
}