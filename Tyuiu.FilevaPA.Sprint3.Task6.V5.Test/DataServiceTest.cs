namespace Tyuiu.FilevaPA.Sprint3.Task6.V5.Test;
using Tyuiu.FilevaPA.Sprint3.Task6.V5.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumTheDivisors_15To22()
    {
        DataService ds = new DataService();
        int startValue = 15;
        int stopValue = 22;
        int result = ds.GetSumTheDivisors(startValue, stopValue);

        // Ручной расчет:
        // 15: делители 1,3,5,15 → сумма = 24
        // 16: делители 1,2,4,8,16 → сумма = 31
        // 17: делители 1,17 → сумма = 18
        // 18: делители 1,2,3,6,9,18 → сумма = 39
        // 19: делители 1,19 → сумма = 20
        // 20: делители 1,2,4,5,10,20 → сумма = 42
        // 21: делители 1,3,7,21 → сумма = 32
        // 22: делители 1,2,11,22 → сумма = 36
        // Общая сумма: 24+31+18+39+20+42+32+36 = 242

        int expected = 242;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumTheDivisors_1To5()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 5;
        int result = ds.GetSumTheDivisors(startValue, stopValue);

        // Ручной расчет:
        // 1: делители 1 → сумма = 1
        // 2: делители 1,2 → сумма = 3
        // 3: делители 1,3 → сумма = 4
        // 4: делители 1,2,4 → сумма = 7
        // 5: делители 1,5 → сумма = 6
        // Общая сумма: 1+3+4+7+6 = 21

        int expected = 21;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumTheDivisors_SingleNumber()
    {
        DataService ds = new DataService();
        int startValue = 6;
        int stopValue = 6;
        int result = ds.GetSumTheDivisors(startValue, stopValue);

        // 6: делители 1,2,3,6 → сумма = 12
        int expected = 12;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumTheDivisors_PrimeNumbers()
    {
        DataService ds = new DataService();
        int startValue = 11;
        int stopValue = 13;
        int result = ds.GetSumTheDivisors(startValue, stopValue);

        // 11: делители 1,11 → сумма = 12
        // 12: делители 1,2,3,4,6,12 → сумма = 28
        // 13: делители 1,13 → сумма = 14
        // Общая сумма: 12+28+14 = 54

        int expected = 54;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumTheDivisors_EmptyRange()
    {
        DataService ds = new DataService();
        int startValue = 10;
        int stopValue = 5; // некорректный диапазон
        int result = ds.GetSumTheDivisors(startValue, stopValue);

        // При некорректном диапазоне цикл не выполнится
        int expected = 0;
        Assert.AreEqual(expected, result);
    }
}  