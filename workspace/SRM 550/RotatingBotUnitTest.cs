using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int[] moves)
    {
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ",moves)));
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] moves = new int[] {
            15
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] moves = new int[] {
            3,
            10
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 44;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] moves = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] moves = new int[] {
            9,
            5,
            11,
            10,
            11,
            4,
            10
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 132;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] moves = new int[] {
            12,
            1,
            27,
            14,
            27,
            12,
            26,
            11,
            25,
            10,
            24,
            9,
            23,
            8,
            22,
            7,
            21,
            6,
            20,
            5,
            19,
            4,
            18,
            3,
            17,
            2,
            16,
            1,
            15
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 420;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] moves = new int[] {
            8,
            6,
            6,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] moves = new int[] {
            8,
            6,
            6
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 63;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] moves = new int[] {
            5,
            4,
            5,
            3,
            3
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 30;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RotatingBot().minArea(moves);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
