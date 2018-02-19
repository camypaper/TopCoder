using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int x, int y)
    {
        Console.WriteLine("x:{0}", x);
        Console.WriteLine("y:{0}", y);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int x = 1;
        Console.WriteLine("x:{0}", x);
        int y = 3;
        Console.WriteLine("y:{0}", y);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int x = 0;
        Console.WriteLine("x:{0}", x);
        int y = 2;
        Console.WriteLine("y:{0}", y);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int x = 1;
        Console.WriteLine("x:{0}", x);
        int y = 9;
        Console.WriteLine("y:{0}", y);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int x = 3;
        Console.WriteLine("x:{0}", x);
        int y = 0;
        Console.WriteLine("y:{0}", y);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int x = 1;
        Console.WriteLine("x:{0}", x);
        int y = 1;
        Console.WriteLine("y:{0}", y);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int x = -6890;
        Console.WriteLine("x:{0}", x);
        int y = 18252;
        Console.WriteLine("y:{0}", y);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int x = 1000000000;
        Console.WriteLine("x:{0}", x);
        int y = -1000000000;
        Console.WriteLine("y:{0}", y);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int x = 0;
        Console.WriteLine("x:{0}", x);
        int y = 0;
        Console.WriteLine("y:{0}", y);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new PowerOfThree().ableToGet(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
