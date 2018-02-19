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
    public void ManualTest(int L, int N)
    {
        Console.WriteLine("L:{0}", L);
        Console.WriteLine("N:{0}", N);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int __expected = 28;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int N = 58;
        Console.WriteLine("N:{0}", N);
        int __expected = 868294620;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int L = 4;
        Console.WriteLine("L:{0}", L);
        int N = 84;
        Console.WriteLine("N:{0}", N);
        int __expected = 621871151;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int L = 5;
        Console.WriteLine("L:{0}", L);
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PuyoPuyo().theCount(L, N);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
