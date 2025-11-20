namespace Tyuiu.FilevaPA.Sprint3.Task3.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
public class DataService : ISprint3Task3V10
{
    public string DeleteCharInString(string value, char item)
    {
        string result = "";

        // Цикл foreach по всем символам строки
        foreach (char c in value)
        {
            // Если символ не равен удаляемому, добавляем его в результат
            if (c != item)
            {
                result += c;
            }
        }

        return result;
    }
}
