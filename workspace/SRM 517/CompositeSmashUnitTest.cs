using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int N, int target)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("target:{0}", target);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 517;
        Console.WriteLine("N:{0}", N);
        int target = 47;
        Console.WriteLine("target:{0}", target);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int target = 4;
        Console.WriteLine("target:{0}", target);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 12;
        Console.WriteLine("N:{0}", N);
        int target = 6;
        Console.WriteLine("target:{0}", target);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int target = 8;
        Console.WriteLine("target:{0}", target);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int target = 100000;
        Console.WriteLine("target:{0}", target);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 5858;
        Console.WriteLine("N:{0}", N);
        int target = 2;
        Console.WriteLine("target:{0}", target);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int N = 81461;
        Console.WriteLine("N:{0}", N);
        int target = 2809;
        Console.WriteLine("target:{0}", target);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int N = 65536;
        Console.WriteLine("N:{0}", N);
        int target = 256;
        Console.WriteLine("target:{0}", target);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CompositeSmash().thePossible(N, target);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
