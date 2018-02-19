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
    public void ManualTest(int W, int H, long M)
    {
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("H:{0}", H);
        Console.WriteLine("M:{0}", M);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int W = 3;
        Console.WriteLine("W:{0}", W);
        int H = 5;
        Console.WriteLine("H:{0}", H);
        long M = 14L;
        Console.WriteLine("M:{0}", M);
        long __expected = 12L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int W = 4;
        Console.WriteLine("W:{0}", W);
        int H = 4;
        Console.WriteLine("H:{0}", H);
        long M = 10L;
        Console.WriteLine("M:{0}", M);
        long __expected = 9L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int W = 1000000;
        Console.WriteLine("W:{0}", W);
        int H = 12345;
        Console.WriteLine("H:{0}", H);
        long M = 1000000000000L;
        Console.WriteLine("M:{0}", M);
        long __expected = 12345000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int W = 1000000;
        Console.WriteLine("W:{0}", W);
        int H = 1000000;
        Console.WriteLine("H:{0}", H);
        long M = 720000000007L;
        Console.WriteLine("M:{0}", M);
        long __expected = 720000000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int W = 1000000;
        Console.WriteLine("W:{0}", W);
        int H = 1000000;
        Console.WriteLine("H:{0}", H);
        long M = 999999999999L;
        Console.WriteLine("M:{0}", M);
        long __expected = 999999000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearPaints().maxArea(W, H, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
