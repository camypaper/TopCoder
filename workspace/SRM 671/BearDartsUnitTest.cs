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
    public void ManualTest(int[] w)
    {
        Console.WriteLine(string.Format("w:{0}", string.Join(" ",w)));
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] w = new int[] {
            6,
            8,
            4,
            3,
            6
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] w = new int[] {
            3,
            4,
            12,
            1
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] w = new int[] {
            42,
            1000000,
            1000000,
            42,
            1000000,
            1000000
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] w = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] w = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 22L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] w = new int[] {
            33554432,
            33554432,
            67108864,
            134217728
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearDarts().count(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
