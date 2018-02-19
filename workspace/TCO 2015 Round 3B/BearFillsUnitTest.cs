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
    public void ManualTest(int N, long W, long H)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("W:{0}", W);
        Console.WriteLine("H:{0}", H);
        long __result = new BearFills().countSets(N, W, H);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        long W = 1L;
        Console.WriteLine("W:{0}", W);
        long H = 3L;
        Console.WriteLine("H:{0}", H);
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearFills().countSets(N, W, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        long W = 3L;
        Console.WriteLine("W:{0}", W);
        long H = 5L;
        Console.WriteLine("H:{0}", H);
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearFills().countSets(N, W, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 60;
        Console.WriteLine("N:{0}", N);
        long W = 3L;
        Console.WriteLine("W:{0}", W);
        long H = 2L;
        Console.WriteLine("H:{0}", H);
        long __expected = 1152921504606846972L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearFills().countSets(N, W, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        long W = 5L;
        Console.WriteLine("W:{0}", W);
        long H = 4L;
        Console.WriteLine("H:{0}", H);
        long __expected = 56L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearFills().countSets(N, W, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
