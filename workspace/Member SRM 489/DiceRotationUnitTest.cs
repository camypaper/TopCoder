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
    public void ManualTest(int goalx, int goaly)
    {
        Console.WriteLine("goalx:{0}", goalx);
        Console.WriteLine("goaly:{0}", goaly);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int goalx = 2;
        Console.WriteLine("goalx:{0}", goalx);
        int goaly = 2;
        Console.WriteLine("goaly:{0}", goaly);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int goalx = 5;
        Console.WriteLine("goalx:{0}", goalx);
        int goaly = 8;
        Console.WriteLine("goaly:{0}", goaly);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int goalx = 47;
        Console.WriteLine("goalx:{0}", goalx);
        int goaly = 58;
        Console.WriteLine("goaly:{0}", goaly);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int goalx = 489;
        Console.WriteLine("goalx:{0}", goalx);
        int goaly = 489;
        Console.WriteLine("goaly:{0}", goaly);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int goalx = 1000000000;
        Console.WriteLine("goalx:{0}", goalx);
        int goaly = 1000000000;
        Console.WriteLine("goaly:{0}", goaly);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DiceRotation().theCount(goalx, goaly);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
