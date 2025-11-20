namespace Tyuiu.FilevaPA.Sprint3.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint3.Task3.V10.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidDeleteCharInString_RemoveP()
    {
        DataService ds = new DataService();
        string value = "gdfppf vfppt p";
        char item = 'p';
        string result = ds.DeleteCharInString(value, item);

        string expected = "gdff vft ";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_RemoveSpace()
    {
        DataService ds = new DataService();
        string value = "gdfppf vfppt p";
        char item = ' ';
        string result = ds.DeleteCharInString(value, item);

        string expected = "gdfppfvfpptp";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_RemoveF()
    {
        DataService ds = new DataService();
        string value = "gdfppf vfppt p";
        char item = 'f';
        string result = ds.DeleteCharInString(value, item);

        string expected = "gdpp vppt p";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_EmptyString()
    {
        DataService ds = new DataService();
        string value = "";
        char item = 'p';
        string result = ds.DeleteCharInString(value, item);

        string expected = "";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_NoTargetChar()
    {
        DataService ds = new DataService();
        string value = "hello world";
        char item = 'p';
        string result = ds.DeleteCharInString(value, item);

        string expected = "hello world";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_AllTargetChars()
    {
        DataService ds = new DataService();
        string value = "ppppp";
        char item = 'p';
        string result = ds.DeleteCharInString(value, item);

        string expected = "";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidDeleteCharInString_CaseSensitive()
    {
        DataService ds = new DataService();
        string value = "PpPpP";
        char item = 'p';
        string result = ds.DeleteCharInString(value, item);

        string expected = "PP"; // Удалились только строчные 'p'
        Assert.AreEqual(expected, result);
    }
}
