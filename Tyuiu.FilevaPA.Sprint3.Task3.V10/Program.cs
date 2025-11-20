namespace Tyuiu.FilevaPA.Sprint3.Task3.V10;
using Tyuiu.FilevaPA.Sprint3.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Цикл foreach                                                      *");
        Console.WriteLine("* Задание #3                                                            *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach удалить из строки все буквы p                    *");
        Console.WriteLine("* в строке: gdfppf vfppt p                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string inputString = "gdfppf vfppt p";
        char charToRemove = 'p';

        Console.WriteLine($"Исходная строка: \"{inputString}\"");
        Console.WriteLine($"Удаляемый символ: '{charToRemove}'");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string result = ds.DeleteCharInString(inputString, charToRemove);

        Console.WriteLine($"Результат: \"{result}\"");

        // Детальный вывод процесса
        Console.WriteLine();
        Console.WriteLine("Процесс удаления:");
        Console.WriteLine("Исходная строка: g d f p p f   v f p p t   p");
        Console.WriteLine("Результат:       g d f     f   v f     t    ");

        Console.ReadKey();
    }
}