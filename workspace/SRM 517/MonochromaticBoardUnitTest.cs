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
    public void ManualTest(string[] board)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "WBWBW",
            "BBBBB",
            "WBWBW",
            "WBWBW"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "BBBB",
            "BBBB",
            "BBBB"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "BBBBB",
            "BBBBB",
            "BBBBB",
            "BBBBB",
            "BBBBB",
            "BBBBB",
            "BBBBB",
            "BBBBB"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "WW",
            "WW"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "BBBBBBBB",
            "BBBBBBBB",
            "BBBBBBBB",
            "WBWBBBWB",
            "BBBBBBBB"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MonochromaticBoard().theMin(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
