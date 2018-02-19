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
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            ".",
            ".X",
            "X..",
            ".X.X"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "X"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            ".",
            "..",
            "...",
            ".X.."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 20160;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            ".",
            "..",
            "XXX",
            "..X.",
            ".X..X",
            "XXXX..",
            "..X.X.X",
            "..X.XX.."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 108;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            ".",
            "..",
            "...",
            "....",
            ".....",
            "......",
            ".......",
            "........"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 261547992;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HexagonPuzzle().theCount(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
