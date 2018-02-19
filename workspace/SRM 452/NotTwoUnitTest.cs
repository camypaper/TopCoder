using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);    }
    public void ManualTest(int width, int height)
    {
        Console.WriteLine("width:{0}", width);
        Console.WriteLine("height:{0}", height);
        int __result = new NotTwo().maxStones(width, height);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int width = 3;
        Console.WriteLine("width:{0}", width);
        int height = 2;
        Console.WriteLine("height:{0}", height);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NotTwo().maxStones(width, height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int width = 3;
        Console.WriteLine("width:{0}", width);
        int height = 3;
        Console.WriteLine("height:{0}", height);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NotTwo().maxStones(width, height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int width = 8;
        Console.WriteLine("width:{0}", width);
        int height = 5;
        Console.WriteLine("height:{0}", height);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NotTwo().maxStones(width, height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
