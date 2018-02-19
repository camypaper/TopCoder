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
    public void ManualTest(long G, long L)
    {
        Console.WriteLine("G:{0}", G);
        Console.WriteLine("L:{0}", L);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long G = 2L;
        Console.WriteLine("G:{0}", G);
        long L = 20L;
        Console.WriteLine("L:{0}", L);
        long __expected = 14L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long G = 5L;
        Console.WriteLine("G:{0}", G);
        long L = 8L;
        Console.WriteLine("L:{0}", L);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long G = 1000L;
        Console.WriteLine("G:{0}", G);
        long L = 100L;
        Console.WriteLine("L:{0}", L);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long G = 100L;
        Console.WriteLine("G:{0}", G);
        long L = 1000L;
        Console.WriteLine("L:{0}", L);
        long __expected = 700L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long G = 10L;
        Console.WriteLine("G:{0}", G);
        long L = 950863963000L;
        Console.WriteLine("L:{0}", L);
        long __expected = 6298430L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxAndGCDLCM().get(G, L);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
