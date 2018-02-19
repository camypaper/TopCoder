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
    public void ManualTest(string[] board, int k)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        Console.WriteLine("k:{0}", k);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "....."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            ".#.#",
            "#.#.",
            ".#.#",
            "#.#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "##.",
            "...",
            ".##"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "....",
            "....",
            "....",
            "...."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = 113;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            ".....#....",
            ".#........",
            "....#.##..",
            "#......#..",
            "....#.....",
            "..........",
            ".##....#..",
            "..##......",
            "........##",
            "......#.#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int k = 8;
        Console.WriteLine("k:{0}", k);
        int __expected = 22369;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection4().howManyWays(board, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
