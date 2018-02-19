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
    public void ManualTest(long N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long N = 6L;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long N = 8L;
        Console.WriteLine("N:{0}", N);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long N = 10L;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 45;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long N = 63L;
        Console.WriteLine("N:{0}", N);
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long N = 1000000000000000L;
        Console.WriteLine("N:{0}", N);
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int __expected = 429388700;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingTournament().howManyWays(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
