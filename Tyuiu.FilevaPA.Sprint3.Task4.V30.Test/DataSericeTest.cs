namespace Tyuiu.FilevaPA.Sprint3.Task4.V30.Test;
    using Tyuiu.FilevaPA.Sprint3.Task4.V30.Lib;
{
    [TestClass]
    public sealed class DataSericeTest
    {
    [TestMethod]
    public void ValidCalculate_XMinus5To5()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        double result = ds.Calculate(startValue, stopValue);

        // Ручной расчет для проверки (без x=0)
        double expected = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            if (x != 0)
            {
                expected += System.Math.Sin(x) / x;
            }
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_XMinus3To3()
    {
        DataService ds = new DataService();
        int startValue = -3;
        int stopValue = 3;
        double result = ds.Calculate(startValue, stopValue);

        double expected = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            if (x != 0)
            {
                expected += System.Math.Sin(x) / x;
            }
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_X1To5()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 5;
        double result = ds.Calculate(startValue, stopValue);

        double expected = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            expected += System.Math.Sin(x) / x;
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_ZeroSkipped()
    {
        DataService ds = new DataService();
        int startValue = -1;
        int stopValue = 1;
        double result = ds.Calculate(startValue, stopValue);

        // Должны быть только x=-1 и x=1, x=0 пропущен
        double expected = (System.Math.Sin(-1) / -1) + (System.Math.Sin(1) / 1);
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_RoundingTest()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        double result = ds.Calculate(startValue, stopValue);

        // Проверяем, что результат округлен до 3 знаков
        string resultString = result.ToString("F10");
        int decimalPlaces = resultString.Length - resultString.IndexOf('.') - 1;
        Assert.IsTrue(decimalPlaces <= 3);
    }

    [TestMethod]
    public void ValidCalculate_AllValuesCalculated()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        double result = ds.Calculate(startValue, stopValue);

        // Проверяем, что результат не нулевой и не бесконечный
        Assert.IsFalse(double.IsNaN(result));
        Assert.IsFalse(double.IsInfinity(result));
    }
}
