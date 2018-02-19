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
    public void ManualTest(long N, long K, int M)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("M:{0}", M);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long N = 3L;
        Console.WriteLine("N:{0}", N);
        long K = 2L;
        Console.WriteLine("K:{0}", K);
        int M = 100000;
        Console.WriteLine("M:{0}", M);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long N = 15L;
        Console.WriteLine("N:{0}", N);
        long K = 3L;
        Console.WriteLine("K:{0}", K);
        int M = 1000000;
        Console.WriteLine("M:{0}", M);
        int __expected = 510625;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long N = 100000L;
        Console.WriteLine("N:{0}", N);
        long K = 100000L;
        Console.WriteLine("K:{0}", K);
        int M = 999999;
        Console.WriteLine("M:{0}", M);
        int __expected = 185185;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long N = 1000000000000L;
        Console.WriteLine("N:{0}", N);
        long K = 6L;
        Console.WriteLine("K:{0}", K);
        int M = 1000000;
        Console.WriteLine("M:{0}", M);
        int __expected = 109376;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long N = 5000L;
        Console.WriteLine("N:{0}", N);
        long K = 1000000000000L;
        Console.WriteLine("K:{0}", K);
        int M = 314159;
        Console.WriteLine("M:{0}", M);
        int __expected = 202996;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulLineGraphs().countWays(N, K, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
