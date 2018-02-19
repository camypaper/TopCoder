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
    public void ManualTest(long N, long K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        long __result = new BallsInBoxes().maxTurns(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long N = 10L;
        Console.WriteLine("N:{0}", N);
        long K = 10L;
        Console.WriteLine("K:{0}", K);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BallsInBoxes().maxTurns(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long N = 100L;
        Console.WriteLine("N:{0}", N);
        long K = 1L;
        Console.WriteLine("K:{0}", K);
        long __expected = 99L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BallsInBoxes().maxTurns(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long N = 1000L;
        Console.WriteLine("N:{0}", N);
        long K = 999L;
        Console.WriteLine("K:{0}", K);
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BallsInBoxes().maxTurns(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long N = 10L;
        Console.WriteLine("N:{0}", N);
        long K = 5L;
        Console.WriteLine("K:{0}", K);
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BallsInBoxes().maxTurns(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
