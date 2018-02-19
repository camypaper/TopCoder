using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string[] s = Scanner.In.string_array();
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        int k = Scanner.In.@int();
        Console.WriteLine("k:{0}", k);
        string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string[] s, int k)
    {
                        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
                        Console.WriteLine("k:{0}", k);
                string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] s = new string[] {
            "TE"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscape().findWinner(s, k);
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
        int k = 1000000;
        Console.WriteLine("k:{0}", k);
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] s = new string[] {
            "T.T.T.",
            ".E.E.E"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] s = new string[] {
            "TTE"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 6;
        Console.WriteLine("k:{0}", k);
        string __expected = "Alice";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] s = new string[] {
            "..........................",
            "......TTT..TTT..T...T.....",
            ".....T.....T..T.TT.TT.....",
            "......TTT..TTT..T.T.T.....",
            ".........T.T.T..T...T.....",
            "......TTT..T..T.T...T.....",
            "..........................",
            "...E#E#E#E#E#E#E#E#E#E#...",
            "..........................",
            "......TTT..TTT...TTT......",
            ".....T........T.T.........",
            "......TTT.....T..TTT......",
            ".....T...T...T..T...T.....",
            "......TTT....T...TTT......",
            "..........................",
            "...#E#E#E#E#E#E#E#E#E#E...",
            "..........................",
            "....TT...T...T..T.TTT.T...",
            "...T.....T...T..T.T...T...",
            "...T.TT..T...TTTT.TT..T...",
            "...T..T..T...T..T.T.......",
            "....TT...TTT.T..T.T...T...",
            ".........................."
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int k = 987654321;
        Console.WriteLine("k:{0}", k);
        string __expected = "Bob";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BoardEscape().findWinner(s, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
