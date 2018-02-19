using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int W, int H, int MOD)
    {
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("H:{0}", H);
        Console.WriteLine("MOD:{0}", MOD);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int W = 4;
        Console.WriteLine("W:{0}", W);
        int H = 3;
        Console.WriteLine("H:{0}", H);
        int MOD = 999999937;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 24064;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int W = 3;
        Console.WriteLine("W:{0}", W);
        int H = 4;
        Console.WriteLine("H:{0}", H);
        int MOD = 999999937;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 24576;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int W = 2;
        Console.WriteLine("W:{0}", W);
        int H = 20;
        Console.WriteLine("H:{0}", H);
        int MOD = 584794877;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 190795689;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int W = 5;
        Console.WriteLine("W:{0}", W);
        int H = 10;
        Console.WriteLine("H:{0}", H);
        int MOD = 3;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int W = 1;
        Console.WriteLine("W:{0}", W);
        int H = 1;
        Console.WriteLine("H:{0}", H);
        int MOD = 19;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int W = 7;
        Console.WriteLine("W:{0}", W);
        int H = 40;
        Console.WriteLine("H:{0}", H);
        int MOD = 312880987;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 256117818;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearDestroysDiv2().sumUp(W, H, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
