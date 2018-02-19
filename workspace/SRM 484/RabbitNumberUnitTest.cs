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
    public void ManualTest(int low, int high)
    {
        Console.WriteLine("low:{0}", low);
        Console.WriteLine("high:{0}", high);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int low = 22;
        Console.WriteLine("low:{0}", low);
        int high = 22;
        Console.WriteLine("high:{0}", high);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int low = 484;
        Console.WriteLine("low:{0}", low);
        int high = 484;
        Console.WriteLine("high:{0}", high);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int low = 1;
        Console.WriteLine("low:{0}", low);
        int high = 58;
        Console.WriteLine("high:{0}", high);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int low = 58;
        Console.WriteLine("low:{0}", low);
        int high = 484;
        Console.WriteLine("high:{0}", high);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int low = 1000000000;
        Console.WriteLine("low:{0}", low);
        int high = 1000000000;
        Console.WriteLine("high:{0}", high);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RabbitNumber().theCount(low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
