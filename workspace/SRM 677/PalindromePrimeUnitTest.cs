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
    public void ManualTest(int L, int R)
    {
        Console.WriteLine("L:{0}", L);
        Console.WriteLine("R:{0}", R);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int L = 100;
        Console.WriteLine("L:{0}", L);
        int R = 150;
        Console.WriteLine("R:{0}", R);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int L = 1;
        Console.WriteLine("L:{0}", L);
        int R = 9;
        Console.WriteLine("R:{0}", R);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int L = 929;
        Console.WriteLine("L:{0}", L);
        int R = 929;
        Console.WriteLine("R:{0}", R);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int L = 1;
        Console.WriteLine("L:{0}", L);
        int R = 1;
        Console.WriteLine("R:{0}", R);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int L = 1;
        Console.WriteLine("L:{0}", L);
        int R = 1000;
        Console.WriteLine("R:{0}", R);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePrime().count(L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
