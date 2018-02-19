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
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "R.......",
            ".R......",
            "..R.....",
            "...R....",
            "....R...",
            ".....R..",
            "......R.",
            ".......R"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "........",
            "....R...",
            "........",
            ".R......",
            "........",
            "........",
            "..R.....",
            "........"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "......R.",
            "....R...",
            "...R....",
            ".R......",
            "R.......",
            ".....R..",
            "..R.....",
            ".......R"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "......R.",
            "....R...",
            "...R....",
            ".R......",
            "R.......",
            ".......R",
            "..R.....",
            ".......R"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new EightRooks().isCorrect(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
