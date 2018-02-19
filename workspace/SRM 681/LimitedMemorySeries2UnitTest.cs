using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int n, long x0, long a, long b)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("x0:{0}", x0);
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        int __result = new LimitedMemorySeries2().getSum(n, x0, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        long x0 = 2L;
        Console.WriteLine("x0:{0}", x0);
        long a = 23L;
        Console.WriteLine("a:{0}", a);
        long b = 1L;
        Console.WriteLine("b:{0}", b);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LimitedMemorySeries2().getSum(n, x0, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 100;
        Console.WriteLine("n:{0}", n);
        long x0 = 0L;
        Console.WriteLine("x0:{0}", x0);
        long a = 0L;
        Console.WriteLine("a:{0}", a);
        long b = 1L;
        Console.WriteLine("b:{0}", b);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LimitedMemorySeries2().getSum(n, x0, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 234234;
        Console.WriteLine("n:{0}", n);
        long x0 = 1125899906842623L;
        Console.WriteLine("x0:{0}", x0);
        long a = 123456789123456L;
        Console.WriteLine("a:{0}", a);
        long b = 987654321549687L;
        Console.WriteLine("b:{0}", b);
        int __expected = 1144970;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LimitedMemorySeries2().getSum(n, x0, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 10000000;
        Console.WriteLine("n:{0}", n);
        long x0 = 12345678912345L;
        Console.WriteLine("x0:{0}", x0);
        long a = 98765094309812L;
        Console.WriteLine("a:{0}", a);
        long b = 34893049812392L;
        Console.WriteLine("b:{0}", b);
        int __expected = 65420804;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LimitedMemorySeries2().getSum(n, x0, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
