using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int n, int h0, int hn, string history)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("h0:{0}", h0);
        Console.WriteLine("hn:{0}", hn);
        Console.WriteLine("history:{0}", history);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int h0 = 0;
        Console.WriteLine("h0:{0}", h0);
        int hn = 4;
        Console.WriteLine("hn:{0}", hn);
        string history = "UU";
        Console.WriteLine("history:{0}", history);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int h0 = 0;
        Console.WriteLine("h0:{0}", h0);
        int hn = 4;
        Console.WriteLine("hn:{0}", hn);
        string history = "D";
        Console.WriteLine("history:{0}", history);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int h0 = 100000;
        Console.WriteLine("h0:{0}", h0);
        int hn = 100000;
        Console.WriteLine("hn:{0}", hn);
        string history = "DDU";
        Console.WriteLine("history:{0}", history);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int h0 = 0;
        Console.WriteLine("h0:{0}", h0);
        int hn = 0;
        Console.WriteLine("hn:{0}", hn);
        string history = "DDU";
        Console.WriteLine("history:{0}", history);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 20;
        Console.WriteLine("n:{0}", n);
        int h0 = 20;
        Console.WriteLine("h0:{0}", h0);
        int hn = 20;
        Console.WriteLine("hn:{0}", hn);
        string history = "UDUDUDUDUD";
        Console.WriteLine("history:{0}", history);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 20;
        Console.WriteLine("n:{0}", n);
        int h0 = 0;
        Console.WriteLine("h0:{0}", h0);
        int hn = 0;
        Console.WriteLine("hn:{0}", hn);
        string history = "UUUUUUUUUU";
        Console.WriteLine("history:{0}", history);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int n = 20;
        Console.WriteLine("n:{0}", n);
        int h0 = 0;
        Console.WriteLine("h0:{0}", h0);
        int hn = 0;
        Console.WriteLine("hn:{0}", hn);
        string history = "UUUUUUUUUUU";
        Console.WriteLine("history:{0}", history);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAndMountainEasy().possible(n, h0, hn, history);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
