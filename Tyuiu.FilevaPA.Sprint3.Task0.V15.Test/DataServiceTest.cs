namespace Tyuiu.FilevaPA.Sprint3.Task0.V15.Test;
using Tyuiu.FilevaPA.Sprint3.Task0.V15.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries_T07_K1To10()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Ручной расчет для проверки
        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += (System.Math.Pow(t, k) + (2.0 / (k + 1))) * System.Math.Sin(t);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_T05_K1To5()
    {
        DataService ds = new DataService();
        double t = 0.5;
        int startValue = 1;
        int stopValue = 5;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += (System.Math.Pow(t, k) + (2.0 / (k + 1))) * System.Math.Sin(t);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_T10_K1To3()
    {
        DataService ds = new DataService();
        double t = 1.0;
        int startValue = 1;
        int stopValue = 3;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += (System.Math.Pow(t, k) + (2.0 / (k + 1))) * System.Math.Sin(t);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_RoundingTest()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Проверяем, что результат округлен до 3 знаков
        string resultString = result.ToString("F10");
        int decimalPlaces = resultString.Length - resultString.IndexOf('.') - 1;
        Assert.IsTrue(decimalPlaces <= 3);
    }

    [TestMethod]
    public void ValidGetSumSeries_SingleIteration()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 1;
        int stopValue = 1;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Для k=1: (0.7^1 + 2/2) * sin(0.7) = (0.7 + 1) * 0.644218 = 1.7 * 0.644218
        double expected = (System.Math.Pow(t, 1) + (2.0 / 2)) * System.Math.Sin(t);
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_DifferentRange()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 5;
        int stopValue = 8;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += (System.Math.Pow(t, k) + (2.0 / (k + 1))) * System.Math.Sin(t);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_AllIterations()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Проверяем, что результат не нулевой и не бесконечный
        Assert.IsFalse(double.IsNaN(result));
        Assert.IsFalse(double.IsInfinity(result));
        Assert.AreNotEqual(0, result);
    }
}
