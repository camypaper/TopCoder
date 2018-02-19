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
    public void ManualTest(int N, int M)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 2;
        Console.WriteLine("M:{0}", M);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int M = 5;
        Console.WriteLine("M:{0}", M);
        int __expected = 74;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 7;
        Console.WriteLine("N:{0}", N);
        int M = 4;
        Console.WriteLine("M:{0}", M);
        int __expected = 216;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 47;
        Console.WriteLine("N:{0}", N);
        int M = 74;
        Console.WriteLine("M:{0}", M);
        int __expected = 962557390;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndSnowmen().getNumber(N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
