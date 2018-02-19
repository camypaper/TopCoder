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
    public void ManualTest(int H, int W, int S)
    {
        Console.WriteLine("H:{0}", H);
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("S:{0}", S);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int H = 2;
        Console.WriteLine("H:{0}", H);
        int W = 2;
        Console.WriteLine("W:{0}", W);
        int S = 1;
        Console.WriteLine("S:{0}", S);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int H = 2;
        Console.WriteLine("H:{0}", H);
        int W = 2;
        Console.WriteLine("W:{0}", W);
        int S = 2;
        Console.WriteLine("S:{0}", S);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int H = 2;
        Console.WriteLine("H:{0}", H);
        int W = 2;
        Console.WriteLine("W:{0}", W);
        int S = 0;
        Console.WriteLine("S:{0}", S);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int H = 47;
        Console.WriteLine("H:{0}", H);
        int W = 58;
        Console.WriteLine("W:{0}", W);
        int S = 100;
        Console.WriteLine("S:{0}", S);
        int __expected = 1301;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int H = 1234;
        Console.WriteLine("H:{0}", H);
        int W = 2345;
        Console.WriteLine("W:{0}", W);
        int S = 97;
        Console.WriteLine("S:{0}", S);
        int __expected = 8894;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGreed().count(H, W, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
