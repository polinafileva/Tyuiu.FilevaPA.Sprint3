namespace Tyuiu.FilevaPA.Sprint3.Task5.V10.Test;
using Tyuiu.FilevaPA.Sprint3.Task5.V10.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSumSeries_X5_I1to3_K1to10()
    {
        DataService ds = new DataService();
        int x = 5;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 10;
        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        // Ручной расчет: x³ = 125
        // Для каждого k от 1 до 10: (125 * k) + 2
        // Сумма для одного i: (125*1+2) + (125*2+2) + ... + (125*10+2) = 125*(1+2+...+10) + 2*10
        // 1+2+...+10 = 55, поэтому: 125*55 + 20 = 6875 + 20 = 6895
        // Для i от 1 до 3: 3 * 6895 = 20685

        double expected = 20685;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSumSeries_X2_I1to2_K1to5()
    {
        DataService ds = new DataService();
        int x = 2;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 2;
        int stopValue2 = 5;
        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        // x³ = 8
        // Сумма k от 1 до 5 = 15
        // Сумма для одного i: 8*15 + 2*5 = 120 + 10 = 130
        // Для i от 1 до 2: 2 * 130 = 260

        double expected = 260;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSumSeries_X1_I1to1_K1to3()
    {
        DataService ds = new DataService();
        int x = 1;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 1;
        int stopValue2 = 3;
        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        // x³ = 1
        // Сумма k от 1 до 3 = 6
        // Сумма: 1*6 + 2*3 = 6 + 6 = 12

        double expected = 12;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSumSeries_X0_I1to4_K1to2()
    {
        DataService ds = new DataService();
        int x = 0;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 4;
        int stopValue2 = 2;
        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        // x³ = 0
        // Сумма k от 1 до 2 = 3
        // Сумма для одного i: 0*3 + 2*2 = 4
        // Для i от 1 до 4: 4 * 4 = 16

        double expected = 16;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidGetSumSumSeries_DifferentRanges()
    {
        DataService ds = new DataService();
        int x = 3;
        int startValue1 = 2;
        int startValue2 = 3;
        int stopValue1 = 4;
        int stopValue2 = 6;
        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        // x³ = 27
        // Сумма k от 3 до 6 = 3+4+5+6 = 18
        // Сумма для одного i: 27*18 + 2*4 = 486 + 8 = 494
        // Для i от 2 до 4: 3 * 494 = 1482

        double expected = 1482;
        Assert.AreEqual(expected, result);
    }
}