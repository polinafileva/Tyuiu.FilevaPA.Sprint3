namespace Tyuiu.FilevaPA.Sprint3.Task2.V7.Test;
using Tyuiu.FilevaPA.Sprint3.Task2.V7.Lib;
[TestClass]
public sealed class DataServiceTest
{

    [TestMethod]
    public void ValidGetSumSeries_K1To10()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(startValue, stopValue);

        // Ручной расчет для проверки
        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += System.Math.Sin(1.0 / System.Math.Pow(k, 2));
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_K1To5()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 5;
        double result = ds.GetSumSeries(startValue, stopValue);

        double expected = 0;
        for (int k = startValue; k <= stopValue; k++)
        {
            expected += System.Math.Sin(1.0 / System.Math.Pow(k, 2));
        }
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_SingleIteration()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 1;
        double result = ds.GetSumSeries(startValue, stopValue);

        // Для k=1: sin(1/1²) = sin(1) ≈ 0.841
        double expected = System.Math.Sin(1.0);
        expected = System.Math.Round(expected, 3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_RoundingTest()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(startValue, stopValue);

        // Проверяем, что результат округлен до 3 знаков
        string resultString = result.ToString("F10");
        int decimalPlaces = resultString.Length - resultString.IndexOf('.') - 1;
        Assert.IsTrue(decimalPlaces <= 3);
    }

    [TestMethod]
    public void ValidGetSumSeries_AllIterations()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;
        double result = ds.GetSumSeries(startValue, stopValue);

        // Проверяем, что результат не нулевой и не бесконечный
        Assert.IsFalse(double.IsNaN(result));
        Assert.IsFalse(double.IsInfinity(result));
        Assert.AreNotEqual(0, result);
    }

    [TestMethod]
    public void ValidGetSumSeries_DoWhileGuaranteedExecution()
    {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 1;
        double result = ds.GetSumSeries(startValue, stopValue);

        // Проверяем, что цикл do...while выполнился хотя бы один раз
        Assert.IsTrue(result > 0);
    }
}
