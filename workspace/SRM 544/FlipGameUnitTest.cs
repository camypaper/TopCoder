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
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "1000",
            "1110",
            "1111"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "1111",
            "1111",
            "1111"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "00",
            "00",
            "00"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "00000000",
            "00100000",
            "01000000",
            "00001000",
            "00000000"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "000000000000001100000000000000",
            "000000000000011110000000000000",
            "000000000000111111000000000000",
            "000000000001111111100000000000",
            "000000000011111111110000000000",
            "000000000111111111111000000000",
            "000000001100111111001100000000",
            "000000011000011110000110000000",
            "000000111100111111001111000000",
            "000001111111111111111111100000",
            "000011111111111111111111110000",
            "000111111111000000111111111000",
            "001111111111100001111111111100",
            "011111111111110011111111111110",
            "111111111111111111111111111111"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 29;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FlipGame().minOperations(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
