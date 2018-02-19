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
    public void ManualTest(int N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new AlienAndSetDiv1().getNumber(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlienAndSetDiv1().getNumber(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlienAndSetDiv1().getNumber(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 14;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlienAndSetDiv1().getNumber(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int K = 7;
        Console.WriteLine("K:{0}", K);
        int __expected = 40;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AlienAndSetDiv1().getNumber(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
