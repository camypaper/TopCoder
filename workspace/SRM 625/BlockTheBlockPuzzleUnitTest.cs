using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);        
    }
	public void ManualTest(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new BlockTheBlockPuzzle().minimumHoles(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] board)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        int __expected = new BlockTheBlockPuzzle().minimumHoles(board);
        
        int __result = new BlockTheBlockPuzzle().Naive_Test(board);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] board)
    {
        Console.WriteLine(string.Format("board:{0}", string.Join(" ",board)));
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "b..$",
            "....",
            "HHHH",
            "HHHH"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "............H..",
            "...............",
            "...............",
            "HHH$HHH.....H..",
            "HHHHHHH........",
            "HHHHHHHH.......",
            "......b..H.....",
            "...............",
            "...............",
            "...H..H..H.....",
            "...............",
            "...............",
            "...............",
            "...............",
            "..............."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "............H..",
            "...............",
            "...............",
            "HHH$HHH........",
            "HHHHHHH........",
            "HHHHHHHH.......",
            "......b..H.....",
            "...............",
            "...............",
            "...H..H..H.....",
            "...............",
            "...............",
            "...............",
            "...............",
            "..............."
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "b..$...",
            "...H...",
            ".......",
            "b..b..b",
            "...H...",
            ".......",
            "b..b..b"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "b..b..b",
            "..b..b.",
            ".......",
            "b..$bbb",
            ".b.....",
            "....b..",
            "b..b..b"
        };
        Console.WriteLine(string.Format("board:{0}", string.Join(" ", board)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlockTheBlockPuzzle().minimumHoles(board);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
