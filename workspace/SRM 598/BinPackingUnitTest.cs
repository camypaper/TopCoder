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
    public void ManualTest(int[] item)
    {
        Console.WriteLine(string.Format("item:{0}", string.Join(" ",item)));
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] item = new int[] {
            150,
            150,
            150,
            150,
            150
        };
        Console.WriteLine(string.Format("item:{0}", string.Join(" ", item)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] item = new int[] {
            130,
            140,
            150,
            160
        };
        Console.WriteLine(string.Format("item:{0}", string.Join(" ", item)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] item = new int[] {
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100
        };
        Console.WriteLine(string.Format("item:{0}", string.Join(" ", item)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] item = new int[] {
            100,
            200,
            100,
            100,
            100,
            100,
            200,
            100,
            200
        };
        Console.WriteLine(string.Format("item:{0}", string.Join(" ", item)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] item = new int[] {
            157,
            142,
            167,
            133,
            135,
            157,
            143,
            160,
            141,
            123,
            162,
            159,
            165,
            137,
            138,
            152
        };
        Console.WriteLine(string.Format("item:{0}", string.Join(" ", item)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BinPacking().minBins(item);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
