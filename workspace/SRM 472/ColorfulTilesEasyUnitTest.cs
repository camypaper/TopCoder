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
    public void ManualTest(string room)
    {
        Console.WriteLine("room:{0}", room);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string room = "RRRRRR";
        Console.WriteLine("room:{0}", room);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string room = "GGGGGGG";
        Console.WriteLine("room:{0}", room);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string room = "BBBYYYYYY";
        Console.WriteLine("room:{0}", room);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string room = "BRYGYBGRYR";
        Console.WriteLine("room:{0}", room);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string room = "RGGBBBRYYB";
        Console.WriteLine("room:{0}", room);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulTilesEasy().theMin(room);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
