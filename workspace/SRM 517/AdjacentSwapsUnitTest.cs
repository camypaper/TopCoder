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
    public void ManualTest(int[] p)
    {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] p = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] p = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] p = new int[] {
            2,
            0,
            3,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] p = new int[] {
            1,
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] p = new int[] {
            1,
            3,
            0,
            5,
            2,
            7,
            4,
            8,
            10,
            6,
            12,
            9,
            14,
            11,
            16,
            13,
            18,
            15,
            19,
            17
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 716743312;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AdjacentSwaps().theCount(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
