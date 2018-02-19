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
    public void ManualTest(string[] s, int k)
    {
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        Console.WriteLine("k:{0}", k);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] s = new string[] {
            "T.#",
            "#.E"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] s = new string[] {
            "E#E",
            "#T#",
            "E#E"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 99;
        Console.WriteLine("k:{0}", k);
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] s = new string[] {
            "#E...",
            "#...E",
            "E.T#.",
            "..#.."
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 13;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] s = new string[] {
            "TE"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 50;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] s = new string[] {
            ".T."
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] s = new string[] {
            "..........................",
            "......EEE..EEE..E...E.....",
            ".....E.....E..E.EE.EE.....",
            "......EEE..EEE..E.E.E.....",
            ".........E.E.E..E...E.....",
            "......EEE..E..E.E...E.....",
            "..........................",
            "...E#E#E#E#E#E#E#E#E#E#...",
            "..........................",
            "......EEE..EEE...EEE......",
            ".....E........E.E.........",
            "......EEE.....E..EEE......",
            ".....E...E...E..E...E.....",
            "......EEE....E...EEE......",
            "..........................",
            "...#E#E#E#E#E#E#E#E#E#E...",
            "..........................",
            "....EE...E...E..E.EEE.E...",
            "...E.....E...E..E.E...E...",
            "...E.EE..E...EEEE.EE..E...",
            "...E..E..E...E..E.E.......",
            "....EE...EEE.E..E.E...E...",
            "T........................."
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 100;
        Console.WriteLine("k:{0}", k);
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscapeDiv2().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
