namespace tests;

[TestClass]
public class Processor2Test : code.Processor2
{
    [TestMethod]
    public void ExampleTest()
    {
        string input = @"10 13 16 21 30 45";

        long expected = 5;
        var actual = code.Processor2.Process(code.InputHandler.ReadInputLines(input));
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ExampleTest2()
    {
        string input = File.ReadAllText("input9test.txt");

        long expected = 2;
        var actual = code.Processor2.Process(code.InputHandler.ReadInputLines(input));
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]    
    public void GetQuestion1AnswerTest()
    {
        string input = File.ReadAllText("input9.txt");

        long expected = 0;
        var actual = code.Processor2.Process(code.InputHandler.ReadInputLines(input));
        Assert.AreEqual(expected, actual);
    }
}
