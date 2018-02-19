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
    public void ManualTest(int N, int L)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("L:{0}", L);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int L = 10;
        Console.WriteLine("L:{0}", L);
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int L = 1;
        Console.WriteLine("L:{0}", L);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int L = 41;
        Console.WriteLine("L:{0}", L);
        int __expected = 655468587;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 200;
        Console.WriteLine("N:{0}", N);
        int L = 200;
        Console.WriteLine("L:{0}", L);
        int __expected = 152699064;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LineMST().count(N, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
