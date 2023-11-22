// See https://aka.ms/new-console-template for more information

using Microsoft.VisualStudio.TestTools.UnitTesting;

string[] inputArray = { "this is a test", "foobar", "all your base" };
ReverseWords(3, inputArray);

ReverseTest reverseTest = new ReverseTest();
reverseTest.Order();

static void ReverseWords(int testCases, string[] strings)
{
    var reverser = new Reverser(new ReverseOrder(testCases, strings));
    reverser.Reverse();
}

public interface IReverseOrder
{
    public int _testCases { get; set; }
    public string[] _strings { get; set; }

    void ReverseWordOrder();
}

public class ReverseOrder : IReverseOrder
{
    public int _testCases { get; set; }
    public string[] _strings { get; set; }

    public ReverseOrder(int testCases, string[] strings)
    {
        _testCases = testCases;
        _strings = strings;
    }

    public int TestCases
    {
        get { return _testCases; }
    }

    public string[] Strings
    {
        get { return _strings; }
    }

    public void ReverseWordOrder()
    {
        if (TestCases != Strings.Length)
        {
            throw new Exception("testCases must be equal to the length of strings");
        }

        for (int i = 0; i < TestCases; i++)
        {
            string[] arrWords = Strings[i].Split(' ');
            Array.Reverse(arrWords);
            Console.WriteLine("Case " + (i + 1) + ": " + string.Join(" ", arrWords));
            Strings[i] = "Case " + (i + 1) + ": " + string.Join(" ", arrWords);
        }
    }
}

public class Reverser
{
    public readonly IReverseOrder _reverseOrder;

    public Reverser(IReverseOrder reverseOrder)
    {
        _reverseOrder = reverseOrder;
    }

    public void Reverse()
    {
        _reverseOrder.ReverseWordOrder();
    }
}

[TestClass]
public class ReverseTest
{
    [TestMethod]
    public void Order()
    {
        // Arrange
        string[] expected = { "Case 1: test a is this", "Case 2: foobar", "Case 3: base your all" };
        string[] inputArray = { "this is a test", "foobar", "all your base" };
        var reverser = new Reverser(new ReverseOrder(3, inputArray));

        // Act
        reverser.Reverse();

        // Assert
        Assert.AreEqual(expected[0], reverser._reverseOrder._strings[0]);
        Assert.AreEqual(expected[1], reverser._reverseOrder._strings[1]);
        Assert.AreEqual(expected[2], reverser._reverseOrder._strings[2]);
    }
}