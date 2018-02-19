using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(string S)
    {
        Console.WriteLine("S:{0}", S);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "MAZAIMAZAI";
        Console.WriteLine("S:{0}", S);
        string __expected = "square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = "MAMAZAIZAI";
        Console.WriteLine("S:{0}", S);
        string __expected = "not square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "IOI";
        Console.WriteLine("S:{0}", S);
        string __expected = "not square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "AA";
        Console.WriteLine("S:{0}", S);
        string __expected = "square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string S = "ABCCBA";
        Console.WriteLine("S:{0}", S);
        string __expected = "not square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string S = "Y";
        Console.WriteLine("S:{0}", S);
        string __expected = "not square";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DoubleString().check(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
