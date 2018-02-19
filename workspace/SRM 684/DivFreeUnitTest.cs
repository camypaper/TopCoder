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
    public void ManualTest(int n, int k)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("k:{0}", k);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int k = 107;
        Console.WriteLine("k:{0}", k);
        int __expected = 107;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int k = 6;
        Console.WriteLine("k:{0}", k);
        int __expected = 2292;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 42;
        Console.WriteLine("n:{0}", n);
        int k = 23;
        Console.WriteLine("k:{0}", k);
        int __expected = 301026516;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DivFree().dfcount(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
