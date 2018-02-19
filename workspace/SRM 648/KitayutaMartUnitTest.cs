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
    public void ManualTest(int N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 1000000000;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 570312504;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 987654321;
        Console.WriteLine("N:{0}", N);
        int K = 876543210;
        Console.WriteLine("K:{0}", K);
        int __expected = 493827168;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KitayutaMart().lastPrice(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
