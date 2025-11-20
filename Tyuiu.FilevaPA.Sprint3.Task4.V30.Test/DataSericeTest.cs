namespace Tyuiu.FilevaPA.Sprint3.Task4.V30.Test;
    using Tyuiu.FilevaPA.Sprint3.Task4.V30.Lib;

    [TestClass]
    public sealed class DataSericeTest
    {
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
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
}
