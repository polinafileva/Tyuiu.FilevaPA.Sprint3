namespace Tyuiu.FilevaPA.Sprint3.Task1.V14.Test;
using Tyuiu.FilevaPA.Sprint3.Task1.V14.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries_T0_K1To14()
    {
        DataService ds = new DataService();
        double t = 0;
        int startValue = 1;
        int stopValue = 14;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // При t=0: t^k = 0, cos(t) = 1
        // Формула упрощается до: ∑(1/(k+1)) для k от 1 до 14
        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += 1.0 / (k + 1);
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
            expected += (System.Math.Pow(t, k) + (1.0 / (k + 1))) * System.Math.Cos(t);
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
            expected += (System.Math.Pow(t, k) + (1.0 / (k + 1))) * System.Math.Cos(t);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_RoundingTest()
    {
        DataService ds = new DataService();
        double t = 0;
        int startValue = 1;
        int stopValue = 14;
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
        double t = 0;
        int startValue = 1;
        int stopValue = 1;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Для k=1 при t=0: (0^1 + 1/2) * cos(0) = (0 + 0.5) * 1 = 0.5
        double expected = 0.5;
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_DifferentRange()
    {
        DataService ds = new DataService();
        double t = 0;
        int startValue = 5;
        int stopValue = 8;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += 1.0 / (k + 1);
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_AllIterations()
    {
        DataService ds = new DataService();
        double t = 0;
        int startValue = 1;
        int stopValue = 14;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // Проверяем, что результат не нулевой и не бесконечный
        Assert.IsFalse(double.IsNaN(result));
        Assert.IsFalse(double.IsInfinity(result));
        Assert.AreNotEqual(0, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_ZeroTSpecialCase()
    {
        DataService ds = new DataService();
        double t = 0;
        int startValue = 1;
        int stopValue = 14;
        double result = ds.GetSumSeries(t, startValue, stopValue);

        // При t=0 формула упрощается до гармонического ряда (смещенного)
        // ∑(1/(k+1)) для k от 1 до 14 = 1/2 + 1/3 + ... + 1/15
        double expected = 1.0 / 2 + 1.0 / 3 + 1.0 / 4 + 1.0 / 5 + 1.0 / 6 + 1.0 / 7 + 1.0 / 8 +
                         1.0 / 9 + 1.0 / 10 + 1.0 / 11 + 1.0 / 12 + 1.0 / 13 + 1.0 / 14 + 1.0 / 15;
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }
}
