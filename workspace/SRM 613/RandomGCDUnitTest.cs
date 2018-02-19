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
    public void ManualTest(int N, int K, int low, int high)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("low:{0}", low);
        Console.WriteLine("high:{0}", high);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int low = 2;
        Console.WriteLine("low:{0}", low);
        int high = 4;
        Console.WriteLine("high:{0}", high);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 100;
        Console.WriteLine("K:{0}", K);
        int low = 2;
        Console.WriteLine("low:{0}", low);
        int high = 4;
        Console.WriteLine("high:{0}", high);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int K = 5;
        Console.WriteLine("K:{0}", K);
        int low = 5;
        Console.WriteLine("low:{0}", low);
        int high = 5;
        Console.WriteLine("high:{0}", high);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 73824;
        Console.WriteLine("N:{0}", N);
        int K = 17347;
        Console.WriteLine("K:{0}", K);
        int low = 9293482;
        Console.WriteLine("low:{0}", low);
        int high = 9313482;
        Console.WriteLine("high:{0}", high);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 222;
        Console.WriteLine("N:{0}", N);
        int K = 222;
        Console.WriteLine("K:{0}", K);
        int low = 222;
        Console.WriteLine("low:{0}", low);
        int high = 22222;
        Console.WriteLine("high:{0}", high);
        int __expected = 339886855;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RandomGCD().countTuples(N, K, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
