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
    public void ManualTest(string message)
    {
        Console.WriteLine("message:{0}", message);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string message = ";_;;_____;";
        Console.WriteLine("message:{0}", message);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string message = ";;;___;;;";
        Console.WriteLine("message:{0}", message);
        int __expected = 36;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string message = "_;__;";
        Console.WriteLine("message:{0}", message);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string message = ";_____________________________________;";
        Console.WriteLine("message:{0}", message);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string message = ";__;____;";
        Console.WriteLine("message:{0}", message);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string message = ";_;;__;_;;";
        Console.WriteLine("message:{0}", message);
        int __expected = 52;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCries().count(message);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
