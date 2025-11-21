namespace Tyuiu.FilevaPA.Sprint3.Task7.V30.Test;
using Tyuiu.FilevaPA.Sprint3.Task7.V30.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        double[] result = ds.GetMassFunction(startValue, stopValue);

        // Проверка длины массива
        Assert.AreEqual(11, result.Length);

        // Проверка конкретных значений
        Assert.AreEqual(-10.96, result[0]);  // x = -5
        Assert.AreEqual(-7.60, result[1]);   // x = -4
        Assert.AreEqual(-4.61, result[2]);   // x = -3
        Assert.AreEqual(-2.17, result[3]);   // x = -2
        Assert.AreEqual(0.17, result[4]);    // x = -1
        Assert.AreEqual(3.25, result[5]);    // x = 0
        Assert.AreEqual(5.97, result[6]);    // x = 1
        Assert.AreEqual(8.32, result[7]);    // x = 2
        Assert.AreEqual(10.68, result[8]);   // x = 3
        Assert.AreEqual(13.40, result[9]);   // x = 4
        Assert.AreEqual(16.96, result[10]);  // x = 5
    }
}
