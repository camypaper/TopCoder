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
    public void ManualTest(int sx, int sy, int gx, int gy)
    {
        Console.WriteLine("sx:{0}", sx);
        Console.WriteLine("sy:{0}", sy);
        Console.WriteLine("gx:{0}", gx);
        Console.WriteLine("gy:{0}", gy);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int sx = 1;
        Console.WriteLine("sx:{0}", sx);
        int sy = 0;
        Console.WriteLine("sy:{0}", sy);
        int gx = 1;
        Console.WriteLine("gx:{0}", gx);
        int gy = 9;
        Console.WriteLine("gy:{0}", gy);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int sx = 0;
        Console.WriteLine("sx:{0}", sx);
        int sy = 0;
        Console.WriteLine("sy:{0}", sy);
        int gx = -4;
        Console.WriteLine("gx:{0}", gx);
        int gy = 3;
        Console.WriteLine("gy:{0}", gy);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int sx = 0;
        Console.WriteLine("sx:{0}", sx);
        int sy = 0;
        Console.WriteLine("sy:{0}", sy);
        int gx = 5;
        Console.WriteLine("gx:{0}", gx);
        int gy = 8;
        Console.WriteLine("gy:{0}", gy);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int sx = -487617;
        Console.WriteLine("sx:{0}", sx);
        int sy = 826524;
        Console.WriteLine("sy:{0}", sy);
        int gx = 892309;
        Console.WriteLine("gx:{0}", gx);
        int gy = -918045;
        Console.WriteLine("gy:{0}", gy);
        int __expected = 1744571;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int sx = -27857;
        Console.WriteLine("sx:{0}", sx);
        int sy = 31475;
        Console.WriteLine("sy:{0}", sy);
        int gx = -27857;
        Console.WriteLine("gx:{0}", gx);
        int gy = 31475;
        Console.WriteLine("gy:{0}", gy);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SilverDistance().minSteps(sx, sy, gx, gy);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
