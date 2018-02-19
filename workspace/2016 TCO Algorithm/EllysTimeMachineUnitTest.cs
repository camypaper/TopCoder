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
    public void ManualTest(string time)
    {
        Console.WriteLine("time:{0}", time);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string time = "11:20";
        Console.WriteLine("time:{0}", time);
        string __expected = "04:55";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string time = "02:25";
        Console.WriteLine("time:{0}", time);
        string __expected = "05:10";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string time = "06:30";
        Console.WriteLine("time:{0}", time);
        string __expected = "06:30";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string time = "05:55";
        Console.WriteLine("time:{0}", time);
        string __expected = "11:25";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string time = "03:45";
        Console.WriteLine("time:{0}", time);
        string __expected = "09:15";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string time = "01:00";
        Console.WriteLine("time:{0}", time);
        string __expected = "12:05";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EllysTimeMachine().getTime(time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
