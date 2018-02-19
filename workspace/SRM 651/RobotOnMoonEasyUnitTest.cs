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
    public void ManualTest(string[] board, string S)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        Console.WriteLine("S:{0}", S);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            ".....",
            ".###.",
            "..S#.",
            "...#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "URURURURUR";
        Console.WriteLine("S:{0}", S);
        string __expected = "Alive";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            ".....",
            ".###.",
            "..S..",
            "...#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "URURURURUR";
        Console.WriteLine("S:{0}", S);
        string __expected = "Dead";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            ".....",
            ".###.",
            "..S..",
            "...#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "URURU";
        Console.WriteLine("S:{0}", S);
        string __expected = "Alive";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "#####",
            "#...#",
            "#.S.#",
            "#...#",
            "#####"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "DRULURLDRULRUDLRULDLRULDRLURLUUUURRRRDDLLDD";
        Console.WriteLine("S:{0}", S);
        string __expected = "Alive";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "#####",
            "#...#",
            "#.S.#",
            "#...#",
            "#.###"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "DRULURLDRULRUDLRULDLRULDRLURLUUUURRRRDDLLDD";
        Console.WriteLine("S:{0}", S);
        string __expected = "Dead";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] board = new string[] {
            "S"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string S = "R";
        Console.WriteLine("S:{0}", S);
        string __expected = "Dead";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RobotOnMoonEasy().isSafeCommand(board, S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
