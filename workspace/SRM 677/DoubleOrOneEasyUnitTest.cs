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
    public void ManualTest(int a, int b, int newA, int newB)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("newA:{0}", newA);
        Console.WriteLine("newB:{0}", newB);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int a = 100;
        Console.WriteLine("a:{0}", a);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int newA = 101;
        Console.WriteLine("newA:{0}", newA);
        int newB = 1001;
        Console.WriteLine("newB:{0}", newB);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int a = 100;
        Console.WriteLine("a:{0}", a);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int newA = 202;
        Console.WriteLine("newA:{0}", newA);
        int newB = 2002;
        Console.WriteLine("newB:{0}", newB);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int a = 2;
        Console.WriteLine("a:{0}", a);
        int b = 2;
        Console.WriteLine("b:{0}", b);
        int newA = 1;
        Console.WriteLine("newA:{0}", newA);
        int newB = 1;
        Console.WriteLine("newB:{0}", newB);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 111111111;
        Console.WriteLine("b:{0}", b);
        int newA = 8;
        Console.WriteLine("newA:{0}", newA);
        int newB = 888888888;
        Console.WriteLine("newB:{0}", newB);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 111111111;
        Console.WriteLine("b:{0}", b);
        int newA = 9;
        Console.WriteLine("newA:{0}", newA);
        int newB = 999999999;
        Console.WriteLine("newB:{0}", newB);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleOrOneEasy().minimalSteps(a, b, newA, newB);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
