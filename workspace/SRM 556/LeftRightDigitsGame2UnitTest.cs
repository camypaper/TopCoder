using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(string digits, string lowerBound)
    {
        Console.WriteLine("digits:{0}", digits);
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string digits = "565";
        Console.WriteLine("digits:{0}", digits);
        string lowerBound = "556";
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __expected = "556";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string digits = "565";
        Console.WriteLine("digits:{0}", digits);
        string lowerBound = "566";
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __expected = "655";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string digits = "565";
        Console.WriteLine("digits:{0}", digits);
        string lowerBound = "656";
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __expected = "";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string digits = "9876543210";
        Console.WriteLine("digits:{0}", digits);
        string lowerBound = "5565565565";
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __expected = "5678943210";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string digits = "8016352";
        Console.WriteLine("digits:{0}", digits);
        string lowerBound = "1000000";
        Console.WriteLine("lowerBound:{0}", lowerBound);
        string __expected = "1086352";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LeftRightDigitsGame2().minNumber(digits, lowerBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
