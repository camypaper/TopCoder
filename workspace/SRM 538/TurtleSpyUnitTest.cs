using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);    }
    public void ManualTest(string[] commands)
    {
        Console.WriteLine(string.Format("commands:{0}", string.Join(" ",commands)));
        double __result = new TurtleSpy().maxDistance(commands);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] commands = new string[] {
            "forward 100",
            "backward 100",
            "left 90"
        };
        Console.WriteLine(string.Format("commands:{0}", string.Join(" ", commands)));
        double __expected = 141.4213562373095;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TurtleSpy().maxDistance(commands);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        string[] commands = new string[] {
            "left 45",
            "forward 100",
            "right 45",
            "forward 100"
        };
        Console.WriteLine(string.Format("commands:{0}", string.Join(" ", commands)));
        double __expected = 200.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TurtleSpy().maxDistance(commands);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        string[] commands = new string[] {
            "left 10",
            "forward 40",
            "right 30",
            "left 10",
            "backward 4",
            "forward 4"
        };
        Console.WriteLine(string.Format("commands:{0}", string.Join(" ", commands)));
        double __expected = 40.58520737741619;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new TurtleSpy().maxDistance(commands);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
