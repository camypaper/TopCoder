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
    public void ManualTest(string[] board, int r)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        Console.WriteLine("r:{0}", r);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            ".#.#."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int r = 2;
        Console.WriteLine("r:{0}", r);
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "..###.",
            ".###.#"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int r = 4;
        Console.WriteLine("r:{0}", r);
        double __expected = 1.6;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "..###.",
            ".###.#"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int r = 5;
        Console.WriteLine("r:{0}", r);
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            ".....",
            "#...."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int r = 4;
        Console.WriteLine("r:{0}", r);
        double __expected = 1.253968253968254;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            ".#####.#####..#....#",
            "#......#....#.##..##",
            ".####..#####..#.##.#",
            ".....#.#...#..#....#",
            "#####..#....#.#....#"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int r = 19;
        Console.WriteLine("r:{0}", r);
        double __expected = 5.77311527122319;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new ClosestRabbit().getExpected(board, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
